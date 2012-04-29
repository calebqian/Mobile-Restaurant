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
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Controls.Primitives;
    using System.Windows.Navigation;
    using Microsoft.Phone.Controls;
    using Microsoft.Samples.CRUDSqlAzure.Phone.Helpers;
    using Microsoft.Samples.CRUDSqlAzure.Phone.ViewModel;

    public partial class DishesPage : PhoneApplicationPage
    {
        public DishesPage()
        {
            this.InitializeComponent();
            this.ViewModel = new DishesPageViewModel();

            this.Loaded += (s, e) => this.ViewModel.LoadData();
        }
        
        public DishesPageViewModel ViewModel
        {
            get { return this.DataContext as DishesPageViewModel; }
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

            PhoneHelpers.SetApplicationState("CurrentDishRow", this.ViewModel.Items[selector.SelectedIndex]);
            this.NavigationService.Navigate(new Uri("/Pages/DishDetailsPage.xaml?editDish=true", UriKind.Relative));
            selector.SelectedIndex = -1;
        }

        private void LoadMoreItems(object sender, RoutedEventArgs e)
        {
            this.ViewModel.LoadNextPage();
        }

        private void OnAddDish(object sender, EventArgs e)
        {
            PhoneHelpers.RemoveApplicationState("CurrentDishRow");
            this.NavigationService.Navigate(new Uri("/Pages/DishDetailsPage.xaml?editDish=false", UriKind.Relative));
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
    }
}