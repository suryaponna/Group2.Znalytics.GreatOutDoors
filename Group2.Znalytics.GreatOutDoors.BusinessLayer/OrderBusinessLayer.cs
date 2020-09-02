using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using GreatOutdoorsProduct.BusinessLayer;
using GreatOutdoorsProduct.Entities;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Microsoft.Win32;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public class OrderBusinessLayer : IOrderBusinessLayer
    {
        OrderDataLayer _od;
        /// <summary>
        /// Represents a Constructor for Order Business Layer class
        /// </summary>
        public OrderBusinessLayer()
        {
            //Creating Object for DataLayer
            _od = new OrderDataLayer();
        }

        //Creating Reference variable for interface IproductBusinessLayer
        IProductBusinessLayer product = new ProductBusinessLayer();
        /// <summary>
        /// Method for Displaying Products
        /// </summary>
        /// <returns></returns>
        public List<Product> DisplayProducts()
        {
            return product.DisplayProducts();
        }

        public Product ProductDetails(string ProductID)
        {
            return product.GetProductByProductID(ProductID);
        }

        /*  public Customer GetCustomerDetailsByCustomerID(int CustomerId)
          {
              return UpdateCustomerAddressDetails.GetCustomerById(CustomerId);
          }*/


        /// <summary>
        /// Adding orderDetails 
        /// </summary>
        /// <param name="order"></param>
        public void AddOrderDetails(OrderProduct values)
        {
            try
            {
                _od.AddOrderDetails(values);
            }
            catch(Exception)
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
        /// <summary>
        /// Cancel OrderDetails by OrderId
        /// </summary>
        /// <param name="value"></param>
        public void CancelOrderDetails(int value)
        {
            _od.CancelOrder(value);
        }

        public Product ProductDetails(object productId)
        {
            throw new NotImplementedException();
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

        public Customer GetOrderDetailsByCustomerID(object customerID)
        {
            throw new NotImplementedException();
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
        public List<OrderProduct> GetOrderDetailsByCustomerID(string value)
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

        public void UpdateQuantity(int orderId,int value)
        {
            _od.UpdateQuantity(orderId, value);
        }

        public List<OrderProduct> GetOrderDetailsByEMployeeID(int value)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerAddressDetails(int orderId, string addressID)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerAddressDetails(int orderId, int customerId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductDetails(int orderId, string productId)
        {
            throw new NotImplementedException();
        }
    }
}
          


//DateTime eligibleDate = DateTime.Now;