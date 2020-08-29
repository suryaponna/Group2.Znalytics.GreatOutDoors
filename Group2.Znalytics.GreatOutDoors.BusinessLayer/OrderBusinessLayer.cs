using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Remoting;
using System.Text;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Microsoft.Win32;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public class OrderBusinessLayer
    {

        private OrderDataLayer orderDataLayer;
        private object _orderDataLayer;
        private string FinalDelieveryAddress;
        private int ProductID;
        private int Quantity;
        private int SellingPrice;
        private int TotalAmount;
        private int AmountPayable;
        private int OrderID;

        public OrderBusinessLayer()
        {
            OrderDataLayer _orderDataLayer = new OrderDataLayer();
        }

       

        private static bool ValidateOrder(OrderBusinessLayer order)
        {
            StringBuilder sb = new StringBuilder();
            bool ValidOrder = true;
            if (order.ProductID < = 0)
            {
                ValidOrder = false;
                sb.Append(Environment.NewLine + "InvalidID");
            }
            if (order.Quantity <= 0)
            {
                ValidOrder = false;
                sb.Append(Environment.NewLine + "Name Required");
            }
            if (order.SellingPrice <= 0)
            {
                ValidOrder = false;
                sb.Append(Environment.NewLine + "Name Required");
            }
            if (order.TotalAmount < = 0)
            {
                ValidOrder = false;
                sb.Append(Environment.NewLine + "Name Required");
            }
            if (order.AmountPayable < = 0)
            {
                ValidOrder = false;
                sb.Append(Environment.NewLine + "Name Required");
            }
            if (order.FinalDelieveryAddress == string.Empty)
            {
                ValidOrder = false;
                sb.Append(Environment.NewLine + "Name Required");
            }
            if (order.OrderID < = 0)
            {
                ValidOrder = false;
                sb.Append(Environment.NewLine + "Invalid Guest ID");
            }
            if (ValidOrder == false)
            {
                throw new OrderException(sb.ToString());
                return ValidOrder;
            }
        }
        public static bool AddOrderBusinessLayer(OrderBusinessLayer newOrder)
        {
            bool orderAdded = false;
            try
            {
                if (ValidateOrder(newOrder))
                    OrderDataLayer odl= new OrderDataLayer();
                orderAdded = odl.AddOrderDataLayer(newOrder);
            }
            catch (OrderException)
            {
                throw;
            }
            catch(ApplicationException ex)
            {
                throw ex;
            }
            return orderAdded;
        }
        public 



            }
        }



    }
}










DateTime eligibleDate = DateTime.Now;