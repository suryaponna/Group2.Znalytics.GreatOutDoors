namespace Group2.Znalytics.GreetOutDoors.Product.Entities
{
    /// <summary>
    /// referes to ProductDetails class in Entities 
    /// </summary>
    public class ProductDetails
    {
        //creating private feilds
        private string _productName;
        private int _productId;
        private string _productColor;
        private string _productType;
        private double _productPrice;


        /// <summary>
        /// Property for ProductName
        /// </summary>
        public string ProductName
        {
            set
            {
                if (value != " ")
                    _productName = value;
            }
            get
            {
                return _productName;
            }
        }

        /// <summary>
        /// Property for ProductID
        /// </summary>
        public int ProductID
        {
            set
            {
                _productId = value;
            }
            get
            {
                return _productId;
            }
        }


        /// <summary>
        /// property for product color///
        /// </summary>
        public string ProductColor
        {
            set
            {
                _productColor = value;
            }
            get
            {
                return _productColor;
            }
        }

        /// <summary>
        /// property for product Type///
        /// </summary>
        public string ProductType
        {
            set
            {
                _productType = value;
            }
            get
            {
                return _productType;
            }
        }

        /// <summary>
        /// Property for Price
        /// </summary>
        public double Productprice { set; get; }

    }
}



   







