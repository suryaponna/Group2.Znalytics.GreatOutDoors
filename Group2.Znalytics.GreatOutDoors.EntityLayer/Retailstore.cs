//---------Archana
using System;
using System.Runtime.Remoting.Services;
using Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    /// <summary>
    /// This class Represents Entity Layer for RetailStore
    /// </summary>
    public class Retailstore
    {
        //Private field
        private string _retailCustomerID;
        private string _customerName;
        private string _reports;


        /// <summary>
        /// Auto implemented Property for restailstore
        /// </summary>
        public Retailstore()
        {
        }
        /// <summary>
        ///Parameterized Constructor that initializes details of RetailStore
        /// </summary>
        /// <param name="RetailerCustomerID">Represents Retail store identity using an ID</param>
        /// <param name="CustomerName">Reprsents Name of the customer</param>
        /// <param name="Reports">Represents the payment method of reports</param>

        public Retailstore(string RetailCustomerID, string CustomerName, string Reports)
        {
            this._retailCustomerID = RetailCustomerID;
            this._customerName = CustomerName;
            this._reports = Reports;

        }
        /// <summary>
        /// Property for customer
        /// </summary>
        public string RetailCustomerID
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    bool dotFound = value.Contains(".");
                    if (!spaceFound && !atFound && !commaFound && !dotFound && value.StartsWith("ZRS") && value.Length <= 10)
                    {
                        _retailCustomerID = value;
                    }
                    else
                    {
                        throw new RetailstoreException("Enter valid Product starts with ZRSPID Id should not contain spaces and length should be exactly 10");

                    }
                }
            }
            get
            {
                return _retailCustomerID;
            }
        }
        /// <summary>
        /// Property for Customer name
        /// </summary>
        public string CustomerName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    bool dotFound = value.Contains(".");
                    if (!spaceFound && !atFound && !commaFound && !dotFound && value.Length <= 25)
                    {
                        _customerName = value;
                    }
                }
                else
                {
                    throw new RetailstoreException("Customer name is invalid should not contain spaces and length should be 625");
                }
            }
            get
            {
                return _customerName;
            }
        }
        /// <summary>
        /// Property for Reports 
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

    }
}