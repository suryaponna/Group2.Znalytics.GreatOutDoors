namespace Group2.Znalytics.GreetOutDoors.Product.Entities
{
    /// <summary>
    /// referes to ProductDetails class in Entities 
    /// </summary>
    public class ProductDetails
    {
        //creating private feilds
        public string _productName;
        public int _productId;
        public string _productColor;
        public string _productType;
        public double _productPrice;


        /// <summary>
        /// creating Property for ProductName
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
        /// creating Property for ProductID
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
        /// creating property for product color///
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
        /// creating property for product Type///
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
        /// creating Property for Price
        /// </summary>
        public double Productprice
        {
            set
            {
                _productPrice = value;
            }
            get
            {
                return _productPrice;
            }
        }

    }

    public class Categories
    {
        public string _personalAccessories;
        public string _golfEquipment;
        public string _campingEquipment;
        public string _mountaineeringEquipment;
        public string _outdoorProtection;

        /// <summary>
        /// creating property for personal accesories
        /// </summary>
        public string PersonalAccesories
        {
            set
            {
                _personalAccessories = value;
            }
            get
            {
                return _personalAccessories;
            }
        }
        /// <summary>
        /// creating property for golf equipment
        /// </summary>
        public string GolfEquipment
        {
            set
            {
                _golfEquipment = value;
            }
            get
            {
                return _golfEquipment;

            }
        }
        /// <summary>
        /// creating property for camping equipment
        /// </summary>
        public string CampingEquipment
        {
            set
            {
                _campingEquipment = value;

            }
            get
            {
                return _campingEquipment;
            }
        }
        /// <summary>
        /// craeting property for mountaineering equipment
        /// </summary>
        public string MountaineeringEquipment
        {
            set
            {
                _mountaineeringEquipment = value;

            }
            get
            {
                return _mountaineeringEquipment;
            }
        }
        /// <summary>
        /// creating property for outdoor protection
        /// </summary>
        public string OutdoorProtection
        {
            set
            {
                _outdoorProtection = value;

            }
            get
            {
                return _outdoorProtection;
            }
        }
    }
 }












