using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using Znalytics.Group2.GreatOutDoor.Entity;


namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public class OrderDataLayer
    {
        /// <summary>
        /// Creating List Collection for OrderProduct
        /// </summary>
        public static List<OrderProduct> orderList = new List<OrderProduct>();
        public bool AddOrderDataLayer(OrderProduct newOrder)
        {
            bool orderAdded = false;
            try
            {
                orderList.Add(newOrder);
                orderAdded = true;
            }
            catch (SystemException ex)
            {
                throw new OrderException(ex.Message);
            }
            return orderAdded;

        }


        //Constructor
        public OrderDataLayer()
        {
            _productID = new List<OrderProduct>();

        }                        


        AddressDataLayer ad = new AddressDataLayer();
    }


}