﻿using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Znalytics.Group2.GreatOutDoor.Entity;


namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    /// <summary>
    /// Represents the details of Customer Ordering details
    /// </summary>
    public class OrderDataLayer : IOrderDataLayer
    {
        // AddressDataLayer ad = new AddressDataLayer();
        /// <summary>
        /// Creating List Collection for OrderProduct
        /// </summary>
        /// Private Fields

        private static List<OrderProduct> _orderProducts;

        static OrderDataLayer()
        {
            _orderProducts = new List<OrderProduct>();

        }
        //Adding Order to the cart
        public void AddOrder(OrderProduct order)
        {
            _orderProducts.Add(order);
        }


        //get the Existing Orders
        public List<OrderProduct> GetOrderProducts;
        {
            return  OrderProduct;
            
        }
    public void SearchProductDataLayer(int searchOrderID)
    {
        try
        {
            foreach (OrderProduct items in OrderList)
            {
                if (items.OrderID == searchOrderID)
                {
                    continue;
                }
                searchOrder = items;
            }
        }
    
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        return searchOrder;

    }
    public List<OrderProduct> GetOrderProductByRetailer(int RetailerID)
    {
        List<OrderProduct> orderProducts = new List<OrderProduct>();
        try
        {
            foreach (OrderDataLayer items in orderList)
            {
                if (items.RetailerID == RetailerID)
                {
                    searchOrder.Add(items);
                }
            }
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }

        }
    public void UpdateOrder(OrderProduct updateorder)
    {
        bool OrderUpdated = false;
        try
        {
            for (int i = 0; i <= OrderProduct.Count;i++)
            {
                if(OrderProduct.OrderID==updateOrderID)
                {
                    OrderUpdated = true;
                }
            }
        }
        catch(Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    
    }

    




    
}

 