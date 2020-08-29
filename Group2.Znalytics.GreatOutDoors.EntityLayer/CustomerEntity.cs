///// Apoorva///////
//Customer Entity Layer
using System;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
namespace Znalytics.Group2.GreatOutDoor.Entity
{ 
public class CostumerDetail
{
    /// <summary>
    /// fields for signup process
    /// </summary>
    private string _id;
    private string _firstName;
    private string _lastName;
    private string _dateOfBirth;
    private int _age;
    private string _gender;
    private long _aadharCard;
    private string _password;
    private string _confirmPassword;
    
    /// <summary>
    /// fields for signin process
    /// </summary>
        private string _userId;
        private string password;

    public void SetId(String Id)
    {
        this._id = id;
    }
    public string GetId()
    {
        return this._id;
    }
    public void setPassword(string Password)
    {
        this._password = Password;
    }
    public string GetPassword()
    {
        return this._password;
    }
    public void SetFirstName(string FirstName)
    {
        this._firstName = FirstName;
    }
    public string GetFirstName()
    {
        return this._firstName;
    }
    public void SetLastName(string LastName)
    {
        this._lastName = lastName;
    }
    public void SetAge(int Age)
    {
        this._age = Age;
    }
    public void SetGender(string Gender)
    {
        this._gender = Gender;
    }
    public void SetAadharCard(long AadharCard)
    {
        this._aadharcard = AadharCard;
    }
    public void SetPassword(double Password)
    {
        this._password = Password;
    }
    public void SetConfirmPassword(double ConfirmPassword)
    {
        this._confirmpassword = ConfirmPassword;
    }
/// <summary>
/// Represents details of customer
/// </summary>
        // list of details
        private string _customerName;
        private string _customerId;
        private string _customermailId;
        private string _customerPhoneNumber;
        private double _customerFlatNumber;
        private long _customerCity;
        private string _customerStreet;
        private string _customerState;
        private DateTime _customerPinCode;
        private string _customerCountry;

        CustomerDetail customer = new CustomerDetail();
        // Creating constructor
        public CustomerDetail() { }


        /// <summary>
        /// Creating Constructor(which is used to initialize fields)
        /// </summary>
        /// <param name="CustomerName">Name of the customer</param>
        /// <param name="CustomerId">Customer Id</param>
        /// <param name="CustomerMailId">MailId of customer</param>
        /// <param name="CustomerPhoneNumber">PhoneNumber of customer</param>
        /// <param name="CustomerFlatNumber">FlatNumber of customer</param>
        /// <param name="CustomerCity">City of customer</param>
        /// <param name="CustomerStreet">Street of customer</param>
        /// <param name="CustomerState">State of customer</param>
        /// <param name="CustomerPinCode">Pincode of the customer</param>
        /// <param name="CustomerCountry">Country of the customer</param>
        CustomerDetail(string CustomerName, string CustomerId, string CustomerMailId, int CustomerPhoneNumber, int CustomerFlatNumber, string CustomerCity, string CustomerStreet, string CustomerState, int CustomerPinCode, string CustomerCountry)
        {
            _customerName = CustomerName;
            _customerId = CustomerId;
            _customerMailId = CustomerMailId;
            _customerPhoneNumber = CustomerPhoneNumber;
            _customerFlatNumber = CustomerFlatNumber;
            _customerCity = CustomerCity;
            _customerStreet = CustomerStreet;
            _customerState = CustomerState;
            _customerPinCode = CustomerPinCode;
            _customerCountry = CustomerCountry;
        }

        /// <summary>
        /// Name of the Customer
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
            get
            {
                return _customerName;
            }
        }

        /// <summary>
        /// Id of the Customer
        /// </summary>
        public string CustomerId
        {
            set
            {
                if (value >= 0 && value <= 9)
                {
                    _customerId = value;
                }

            }
            get
            {
                return _customerId;
            }
        }
        /// <summary>
        /// Mail Id of the Customer
        /// </summary>
        public string MailId
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
        public long CustomerCity
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
                _address = value;
            }
            get
            {
                return _address;
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
                            _CustomerPinNumber = value;
                        }
                    }
                }
            }
            get
            {
              return _customerPinCode;
            }
            }

        /// <summary>
        /// City of the Country
        /// </summary>
        public long CustomerCountry
        {
            set
            {
                if (value.Length = 12)
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
                if (value.Length = 10)
                {
                    _customerPhoneNumber = value;
                }
            }
            get
            {
                return _customerPhoneNumber;
            }
        }




    }

}



