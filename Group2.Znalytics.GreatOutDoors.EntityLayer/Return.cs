// Created by K.Prasanna
using System;
/// <summary></summary>
/// This is Return Module
/// </summary>
namespace Group2.Znalytics.GreetOutDoors.EntityLayer
{
    public class Return
    {
        //private fields
        private int _productID;
        private string _productName;
        private DateTime _productdate;
        private int _productQuantity;
        private string _producttype;
        private DateTime _exchangedate;

        ///Property for ProductID details
        public int ProductID
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
        public DateTime Productdate
        {
             
        set; get;
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

        public DateTime ExchangeDate

        {
            set
            {
                //get the eligible date (present date - 18 years)
                DateTime exchangeDate = DateTime.Now;
                exchangeDate = exchangeDate.AddDays(-30);

                if (value < exchangeDate)
                {
                    _exchangedate = value;
                }
                else
                {
                    throw new Exception(nameof(ExchangeDate) + " should be less than " + Productdate.ToString("dd/M/yyyy"));
                }
            }
            get
            {
                return _exchangedate;



            }
        }
    }
}

