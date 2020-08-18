/// <summary>
/// RETAIL STORE MODULE
/// </summary>
public class Retailstore
{

    private int _retailStoreID;
    private string _reports;
    private string _retailProducts;
    private string _suppliers;
    private string _damagedProducts;

    /// <summary>
    /// RetailStoreID
    /// </summary>
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
    /// <summary>
    /// Reports
    /// </summary>
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
    /// <summary>
    /// RetailProducts
    /// </summary>
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
    /// <summary>
    /// Suppliers
    /// </summary>

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
    /// <summary>
    /// Outlier Products
    /// </summary>
    public string DamagedProducts
    {
        set
        {
            _damagedProducts = value;
        }
        get
        {
            return _damagedProducts;
        }
    }

}

