﻿/// <summary>
/// This is Returns Module
/// </summary>
public class ReturnsModule
{
    //private fields
    private string _productID;
    private string _productName;
    private string _productdate;
    private int _productQuantity;
    private string _producttype;
    ///ProductID details
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
    /// ProductName
    /// </summary>
    public string ProductName
    {
        set
        {
            if (value.Length <= 30)
            {
                _productName = value;
            }
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
}