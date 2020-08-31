using GreatOutdoorsProduct.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    /// <summary>
    /// Represents details of Order and IEquatable is for comparing two customers are same or not
    /// </summary>
    public class OrderProduct  ///IEquatable<OrderProduct>
    {
        //private fields
        List<Product> _products;
        Customer _customerAddress;
        private int _orderID;
        double _totalPrice;    //_quantity*_sellingPrice
        int _quantity;     //each product has its own   

        /// <summary>
        /// Auto Implemented Property
        /// </summary>
        public OrderProduct()
        {
        }


        public OrderProduct(List<Product> products,Customer customerAddress,int OrderID,double TotalPrice,int Quantity)
        {
            _products = products;
            _customerAddress = customerAddress;
            _orderID = OrderID;
            _totalPrice = TotalPrice;
            _quantity = Quantity;
        }
       /// <summary>
       /// Property for setting values and getting values of the field
       /// </summary>
        public List<Product> products

        {
            set
            {
               if(value!= null)
                {
                    _products = value;
                }
                else
                {
                    throw new OrderProductEXception("Select atleast one Product");
                }

            }
            get
            {
                return _products;
            }
        }
        public Customer CustomerAddress
        {
            set
            {
                if(value!=null)
                {
                    _customerAddress = value;
                }
            }
            get
            {
                return _customerAddress;
            }
        }


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

        public double TotalPrice
        {
            set
            {
                if (value >  0)
                {
                    _totalPrice = value;
                }
            }
            get
            {
                return _totalPrice;
            }
        }
        public int Quantity
        {
            set
            {
                if (value > 0 && value != ' ')
                {
                    _quantity = value;
                }
                
            }
            get
            {
                return _quantity;
            }
        }

       

    }

}

