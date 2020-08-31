//----------------------------------------------Surya------------------------------------
using System;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
namespace Znalytics.Group2.GreatOutDoor.Entity
{
    /// <summary>
    /// Represents an address of Customer
    /// </summary>
    [Serializable]
    public class AddressDetail:IEquatable<AddressDetail>, IComparable<AddressDetail>
    {
        private int _addressId ;
        private string _customerCountry;
        private string _customerFullName;
        private string _mobileNumber;
        private string _pinCode;
        private string _flatDno;
        private string _areaColony;
        private string _landMark;
        private string _townCity;
        private string _selState;
        private int _customerId=524;
        private bool _defaultAddress;
        private AddressType _addressType;
        /// <summary>
        /// IEquatable method for comparing two customer are same or not
        /// </summary>
        /// <param name="other">Addresdetail Object</param>
        /// <returns></returns>
        public bool Equals(AddressDetail other) {
            if (this._customerId == other._customerId)
            {
                return true;
            }
            else {
                return false;
            }
        }
        /// <summary>
        /// IComparable method for comparing two adddress are equal or not
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(AddressDetail other) {
            int compare;
            compare = this._addressType.CompareTo(other._addressType);
            if (compare == 0) { 
                
            }
            if (compare == 0) {
                compare = this._customerFullName.CompareTo(other._customerFullName);
            }
            if (compare == 0) {
                compare = this._selState.CompareTo(other._selState);
            }
            if (compare == 0) {
                compare = this._townCity.CompareTo(other._townCity);
            }
            //else { return compare; }
            return compare;
        }
            

        public int CustomerId {
            set => _customerId = value;
            get => _customerId;
        }
        /// <summary>
        /// PRoperty for CustomerCountry
        /// </summary>
        public string CustomerCountry
        {
            set
            {
                if (value.Length < 13)
                    _customerCountry = value;
                else
                    throw new AddressException("Entered Country Name is not in Range");
            }
            get
            {
                return _customerCountry;
            }
        }
        /// <summary>
        /// Property for CustomerName
        /// </summary>

        public string CustomerName
        {
            set
            {
                if (value.Length < 15)
                    _customerFullName = value;
                else
                    throw new AddressException("Your name exceeded the size tha maximum characters are 14");

            }
            get
            {
                return this._customerFullName;
            }
        }
        /// <summary>
        /// Property for MobileNumber
        /// </summary>

        public string MobileNumber
        {
            set
            {
                if (value.Length==14 &&string.IsNullOrEmpty(value))
                    this._mobileNumber = value;
                else
                    throw new AddressException("Enter valid Phone number with country w=starts with + and space 10 digits ");
            }
            get
            {
                return this._mobileNumber;
            }
        }
        /// <summary>
        /// Property for PinCode
        /// </summary>

        public string PinCode
        {
            set
            {
                if (value.Length <= 6)
                    this._pinCode = value;
                else
                    throw new AddressException("Enteres PinCode was not Valid");
            }
            get
            {
                return this._pinCode;
            }
        }
        /// <summary>
        /// Property for FlatNumber
        /// </summary>

        public string FlatNo
        {
            set
            {
                if (value.Length < 15)
                    this._flatDno = value;
                else
                    throw new AddressException("Enter Your FlatNumber Or Door Number length was exceeded the size of 15");
            }
            get
            {
                return this._flatDno;
            }
        }/// <summary>
         /// Property for Area and Colony
         /// </summary>

        public string AreaColony
        {
            set
            {
                if (value.Length < 15)
                    this._areaColony = value;
                else
                    throw new AddressException("Entered Area was not in range exceeded tha maximum character of 15");
            }
            get
            {
                return this._areaColony;
            }
        }
        /// <summary>
        /// Property for Land Mark of the address
        /// </summary>

        public string LandMark
        {
            set
            {
                if (value.Length < 20)
                    this._landMark = value;
                else
                    throw new AddressException("Enter your Land Mark with in the range 20");
            }
            get
            {
                return this._landMark;
            }
        }
        /// <summary>
        /// Property for Town
        /// </summary>


        public string Town
        {
            set
            {
                if (value.Length < 15)
                    this._townCity = value;
                else
                    throw new AddressException("Entere Valid Town of Size maximum is 15");
            }
            get
            {
                return this._townCity;
            }
        }
        /// <summary>
        /// Property for State
        /// </summary>

        public string State
        {
            set
            {
                if (value.Length < 15)
                    this._selState = value;
                else
                    throw new AddressException("Enter State with in the Range");
            }
            get
            {
                return this._selState;
            }
        }
        
        /// <summary>
        /// Setting AddressType Of Customer
        /// </summary>
        public AddressType AddressId {
            get {
                return _addressType;
            }
            set {
                if ((int)value == 1)
                {
                    _addressType = AddressType.Home;
                }
                else {
                    _addressType = AddressType.Office;
                }
            }
        }
        public bool DefaultAddressOrNot {
            set {
                string s = System.Convert.ToString(value);
                if (string.IsNullOrEmpty(s)) {
                    _defaultAddress = System.Convert.ToBoolean(s);
                }
            }
            get {
                return _defaultAddress;
            }
        }

    }
}