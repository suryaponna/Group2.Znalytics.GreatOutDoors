
using System;
namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    /// <summary>
    /// This class Represents Entity Layer for RetailStore
    /// </summary>
    public class Retailstore
    {
        //Private field
        private int _retailStoreID;
        private string _reports;
        private string _retailProducts;
        private string _suppliers;
        private string _damagedProducts;
        /// <summary>
        /// Constructors that initializes details of RetailStore
        /// </summary>
        /// <param name="RetailStoreID">Represents Retail store identity using an ID</param>
        /// <param name="Reports">Represents the payment of reports</param>
        /// <param name="RetailProducts">Represents Retail products</param>
        /// <param name="Suppliers">Represents the suppliers for transport</param>
        /// <param name="DamagedProducts">Represensts about damaged products</param>
        public Retailstore(int RetailStoreID, string Reports, string RetailProducts, string Suppliers, string DamagedProducts)
        {
            _retailStoreID = RetailStoreID;
            _reports = Reports;
            _reports = RetailProducts;
            _suppliers = Suppliers;
            _damagedProducts = DamagedProducts;
        }

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
}

