using System;
using System.Collections.Generic;
using System.Linq;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    /// <summary>
    /// Represents details of Order
    /// </summary>
   public class OrderEntityLayer
    {
        //private fields
        private string _customerName;
        private string _productID;
        private string _quantity;
        private string _address;
        private string _addToCart;
        private string _paymentprocess;
        /// <summary>
        /// Constructor that initializes the details of Customer
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="productID"></param>
        /// <param name="address"></param>
        /// <param name="quantity"></param>
        /// <param name="addToCart"></param>
        /// <param name="paymentprocess"></param>
        public void Customer(string customerName,string productID,string address,string quantity,string addToCart,string paymentprocess)
        {
            _customerName = customerName;
            _productID = productID;
            _address = address;
            _quantity = quantity;
            _addToCart = addToCart;
            _paymentprocess = paymentprocess;
        }
        /// <summary>
        /// Initializes the property of customerName
        /// </summary>
        public string CustomerName
        {
            set
            {
                if(value.Length <= 10)
                {
                    this._customerName = value;
                    else
                        throw new Exception("Your name exceeded the size that maximum characters are 14");
                }
            }
            get
            {
                return _customerName;
            }
        }

        public string ProductID
        {
            set
            {
                if(value.Length <=20)
                {
                    this._productID = value;
                }

            }
            get
            {
                return _productID;
            }
        }
        public string Address
        {
            set
            {
                if(value.Length<=50)
                {
                    this._address = value;
                }
            }
            get
            {
                return _address;
            }
        }
        public string AddToCart
        {
            set
            {
                if(value.Length<30)
                {
                    this._addToCart = value;
                }
            }
            get
            {
                return _addToCart;
            }
        }
        public string PaymentProcess
        {
            set
            {
                if(value.Length<=30)
                {
                    this._paymentprocess = value;
                }
            }
            get
            {
                return _paymentprocess;
            }
        }
    }

}
