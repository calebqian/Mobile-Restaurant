﻿// ----------------------------------------------------------------------------------
// Microsoft Developer & Platform Evangelism
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// ----------------------------------------------------------------------------------
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
// ----------------------------------------------------------------------------------

namespace Microsoft.Samples.CRUDSqlAzure.Phone.Models
{
    using System;
    using System.Data.Services.Client;

    public class NorthwindContext : DataServiceContext
    {
        public NorthwindContext(Uri serviceRoot)
            : base(serviceRoot)
        {
            this.MergeOption = MergeOption.OverwriteChanges;
            this.SaveChangesDefaultOptions = SaveChangesOptions.ContinueOnError;
        }

        public void AddToCategories(Category category)
        {
            this.AddObject("Categories", category);
        }

        public void AddToCustomers(Customer customer)
        {
            this.AddObject("Customers", customer);
        }

        public void AddToDishes(Dish dish)
        {
            this.AddObject("Dishes", dish);
        }

        public void AddToRestaurants(Restaurant restaurant)
        {
            this.AddObject("Restaurants", restaurant);
        }

        public void AddToReservations(Reservation reservation)
        {
            this.AddObject("Reservations", reservation);
        }

        public void AddToOrders(Order order)
        {
            this.AddObject("Orders", order);
        }

        public void AddToReviews(Review review)
        {
            this.AddObject("Reviews", review);
        }

        public void AddToOrderDetails(OrderDetails orderDetails)
        {
            this.AddObject("OrderDetails", orderDetails);
        }

        public void AttachToCategories(Category category)
        {
            this.AttachTo("Categories", category);
        }

        public void AttachToCustomers(Customer customer)
        {
            this.AttachTo("Customers", customer);
        }

        public void AttachToDishes(Dish dish)
        {
            this.AttachTo("Dishes", dish);
        }

        public void AttachToRestaurants(Restaurant restaurant)
        {
            this.AttachTo("Restaurants", restaurant);
        }

        public void AttachToReservations(Reservation reservation)
        {
            this.AttachTo("Reservations", reservation);
        }

        public void AttachToOrders(Order order)
        {
            this.AttachTo("Orders", order);
        }

        public void AttachToReviews(Review review)
        {
            this.AttachTo("Reviews", review);
        }

        public void AttachToOrderDetails(OrderDetails orderDetails)
        {
            this.AttachTo("OrderDetails", orderDetails);
        }
    }
}
