namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    //class
    public class ExchangeEntityLayer
    {
        //private fields
        private string _customerID;
        private string _customerName;
        private string _mobileNumber;
        private string _address;
        private string _productID;
        private string _exchangeDelieveredProduct;

        /// <summary>
        /// Constructor that Intialises the details of customer
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="address"></param>
        /// <param name="productId"></param>
        /// <param name="exchangeDelieveredProduct"></param>
        public void Customer(string customerID, string customerName, string mobileNumber, string address, string productID, string exchangeDelieveredProduct)
        {
            _customerID = customerID;
            _customerName = customerName;
            _mobileNumber = mobileNumber;
            _address = address;
            _productID = productID;
            _exchangeDelieveredProduct = exchangeDelieveredProduct;
        }
        /// <summary>
        /// Intializes the properties of CustomerID
        /// </summary>
        public string CustomerID
        {
            set
            {
                if (value.Length <= 10)
                {
                    _customerID = value;
                }

            }
            //get the CustomerID
            get
            {
                return _customerID;
            }
        }
        /// <summary>
        /// initializes Properties of CustomerName
        /// </summary>
        public string CustomerName
        {
            set
            {
                if (value.Length <= 30)
                {
                    _customerName = value;
                }

            }
            //gets the CustomerName
            get
            {
                return _customerName;
            }
        }
        /// <summary>
        /// ///Properties of MobileNumber
        /// </summary>
        public string MobileNumber
        {
            set
            {
                if (value.Length <= 30)
                {
                    _mobileNumber = value;
                }

            }
            //gets the Mobile Number
            get
            {
                return _mobileNumber;
            }
        }
        /// <summary>
        /// Intialize the Address of customer
        /// </summary>
        public string address
        {
            set
            {
                if (value.Length <= 50)
                {
                    _address = value;
                }

            }
            //gets the address
            get
            {
                return _address;
            }
        }
        /// <summary>
        /// Intializes the ProductID
        /// </summary>
        public string ProductID
        {
            set
            {
                if (value.Length <= 10)
                {
                    _productID = value;
                }

            }
            //gets the productID
            get
            {
                return _productID;
            }
        }
        /// <summary>
        /// initialize the ExcahngeDelieveredProduct
        /// </summary>
        public string ExchangeDelieveredProduct
        {
            set
            {
                if (value.Length <= 30)
                {
                    _exchangeDelieveredProduct = value;
                }

            }
            //gets the exchangeDelieveredProduct
            get
            {
                return _exchangeDelieveredProduct;
            }
        }

    }
}




