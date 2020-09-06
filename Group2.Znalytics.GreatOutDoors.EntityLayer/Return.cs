// Created by K.Prasanna
using System;
/// <summary></summary>
/// This is Return Module
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{/// <summary>
/// 
/// </summary>
    public class Return
    {
        //private fields of Return
        private string _productID;
        private string _productName;
        private DateTime _productdate;
        private int _productQuantity;
        private string _producttype;
        private DateTime _exchangedate;


        ///<param name = "productID" > Represents ID of the Product</param>
        /// <param name="productname">Represents name of the Product</param>
        /// <param name="productdate">Represents on which date the product has been purchased</param>
        /// <param name="productQuantity">Represents the amount or number of a product is purchased</param>
        /// <param name="producttype">Represents the type of product</param>
        /// <param name="exchangedate">Represents on which date the product is exchanged</param>

        ///Property for ProductID details
        public string ProductID
        {
            set
            {
                try
                {

                    if ((value.StartsWith("IN")))//Name must start with IN
                    {
                        _productID = value;
                    }
                    else
                    {
                        throw new ReturnException("Entered name is not valid please start with IN");
                    }
                }
                catch
                {
                    throw;
                }

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
        /// Property for Productdate
        /// </summary>
        public DateTime Productdate
        {


            set
            {
                _productdate = value.AddDays(30);//Productdate will be added by 30 days to check exchange condition
            }
            get
            {
                return _productdate;
            }
        }
        /// <summary>
        ///Property for Product Quantity
        /// </summary>

        public int ProductQuantity
        {
            set
            {
                if (value < 20)//ProductQuantity should be less than 20 only
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
        ///Property for Product Type
        /// </summary>
        public string Producttype
        {
            set
            {
               
                    _producttype = value;
                
            }
            get
            {
                return _producttype;
            }
        }
        /// <summary>
        /// Property for Exchangedate
        /// </summary>

        public DateTime ExchangeDate

        {
            set
            {

                _exchangedate = value;
            }
            get
            {
                return _exchangedate;



            }
        }
    }
}