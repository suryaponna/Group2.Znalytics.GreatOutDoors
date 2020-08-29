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

        public OrderBusinessLayer()
        {
            OrderDataLayer _orderDataLayer = new OrderDataLayer();
        }

        public int OrderID { get; private set; }
        public int Quantity { get; private set; }
        public int SellingPrice { get; private set; }
        public int TotalAmount { get; private set; }
        public int AmountPayable { get; private set; }
        public string FinalDelieveryAddress { get; private set; }
        public int ProductID { get; private set; }

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
                    OrderDataLayer guestDAL = new OrderDataLayer();
                orderAdded = guestDAL.AddOrderDAL(newOrder);
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
        



            }
        }



    }
}










DateTime eligibleDate = DateTime.Now;