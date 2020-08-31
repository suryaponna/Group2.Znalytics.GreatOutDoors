using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Microsoft.Win32;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public class OrderBusinessLayer : IOrderBusinessLayer
    {
        OrderDataLayer _od;




        /// <summary>
        /// Constructor for Order Business Layer
        /// </summary>
        public OrderBusinessLayer()
        {
            //Creating Object for DataLayer
            _od = new OrderDataLayer();
        }

        /// <summary>
        /// Adding orderDetails 
        /// </summary>
        /// <param name="order"></param>
        public void AddOrderDetails(OrderProduct order)
        {
            List<OrderProduct> orderProducts = new List<OrderProduct>();
            try
            {
                _od.AddOrderDetails(order);
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Get OrderDetails
        /// </summary>
        /// <returns></returns>
        public List<OrderProduct> GetOrderDetails()
        {
            List<OrderProduct> orderDetails = _od.GetOrderDetails();
            return orderDetails;
        }

        public void CancelOrderDetails(int value)
        {
            _od.CancelOrder(value);
        }

        /// <summary>
        /// Getting Product Details by AddressID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderProduct> GetOrderDetailsByAddressID(string value)
        {
            List<OrderProduct> orders = _od.GetOrderDetailsByAddressID(value);
            return orders;

        }

        /// <summary>
        /// Get order Details by Product Id 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderProduct> GetOrderDetailsByProductID(string value)
        {
            return _od.GetOrderDetails(value);
        }



        /// <summary>
        /// Get order details by Customer ID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderProduct> GetOrderDetailsByCustomerID(int value)
        {
            return _od.GetOrderDetails(value);
        }
        public int OrderID()
        {
            return _od.GetOrder();
        }

        /// <summary>
        /// Update the Product Details
        /// </summary>
        /// <param name="OrderID"></param>
        /// <param name="value"></param>
        public void UpdateProductDetails(int OrderID, List<OrderProduct> value)
        {
            _od.UpdateProductDetails(OrderID, value);
        }
        public void UpdateCustomerAddressDetails(int OrderID, Customer value)
        {
            _od.UpdateCustomerAddressDetails(OrderID, value);
        }
        /// <summary>
        /// Get the Order of Products
        /// </summary>
        /// <returns></returns>
        public List<OrderProduct> GetOrderProducts()
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> GetOrderDetailsByEMployeeID(int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///Getting Order details from CustomerId
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

    }
}
          


//DateTime eligibleDate = DateTime.Now;