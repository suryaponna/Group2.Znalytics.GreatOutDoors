using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using Znalytics.Group2.GreatOutDoor.Entity;


namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    /// <summary>
    /// Represents the details of Customer Ordering details
    /// </summary>
    public class OrderDataLayer // IOrderDataLayer
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
            _orderProducts.Add(values)
                SaveIntoFile();
            
        }

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

        public void CancelOrder(int value)
        {
            OrderProduct order = _orderProducts.Find(temp => temp.OrderID == value);
            _orderProducts.Remove(order);
        }

        public List<OrderProduct> GetOrderDetails(int value)
        {
            throw new NotImplementedException();
        }

        public int GetOrder()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductDetails(int orderID, List<OrderProduct> value)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerAddressDetails(int orderID, Customer value)
        {
            throw new NotImplementedException();
        }
    }
    
    }

    




    
}

 