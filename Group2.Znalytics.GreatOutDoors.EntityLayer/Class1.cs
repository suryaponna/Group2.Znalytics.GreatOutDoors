/// <summary>
/// This is Returns Module
/// </summary>
public class ReturnsModule
{
    private string _productID;
    private string _productName;
    private string _productdate;
    private int _productQuantity;
    private string _producttype;
    ///ProductID details
    public string ProductID
    {
        //productid can accept both integers and strings
        set
        {
            int ID;
            bool b;
            string pid = " ";
            b = int.TryParse(pid, out ID);
            if (b == true)
            {
                System.Console.WriteLine();
            }

            _productID = value;
        }
        get
        {
            return _productID;
        }
    }
    /// <summary>
    /// ProductName
    /// </summary>
    public string ProductName { set; get; }
    /// <summary>
    /// Productdate
    /// </summary>
    public string Productdate
    {
        //can accept integers and strings
        set
        {
            int ID;
            bool b;
            string pid = " ";
            b = int.TryParse(pid, out ID);
            if (b == true)
            {
                System.Console.WriteLine();
                // value = ID;
            }
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

    public int ProductQuantity { set; get; }
    /// <summary>
    /// Product Type
    /// </summary>
    public string Producttype { set; get; }

}
