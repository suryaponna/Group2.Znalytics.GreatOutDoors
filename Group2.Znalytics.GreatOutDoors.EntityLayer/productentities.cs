namespace Znalytics.Inventory.Product.Entities
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

public class UserLogin
{
    private string _id;
    private string _password;
    private string _firstName;
    private string _lastName;
    private long _number;

    public void SetId(string Id)
    {
        this._id = Id;
    }
    public string GetId()
    {
        return this._id;
    }
    public void SetPassword(string Password)
    {
        this._password = Password;
    }
    public string GetPassword()
    {
        return this._password;
    }

    public void SetFirstName(string Firstname)
    {
        this._firstName = Firstname;
    }
    public string GetFirstName()
    {
        return this._firstName;
    }


    public void SetLastName(string lastname)
    {
        this._lastName = lastname;
    }
    public string GetLastName()
    {
        return this._lastName;
    }

    public void SetNumber(long number)
    {
        this._number = number;
    }
    public long GetNumber()
    {
        return this._number;
    }
}




