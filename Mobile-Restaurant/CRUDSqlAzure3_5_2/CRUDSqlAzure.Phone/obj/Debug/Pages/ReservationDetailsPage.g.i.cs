﻿#pragma checksum "C:\WindowsAzure\WATWindowsPhone2\Samples\WP7.1\CRUDSqlAzure3\CRUDSqlAzure.Phone\Pages\ReservationDetailsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4CF90B2187ADC06FF99BE355088BFF70"
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
    
    
    public partial class ReservationDetailsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock nameBox;
        
        internal System.Windows.Controls.Image restaurantImage;
        
        internal System.Windows.Controls.TextBlock AddressBox;
        
        internal System.Windows.Controls.TextBlock CityBox;
        
        internal System.Windows.Controls.TextBlock PhoneBox;
        
        internal System.Windows.Controls.TextBlock DateBox;
        
        internal System.Windows.Controls.TextBlock TimeBox;
        
        internal System.Windows.Controls.ProgressBar mvProgressBar;
        
        internal System.Windows.Controls.Button button1;
        
        internal System.Windows.Controls.Button button2;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Microsoft.Samples.CRUDSqlAzure.Phone;component/Pages/ReservationDetailsPage.xaml" +
                        "", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.nameBox = ((System.Windows.Controls.TextBlock)(this.FindName("nameBox")));
            this.restaurantImage = ((System.Windows.Controls.Image)(this.FindName("restaurantImage")));
            this.AddressBox = ((System.Windows.Controls.TextBlock)(this.FindName("AddressBox")));
            this.CityBox = ((System.Windows.Controls.TextBlock)(this.FindName("CityBox")));
            this.PhoneBox = ((System.Windows.Controls.TextBlock)(this.FindName("PhoneBox")));
            this.DateBox = ((System.Windows.Controls.TextBlock)(this.FindName("DateBox")));
            this.TimeBox = ((System.Windows.Controls.TextBlock)(this.FindName("TimeBox")));
            this.mvProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("mvProgressBar")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
            this.button2 = ((System.Windows.Controls.Button)(this.FindName("button2")));
        }
    }
}

