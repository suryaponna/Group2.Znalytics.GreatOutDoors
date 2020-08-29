//---------Archana
using System;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    /// <summary>
    /// This class Represents Entity Layer for RetailStore
    /// </summary>
    public class Retailstore
    {
        //Private field
        private string _retailStoreID;
        private string _customerName;
        private string _reports;
        private string _retailProducts;
        private double _cost;
        private int _quantityofProducts;
        private string _suppliers;
        private string _damagedProducts;

        /// <summary>
        /// Auto implemented Property for restailstore
        /// </summary>
        public Retailstore()
        {
        }
        /// <summary>
        /// Constructor that initializes details of RetailStore
        /// </summary>
        /// <param name="RetailStoreID">Represents Retail store identity using an ID</param>
        /// <param name="Reports">Represents the payment of reports</param>
        /// <param name="RetailProducts">Represents retail products</param>
        /// <param name="Suppliers">Represents the suppliers for transport</param>
        /// <param name="DamagedProducts">Represensts about damaged products</param>


        public Retailstore(string RetailStoreID, string CustomerName, string Reports, string RetailProducts, int QuantityOfProducts, double Cost, string Suppliers, string DamagedProducts)
        {
            _retailStoreID = RetailStoreID;
            _customerName = CustomerName;
            _reports = Reports;
            _reports = RetailProducts;
            _cost = Cost;
            _suppliers = Suppliers;
            _damagedProducts = DamagedProducts;
        }
        /// <summary>
        /// RetailStoreID for customer
        /// </summary>
        public string RetailStoreID
        {
            set
            {
                try
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!spaceFound && !atFound && !commaFound && value.Length <= 10)
                    {
                        _retailStoreID = value;
                    }
                }
                catch
                {
                    throw new RetailstoreException("Enter valid Retail Store ID");
                }

            }
            get
            {
                return _retailStoreID;
            }
        }
        public string CustomerName
        {
            set
            {
                try
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    if (!atFound && !commaFound && value.Length <= 30)
                    {
                        _customerName = value;
                    }

                }
                catch
                {
                    throw new RetailstoreException("customer name is invalid");
                }
            }
            get
            {

                return _customerName;
            }
        }


        /// <summary>
        /// Reports represents that we have to  choose the payment reports
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
        /// QuantityofProducts measn we have to add how much products we want
        /// </summary>
        public int QuantityOfProducts
        {
            set
            {
                _quantityofProducts = value;
            }
            get
            {
                return _quantityofProducts;
            }
        }
        /// <summary>
        /// Cost of the products
        /// </summary>
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
        /// Damaged Products
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
}