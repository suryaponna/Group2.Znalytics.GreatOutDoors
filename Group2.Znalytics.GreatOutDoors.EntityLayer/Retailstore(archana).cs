public class Retailstore
{
    private int _retailStoreID;
    private string _reports;
    private string _retailProducts;
    private string _outlierProducts;
    private string _suppliers;
    private double _cost;
    private string _trackingTime;


    public int RetailStoreID
    {
        set
        {
            _retailStoreID = value;

        }
        get
        {
            return _retailStoreID;
        }
    }
    public string Reports
    {
        set
        {
            _reports = value;
        }
        get
        {
            return _reports;
        }
    }
    public string RetailProducts
    {
        set
        {
            _retailProducts = value;
        }

        get
        {
            return _retailProducts;
        }
    }
    public string OutliersProducts
    {
        set
        {
            _outlierProducts = value;
        }
        get
        {
            return _outlierProducts;
        }
    }
    public string Suppliers
    {
        set
        {
            _suppliers = value;
        }
        get
        {
            return _suppliers;
        }
    }
    public double Cost

    {
        set
        {
            _cost = value;
        }
        get
        {
            return _cost;
        }
    }
    public string Trackingtime
    {
        set
        {
            _trackingTime = value;
        }
        get
        {
            return _trackingTime;
        }
    }
}

