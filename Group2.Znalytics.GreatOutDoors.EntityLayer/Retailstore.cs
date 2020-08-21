//---------Archana
using System;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
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
        /// Auto implemented Property
        /// </summary>
        public Retailstore()
        {
        }

        /// <summary>
        /// Constructor that initializes details of RetailStore
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

/**
 * private RetailStoreDataLayer _retailDataAccessLogic;
         public RetailStoreBusinessLogicLayer()
         {
             _retailDataAccessLogic = new RetailStoreDataLayer();
         }

         
         public void AddRetailstore(Retailstore rsid)
         {

             if (rsid != null)
             {
                 _retailDataAccessLogic.AddRetailstore(rsid);

             }
             else
             {
                 throw new Exception("Retail store ID can't be null");
             }
         }
         //Get RetailStoreID
        public List<Retailstore> GetRetailStoreID()
         {
             return _retailDataAccessLogic.GetRetailstore();
         }*/



