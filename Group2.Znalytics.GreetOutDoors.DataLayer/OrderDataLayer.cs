using Group2.Znalytics.GreatOutDoors.EntityLayer;
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
            return  _orderProducts;
        }
    public OrderProduct SearchProductDataLayer(int searchOrderID)
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
            throw new OrderProductException(ex.Message);
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
            throw new OrderProductException(ex.Message);
        }

        }
    public void 
    }

    




    AddressDataLayer ad = new AddressDataLayer();
}

 