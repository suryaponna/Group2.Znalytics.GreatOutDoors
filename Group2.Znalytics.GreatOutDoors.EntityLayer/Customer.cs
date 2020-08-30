///// Apoorva///////
//Customer Entity Layer


using System.Text.RegularExpressions;//directory involved for using regularexpressions in the code


namespace Group2.Znalytics.GreatOutDoor.EntityLayer//namespace is nothing but collection of classes

{
    public class Customer
    {


        /// <summary>
        /// Represents details of customer
        /// </summary>
        // list of details
        private string _customerName;
        private string _customerId;
        private string _customermailId;
        private string _customerPhoneNumber;
        private double _customerFlatNumber;
        private string _customerCity;
        private string _customerStreet;
        private string _customerState;
        private string _customerPinCode;
        private string _customerCountry;
        private string _password;
        private string _gender;
        private int _age;
        private string _aadharCardNumber;
        private string _pinCode;



        /// <summary>
        /// Property for Customer userId
        /// </summary>
        public string CustomerId
        {
            set
            {
                Regex r = new Regex(@"^[a-zA-Z\\d*]{8,20}$");//User ID cannot be all numeric
                                                            // User ID cannot have special characters
                                                            //Minimum length of 8 characters
                                                            //Maximum length of 20 characters
                                                            //Can be all alphabetic
                                                            //Can be alphanumeric
                if (r.IsMatch(value))
                {
                    _customerId = value;
                }
                else
                {
                    throw new System.Exception("Cannot contain special characters and cannot be all numeric");
                }
            }
            get
            {
                return _customerId;
            }
        }
    }
        /// <summary>
        /// Property for password
        /// </summary>
        public string Password
        {
            set
            {
                Regex r = new Regex(@"?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$");
                // password must be between 8 and 15 characters long. 
                //password must contain at least one number. 
                //password must contain at least one uppercase letter. 
                //password must contain at least one lowercase letter.
                if (r.IsMatch(value))
                {
                    _password = value;
                }
                else
                {
                    throw new System.Exception("It is invalid");
                }
            }
                get
                    {
                    return _password;
                }
            }
        



        /// <summary>
        /// Name of the Customer
        /// </summary>
        public string CustomerName
        {
            set
            {
                if (value.Length <= 30) // length of the customer name should contain lessthan or equal to 30 characters.
                {
                    _customerName = value;
                }
            }
            get
            {
                return _customerName;
            }
        }

        /// <summary>
        /// Mail Id of the Customer
        /// </summary>
        public string CustomerMailId
        {
            set
            {
                _customerMailId = value;
            }
            get
            {
                return _customerMailId;
            }
        }
        /// <summary>
        /// FlatNumber of the Customer
        /// </summary>
        public int CustomerFlatNumber
        {
            set
            {
                _customerFlatNumber = value;
            }
            get
            {
                return _customerFlatNumber;
            }
        }
        /// <summary>
        /// Street of the Customer
        /// </summary>

        public string CustomerStreet
        {
            set
            {
                _customerStreet = value;
            }
            get
            {
                return _customerStreet;
            }
        }

        /// <summary>
        /// City of the Customer
        /// </summary>
        public string CustomerCity
        {
            set
            {
                if (value.Length = 12)
                {
                    _customerCity = value;
                }
            }
            get
            {
                return _customerCity;
            }
        }

        /// <summary>
        /// State of the Customer
        /// </summary>
        public string CustomerState
        {
            set
            {
                _customerState = value;
            }
            get
            {
                return _customerState;
            }
        }

        /// <summary>
        /// PinCode of Customer
        /// </summary>
        public string PinCode
        {
            set
            {

                if (value.Length == 6)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (value[i] > 0 || value[i] < 9)
                        {
                            _pinCode = value;
                        }
                    }
                }
            }
            get
            {
                return _pinCode;
            }
        }

        /// <summary>
        /// City of the Country
        /// </summary>
        public string CustomerCountry
        {
            set
            {
                if (value.Length == 12)
                {
                    _customerCountry = value;
                }
            }
            get
            {
                return _customerCountry;
            }
        }
        /// <summary>
        /// Phone number of the Customer
        /// </summary>
        public long CustomerPhoneNumber
        {
            set
            {
                if (value.Length == 10)
                {
                    _customerPhoneNumber = value;
                }
            }
            get
            {
                return _customerPhoneNumber;
            }
        }
        /// <summary>
        /// property of gender
        /// </summary>
        public string Gender
    {
        set
        {
            if (value == Male || value == Female)
            {
                _gender = value;
            }
        }
        get
        {
            return _gender;
        }
    }


 }




