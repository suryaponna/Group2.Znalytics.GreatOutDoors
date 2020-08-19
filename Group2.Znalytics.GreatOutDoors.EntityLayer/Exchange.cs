using System;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    
    
        //class
        public class Exchange
        {
            //private fields
            private string _customerName;
            private string _mobileNumber;
            private string _address;
            private string _productId;
            private string _exchangeDelieveredProduct;

            /// <summary>
            /// Constructor that Intialises the details of customer
            /// </summary>
            /// <param name="customerName"></param>
            /// <param name="mobileNumber"></param>
            /// <param name="address"></param>
            /// <param name="productId"></param>
            /// <param name="exchangeDelieveredProduct"></param>
            public void Customer(string customerName, string mobileNumber, string address, string productId, string exchangeDelieveredProduct)
            {

                _customerName = customerName;
                _mobileNumber = mobileNumber;
                _address = address;
                _productId = productId;
                _exchangeDelieveredProduct = exchangeDelieveredProduct;
            }
        /// <summary>
        /// Intializes the properties 
        /// </summary>
            public string CustomerName
            {
                set
                {
                    if (value.Length <= 10)
                    {
                        _customerName = value;
                    }

                }
                get
                {
                    return _customerName;
                }
            }
            public string MobileNumber
            {
                set
                {
                    if (value.Length <= 30)
                    {
                        _mobileNumber = value;
                    }

                }
                get
                {
                    return _mobileNumber;
                }
            }
            public string address
            {
                set
                {
                    if (value.Length <= 30)
                    {
                        _address = value;
                    }

                }
                get
                {
                    return _address;
                }
            }
            public string ProductId
            {
                set
                {
                    if (value.Length <= 30)
                    {
                        _productId = value;
                    }

                }
                get
                {
                    return _productId;
                }
            }
            public string ExchangeDelieveredProduct
            {
                set
                {
                    if (value.Length <= 30)
                    {
                        _exchangeDelieveredProduct = value;
                    }

                }
                get
                {
                    return _exchangeDelieveredProduct;
                }
            }

        }
    }

