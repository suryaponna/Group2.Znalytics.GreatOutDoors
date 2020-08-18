/// <summary>
/// Address Entity Class 
/// </summary>

namespace Znalytics.Group2.GreatOutDoor.Entity {
    public class AddressDetail
    {
        private string _customerCountry;
        private string _customerFullName;
        private long _mobileNumber;
        private long _pinCode;
        private string _flatDno;
        private string _areaColony;
        private string _landMark;
        private string _townCity;
        private string _selState;
        public enum _addressType { 
            Home,Office
        }
        

        /// <summary>
        /// PRoperty for CustomerCountry
        /// </summary>
        public string CustomerCountry
        {
            set
            {
                this._customerCountry = value;
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
                this._customerFullName=value;
            }
            get
            {
                return this._customerFullName;
            }
        }
        /// <summary>
        /// Property for MobileNumber
        /// </summary>

        public long MobileNumber
        {
            set
            {
                this._mobileNumber = value;
            }
            get
            {
                return this._mobileNumber;
            }
        }
        /// <summary>
        /// Property for PinCode
        /// </summary>

        public long PinCode
        {
            set
            {
                this._pinCode = value;
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
                this._flatDno = value;
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
                this._areaColony = value;
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
                this._landMark = value;
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
                this._townCity = value;
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
                this._selState = value;
            }
            get
            {
                return this._selState;
            }
        }
        /// <summary>
        /// Property for AddressType
        /// </summary>

        

    }
}