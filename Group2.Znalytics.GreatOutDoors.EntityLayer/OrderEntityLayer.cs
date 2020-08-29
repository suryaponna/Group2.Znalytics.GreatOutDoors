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
        private string _addToCart;   //one order id may have multiple product id
        private string _quantity;     //each product has its own quantity
        private string _sellingPrice;   //each product has a unique selling price
        private string _totalAmount;    //_quantity*_sellingPrice
        private string _amountPayable;  //total amount payable
        private string _finalDelieveryAddress;
        //private DateTime _timeOfSale;  //for time on shelf      
        private string _orderID;

        public OrderProduct()
        {
        }

        /// <summary>
        /// Constructor that initializes the details to order the product
        /// </summary>
        /// <param name="ProductID"></param>
        /// <param name="AddToCart"></param>
        /// <param name="Quantity"></param>
        /// <param name="SellingPrice"></param>
        /// <param name="TotalAmount"></param>
        /// <param name="AmountPayable"></param>
        /// <param name="FinalDelieveryAddress"></param>
        /// <param name="TimeOfSale"></param>
        /// <param name="OrderID"></param>
        public OrderProduct(string ProductID, string AddToCart, string Quantity, string SellingPrice, string TotalAmount, string AmountPayable, string FinalDelieveryAddress, string TimeOfSale, string OrderID)
        {
            _productID = ProductID;
            _addToCart = AddToCart;
            _quantity = Quantity;
            _sellingPrice = SellingPrice;
            _totalAmount = TotalAmount;
            _amountPayable = AmountPayable;
            _finalDelieveryAddress = FinalDelieveryAddress;
            // _timeOfSale = TimeOfSale;
            _orderID = OrderID;
        }
        public string ProductID
        {
            set
            {
                if (value.Length <= 10)
                {
                    _productID = value;
                }

            }
            get
            {
                return _productID;
            }
        }
        public string AddToCart
        {
            set
            {
                if (value.Length <= 10)
                {
                    _addToCart = value;
                }
            }
            get
            {
                return _addToCart;
            }
        }
        public string Quantity
        {
            set
            {
                if (value.Length <= 10)
                {
                    _quantity = value;
                }
            }
            get
            {
                return _quantity;
            }
        }
        public string SellingPrice
        {
            set
            {
                if(value.Length<=10)
                {
                    _sellingPrice = value;
                }
            }
            get
            {
                return _sellingPrice;
            }
        }
        public string TotalAmount
        {
            set
            {
                if(value.Length<=10)
                {
                    _totalAmount = value;
                }
            }
            get
            {
                return _totalAmount;
            }
        }
        public string AmountPayable
        {
            set
            {
                if(value.Length<=10)
                {
                    _amountPayable = value;
                }
            }
            get
            {
                return _amountPayable;
            }
        }
        public string FinalDelieveryAddress
        {
            set
            {
                if(value.Length<=50)
                {
                    _finalDelieveryAddress = value;
                }
            }
            get
            {
                return _finalDelieveryAddress;
            }
        }
       public string OrderID
        {
            set
            {
                if(value.Length<=10)
                {
                    _orderID = value;
                }
            }
            get
            {
                return _orderID;
            }
        }

        public string ProductName { get; set; }
    }
}

