///// Apoorva///////
//Customer Entity Layer


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;//directory involved for using regularexpressions in the code


namespace Group2.Znalytics.GreatOutDoors.EntityLayer//namespace is nothing but collection of classes
{
    public class Customer
    {
        //private fields of customer
        private string _customerName;
        private int _customerId;
        private string _customerMailId;
        private string _customerPhoneNumber;
        private double _customerFlatNumber;
        private string _customerCity;
        private string _customerStreet;
        private string _customerState;
        private string _customerPinCode;
        private string _customerCountry;
        private string _password;
        private string _gender;
        private int _customerAge;
        private string _aadharCardNumber;
        private string _pinCode;



        /// <summary>
        /// Id of the Customer based on which customer can login
        /// </summary>
        public int CustomerId
        {
            set
            {
                if (value >= 0 && value <= 9)
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

        /// <summary>
        /// Password of the Customer based on which the customer can login
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
        /// Name of the Customer based on which customer can signin
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
        /// Mailid of the customer based on which customer can signup
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
        /// Aadhar CardNumber of the  Customer based on customer can signin
        /// </summary>
        public string AadharCardNumber
        {
            set
            {
                if (value.Length == 12)
                {
                    _aadharCardNumber = value;
                }
            }
            get
            {
                return _aadharCardNumber;

            }
        }


        /// <summary>
        /// FlatNumber of the Customer.It represents default flat number(address) of the customer
        /// </summary>
        public double CustomerFlatNumber
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

        public void AddCustomer(Customer customer)
        {
            throw new Exception();
        }


        /// <summary>
        /// City of the Customer
        /// </summary>
        public string CustomerCity
        {
            set
            {
                if (value.Length == 12)
                {
                    _customerCity = value;
                }
            }
            get
            {
                return _customerCity;
            }
        }

        public List<Customer> ViewCustomer()
        {
            throw new NotImplementedException();
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
                if (value.Length <= 12)
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
        public string CustomerPhoneNumber
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

        public static void UpdateCustomer(Customer customers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// property of gender
        /// </summary>
        public string Gender
        {
            set
            {
                if (value == "Male" || value == "Female" || value == "Others")
                {
                    _gender = value;
                }
            }
            get
            {
                return _gender;
            }
        }

        ///<summary>
        ///Property for Customer Age
        ///</summary>
        public int CustomerAge
        {
            set
            {
                _customerAge = value;
            }
            get
            {
                return _customerAge;
            }
        }


    }
}