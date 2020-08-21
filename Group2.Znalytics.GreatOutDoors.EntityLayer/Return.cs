/// <summary>
/// Created by K.Prasanna
/// This is Return Module
/// </summary>
public class Return
{
    //private fields
    private string _productID;
    private string _productName;
    private string _productdate;
    private int _productQuantity;
    private string _producttype;
    private bool _accepted;
    ///Property for ProductID details
    public string ProductID
    {
        set
        {
            _productID = value;
        }
        get
        {
            return _productID;
        }
    }
    /// <summary>
    ///Property for  ProductName
    /// </summary>
    public string ProductName
    {
        set
        {

            _productName = value;

        }
        get
        {
            return _productName;
        }
    }
    /// <summary>
    /// Productdate
    /// </summary>
    public string Productdate
    {
        set
        {
            _productdate = value;
        }
        get
        {
            return _productdate;
        }
    }
    /// <summary>
    /// Product Quantity
    /// </summary>

    public int ProductQuantity
    {
        set
        {
            if (value < 20)
            {
                _productQuantity = value;
            }
        }
        get
        {
            return _productQuantity;
        }
    }
    /// <summary>
    /// Product Type
    /// </summary>
    public string Producttype
    {
        set
        {
            if (value.Length <= 30)
            {
                _producttype = value;
            }
        }
        get
        {
            return _producttype;
        }
    }
    public bool Accepted
    {
        set
        {
            if (Accepted == true)
            {
                _accepted = value;
            }
        }
        get
        {
            return _accepted;
        }
    }

}
