using GreatOutdoorsProduct.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    /// <summary>
    /// Represents details of Order and IEquatable is for comparing two customers are same or not
    /// </summary>
    public class OrderProduct// IEquatable<OrderProduct>
    {
        public List<Product> Products;

        //private fields
        List<Product> products;
        private Customer _customerAddress;
        private string _orderID;
        double _totalprice;
        private int _quantity;     //each product has its own 
        private List<Product> _products;

        /// <summary>
        /// Default Constructor
        /// </summary>

        public OrderProduct(List<Product> products)
        {
            this.Products = products;
        }
        /// <summary>
        /// Cosntructor that intialises the fields
        /// </summary>
        /// <param name="products"></param>
        /// <param name="customerAddress"></param>
        /// <param name="OrderID"></param>
        /// <param name="TotalPrice"></param>
        /// <param name="Quantity"></param>
        public OrderProduct(List<Product> products, Customer customerAddress, string OrderID, double Price, int Quantity)
        {
            products = _products;
            customerAddress = _customerAddress;
            OrderID = _orderID;
            Price = _totalprice;
            Quantity = _quantity;

        }

        /// <summary>
        /// Property for setting values to products field and getting the value of the field
        /// </summary>

        public List<Product> order
        {
            set
            {
                List<Product> products = new List<Product>();
                if (value != null)
                {
                    _products = value;
                }
                else
                {
                    throw new OrderException("Select atleast One Product");
                }
            }
            get
            {
                return _products;
            }
        }

        /// <summary>
        /// Property for setting values to customer address field and getting the values of customer address field
        /// </summary>
        public Customer CustomerAddress
        {
            set
            {
                if (value != null)
                {
                    _customerAddress = value;
                }
                else
                {
                    throw new OrderException("Select Customer Address");
                }

            }
            get
            {
                return _customerAddress;
            }
        }

        /// <summary>
        /// Property for setting values to orderid and getting the value of the orderId field
        /// </summary>
        public string OrderID
        {
            set
            {
                _orderID = value;

            }
            get
            {
                return _orderID;
            }
        }
         /// <summary>
         /// Property for getting values to price field and getting the values from the Price field
         /// </summary>
        public double totalPrice
        {
            set
            {
                if(value > 0)
                {
                    _totalprice = value;
                }
                

            }
            get
            {
                return _totalprice;
            }

        }

        public int Qunatity
        {
            set
            {
                if (value > 0 && value != ' ')
                {
                    _quantity = value;
                }
                else throw new OrderException("Quantity should be greater than 0 ,it should not be null");
            }
            get
            {
                return _quantity;
            }
        }
    }
}