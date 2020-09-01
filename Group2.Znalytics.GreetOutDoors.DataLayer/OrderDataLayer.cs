using GreatOutdoorsProduct.Entities;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Znalytics.Group2.GreatOutDoor.Entity;


namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    /// <summary>
    /// Represents the details of Customer Ordering details
    /// </summary>
    public class OrderDataLayer //OrderDataLayerAbstract
    {
        // AddressDataLayer ad = new AddressDataLayer();
        /// <summary>
        /// Creating List Collection for OrderProduct
        /// </summary>
        /// Private Fields

        private static List<OrderProduct> _orderProducts;

        public OrderDataLayer()
        {
            _orderProducts = new List<OrderProduct>();

        }

        public void SaveIntoFile()
        {
            string p = JsonConvert.SerializeObject(_orderProducts);
            StreamWriter streamWriter = new StreamWriter(@"C: \Users\Administrator\Desktop.OrderProductJson.txt");
            streamWriter.Write(p);
            streamWriter.Close();
        }

        public List<OrderProduct> GetFileData()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop.OrderProductJson.txt");
            string s1 = streamReader.ReadToEnd();
            List<OrderProduct> orderProducts = JsonConvert.DeserializeObject<List<OrderProduct>>(s1);
            return _orderProducts;
        }

        public List<OrderProduct> GetOrderDetails()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Add OrderDetails in to the file
        /// </summary>
        /// <param name="values"></param>
        public void AddOrderDetails(OrderProduct values)
        {
            _orderProducts.Add(values);
                SaveIntoFile(); 

        }

        /// <summary>
        /// Get order details by AddressID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        public List<OrderProduct> GetOrderDetailsByAddressID(string value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get OrderDetails
        /// </summary>
        /// <returns></returns>
        public List<OrderProduct> GetOrderDetails(string value)
        {
            return GetFileData();
        }
        /// <summary>
        /// cancel the order
        /// </summary>
        /// <param name="value"></param>
        public void CancelOrder(int value)
        {
            OrderProduct order = _orderProducts.Find(temp => temp.OrderID == value);
            _orderProducts.Remove(order);
        }

        public int GetOrder()
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// Get order Details by Product ID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
     /*  public List<OrderProduct> GetOrderDetails( string value)
        {
            List<OrderProduct> order = new List<OrderProduct>();

            foreach (var orders in _orderProducts)
            {
                foreach (var products in orders.Products)
                {
                   // if (products.ProductID = value)
                        
                        order.Add(orders);

                }
                return order;
            }
        }*/

        public void UpdateCustomerAddressDetails(int orderID, Customer value)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductDetails(int orderID, List<OrderProduct> value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get orderDetails by CustomerID
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<OrderProduct> GetOrderDetailByCustomerrID(int value, IEnumerable<object> _orders)
        {
            List<OrderProduct> orders = new List<OrderProduct>();

            
            foreach (var order in _orders)
            {
                //if (orders.CustomerAddress.CustomerID == value)
                {
                  //  order.Add(orders);
                }
            }
            return orders;
        }

        /// <summary>
        /// update product details
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateProductDetails(int orderid, List<Product> value)
        {
           //OrderProduct orders = _ordersProducts.Find(temp => temp.OrderId= orderid);

            //orders.Products = value;
            SaveIntoFile();
        }

        /// <summary>
        /// Update th customer address details
        /// </summary>
        /// <param name="orderid"></param>
        /// <param name="value"></param>
        public void UpdateCustomerAddrerssDetails(int orderid, Customer value)
        {
            //OrderProduct order = _ordersProducts.Find(temp => temp.OrderId == orderid);
           // order.CustomerAddress = value;
            SaveIntoFile();
        }

        
    }

}









