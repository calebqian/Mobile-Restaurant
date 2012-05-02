﻿// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, Dishes, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, Dish, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

namespace Microsoft.Samples.CRUDSqlAzure.Phone.Pages
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Navigation;
    using Microsoft.Phone.Controls;
    using Microsoft.Samples.CRUDSqlAzure.Phone.Helpers;
    using Microsoft.Samples.CRUDSqlAzure.Phone.ViewModel;

    public partial class OrderDishesPage : PhoneApplicationPage
    {
        public OrderDishesPage()
        {
            this.InitializeComponent();
            this.ViewModel = new OrderDishesPageViewModel();
            this.Loaded += (s, e) => this.ViewModel.LoadData();
            this.ViewModel.Items.LoadCompleted += new EventHandler<System.Data.Services.Client.LoadCompletedEventArgs>(Items_LoadCompleted);
        }

        void Items_LoadCompleted(object sender, System.Data.Services.Client.LoadCompletedEventArgs e)
        {
            //update total price here
            decimal cur_price=0;
            for (int i = 0; i < this.ViewModel.Items.Count; i++)
            {
                cur_price += (this.ViewModel.Items[i].UnitPrice*this.ViewModel.Items[i].Quantity);
            }
            PriceBox.Text = "Total Price: " + cur_price.ToString("C");
            origHeader.Header = "order";
            UpdateButton.IsEnabled = true;
        }

        public OrderDishesPageViewModel ViewModel
        {
            get { return this.DataContext as OrderDishesPageViewModel; }
            set { this.DataContext = value; }
        }

        protected override void OnBackKeyPress(CancelEventArgs e)
        {
            PhoneHelpers.SetApplicationState("UserBackPress", true);
            base.OnBackKeyPress(e);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.ViewModel.PageNumber = (int)PhoneHelpers.GetApplicationState<int>("CurrentPageNumber");
            string RestIDasString = this.NavigationContext.QueryString["RestaurantID"];
            this.ViewModel.RestID = int.Parse(RestIDasString);
            string ReservationIDasString = this.NavigationContext.QueryString["ReservationID"];
            this.ViewModel.ReservationID = int.Parse(ReservationIDasString);
            this.ViewModel.DishID = -3;

            //PageTitle.Text = this.NavigationContext.QueryString["RestaurantName"];
            
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if (this.ViewModel != null)
            {
                PhoneHelpers.SetApplicationState("CurrentPageNumber", this.ViewModel.PageNumber);
            }
        }

        private void ItemSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selector = sender as Selector;
            if ((selector == null) || (selector.SelectedIndex == -1))
            {
                return;
            }
            //Models.Dish temp = (Models.Dish)selector.Items[selector.SelectedIndex];
            ////PhoneHelpers.SetApplicationState("CurrentRestaurantRow", this.ViewModel.Items[selector.SelectedIndex]);
            //int RestID = this.ViewModel.RestID;
            ////int DishID = this.ViewModel.Items[selector.SelectedIndex].DishID;
            //int DishID = temp.DishID;
            ////string DishName = this.ViewModel.Items[selector.SelectedIndex].DishName;
            //string DishName = temp.DishName;
            ////PhoneHelpers.SetApplicationState("CurrentRestaurantDishRow", this.ViewModel.Items[selector.SelectedIndex]);
            //PhoneHelpers.SetApplicationState("CurrentRestaurantDishRow", temp);
            //this.NavigationService.Navigate(new Uri("/Pages/RestaurantDishDetailsPage.xaml?RestaurantID=" + RestID.ToString() + "&DishID=" + DishID.ToString() + "&DishName=" + DishName, UriKind.Relative));
            selector.SelectedIndex = -1;
        }

        private void LoadMoreItems(object sender, RoutedEventArgs e)
        {
            this.ViewModel.LoadNextPage();
        }

        private void OnAddDish(object sender, EventArgs e)
        {
            //PhoneHelpers.RemoveApplicationState("CurrentDishRow");
            //this.NavigationService.Navigate(new Uri("/Pages/DishDetailsPage.xaml?editDish=false", UriKind.Relative));
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            this.ViewModel.LoadData();
        }

        private void OnLogout(object sender, EventArgs e)
        {
            this.CleanUp();
        }
        
        private void CleanUp()
        {
            // Clean the current authentication token, flags and view models.
            App.CloudClientFactory.CleanAuthenticationToken();
            PhoneHelpers.SetApplicationState("UserBackPress", false);
            PhoneHelpers.RemoveIsolatedStorageSetting("UserIsRegistered");

            this.ViewModel = null;

            // Navigate to the log in page.
            this.NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int RestID = this.ViewModel.RestID;
            int ReservationID = this.ViewModel.ReservationID;
            this.NavigationService.Navigate(new Uri("/Pages/RestaurantDishesPage.xaml?RestaurantID=" + RestID.ToString() + "&ReservationID=" + ReservationID.ToString() + "&isOrder=true", UriKind.Relative));
        }
    }
}