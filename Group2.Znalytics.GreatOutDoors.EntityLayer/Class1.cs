using System.Runtime.CompilerServices;
using System.Windows.Markup;
/// <summary>
/// Shippinng Address Details
/// </summary>
public class AddressDetails
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
    private string _addressType;
    private bool _changeAddress = false;

    public string CustomerCountry
    {
        set
        {
            _customerCountry = value;
        }
        get
        {
            return _customerCountry;
        }
    }
    public string CustomerName
    {
        set
        {
            value = _customerFullName;
        }
        get
        {
            return this._customerFullName;
        }
    }
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
    }
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
    public string AddressType
    {
        set
        {
            this._addressType = value;
        }
        get
        {
            return this._addressType;
        }
    }

}