﻿#pragma checksum "C:\WindowsAzure\WATWindowsPhone2\Samples\WP7.1\CRUDSqlAzure3\CRUDSqlAzure.Phone\Pages\RestaurantDishDetailsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D12A8844B44DE4CCBAFA80AE3F6CBADD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Microsoft.Samples.CRUDSqlAzure.Phone.Pages {
    
    
    public partial class RestaurantDishDetailsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image DishImage;
        
        internal System.Windows.Controls.Button rateButton;
        
        internal System.Windows.Controls.TextBlock DishPrice;
        
        internal System.Windows.Controls.TextBlock DishDescription;
        
        internal System.Windows.Controls.ListBox ItemsListBox;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Microsoft.Samples.CRUDSqlAzure.Phone;component/Pages/RestaurantDishDetailsPage.x" +
                        "aml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.DishImage = ((System.Windows.Controls.Image)(this.FindName("DishImage")));
            this.rateButton = ((System.Windows.Controls.Button)(this.FindName("rateButton")));
            this.DishPrice = ((System.Windows.Controls.TextBlock)(this.FindName("DishPrice")));
            this.DishDescription = ((System.Windows.Controls.TextBlock)(this.FindName("DishDescription")));
            this.ItemsListBox = ((System.Windows.Controls.ListBox)(this.FindName("ItemsListBox")));
        }
    }
}

