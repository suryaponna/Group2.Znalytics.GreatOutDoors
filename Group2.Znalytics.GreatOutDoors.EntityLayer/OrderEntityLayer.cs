using GreatOutdoorsProduct.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    /// <summary>
    /// Represents details of Order 
    /// </summary>
    public class OrderProduct 
    {


        //private fields
        private string _productID;
        private int _customerAddressID;
        private int _orderID;
        private double _totalprice;
        private int _quantity;   //each product has its own 
       

        
       /// <summary>
       /// Constructor that initializes the fields
       /// </summary>
       /// <param name="ProductID"></param>
       /// <param name="CustomerAddressID"></param>
       /// <param name="OrderID"></param>
       /// <param name="TotalPrice"></param>
       /// <param name="Quantity"></param>
        public OrderProduct(string ProductID,int CustomerAddressID,int OrderID,int TotalPrice,int Quantity)
        {
            _productID = ProductID;
            _customerAddressID = CustomerAddressID;
            _orderID = OrderID;
            _totalprice = TotalPrice;
            _quantity = Quantity;

        }

        /// <summary>
        /// Default Constructor
        /// </summary>

        public OrderProduct()
        {

        }

        /// <summary>
        /// Property for setting values to productsID field and getting the value of the ProductID field
        /// </summary>

        public string ProductID
        {
            set
            {
                ;
                if (value != null)
                {
                    _productID = value;
                }
                else
                {
                    throw new OrderException("Select atleast One Product");
                }
            }
            get
            {
                return _productID;
            }
        }

        /// <summary>
        /// Property for setting values to customer address field and getting the values of customer address field
        /// </summary>
        public int CustomerAddressID
        {
            set
            {
                if (value != 0)
                {
                    _customerAddressID = value;
                }
                else
                {
                    throw new OrderException("Select Customer Address");
                }

            }
            get
            {
                return _customerAddressID;
            }
        }

        /// <summary>
        /// Property for setting values to orderid and getting the value of the orderId field
        /// </summary>
        public int OrderID
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

        /// <summary>
        /// Property for getting values to Quantity field and getting the values from the price field
        /// </summary>
        public int Quantity
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

        public bool Equals(OrderProduct other)
        {
            throw new NotImplementedException();
        }
    }
}