//---------Archana
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer;
using Group2.Znalytics.GreatOutDoors.RetailProducts.EntityLayer;
using System.IO;
using Newtonsoft.Json;


/// <summary>
/// Created a namespace for Data Acess layer of Retailstore module
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.DataAccessLayer
{
    /// <summary>
    /// Represents the class for Retail store Data
    /// </summary>
    public class RetailStoreDataAccessLayer
    {
        /// <summary>
        /// Create a list of RetailStore
        /// </summary>
        private static List<Retailstore> _retailStoreList
        {
            set;
            get;
        }
        /// <summary>
        /// Static Constructor
        /// </summary>
        static RetailStoreDataAccessLayer()
        {
            _retailStoreList = new List<Retailstore>();
            {
                //Mock data
                new Retailstore() { RetailCustomerID = "ZRS12345", CustomerName = "Archana", Reports = "Monthly Reports" };
                new Retailstore() { RetailCustomerID = "ZRS23456", CustomerName = "Surya", Reports = " Quaterly Reports" };
                new Retailstore() { RetailCustomerID = "ZRS34567", CustomerName = "Meghana", Reports = "Yearly Reports" };

            };
            if (_retailStoreList.Count == 0)
            {
                _retailStoreList = GetFileData();
            }
        }
        /// <summary>
        /// Method to add retailstore details to the list
        /// </summary>
        /// <param name="retailstoreDetails">represents the details of retailstore eg</param>
        public static void AddRetailStore(Retailstore retailstoreDetails)
        {
            //condtion for checking wheather the retailstore id exists or not
            if (retailstoreDetails.RetailCustomerID != null)
            {
                _retailStoreList.Add(retailstoreDetails);
                SaveIntoFile();
            }
            else
            {
                throw new RetailstoreException("Already exists");
            }
        }
        /// <summary>
        /// Here we are saving the data into Json file        
        /// </summary>
        private static void SaveIntoFile()
        {
            string s = JsonConvert.SerializeObject(_retailStoreList);
            //write the data into the file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\source\repos\RetailStoreData");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// Reading the data from json file and return data in the file in the form List format
        /// </summary>
        /// <returns>returns list of details present in Retailstoredata </returns>
        public static List<Retailstore> GetFileData()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\source\repos\RetailStoreData");
            string s1 = streamReader.ReadToEnd();
            List<Retailstore> rs = JsonConvert.DeserializeObject<List<Retailstore>>(s1);
            streamReader.Close();
            return rs;
        }
        /// <summary>
        /// Method to get the added details
        /// </summary>
        /// <returns>returns the list of retailstores</returns>
        public static List<Retailstore> GetRetailstores()
        {
            return _retailStoreList;
        }
        /// <summary>
        /// Method to get the retailstore by retail customer id
        /// </summary>
        /// <param name="retailCustomerID">it represents the customer of id</param>
        /// <returns>returns the list of customerid</returns>
        public static Retailstore GetRetailstoreByRetailstoreCustomerID(string retailCustomerID)
        {
            //Condition to check wheather the id exists or not
            if (_retailStoreList.Exists(r => r.RetailCustomerID == retailCustomerID))
            {
                return _retailStoreList.Find(r => r.RetailCustomerID == retailCustomerID);
                //SaveIntoFile();
            }
            else
            {
                throw new RetailstoreException("Details are not exists");

            }


        }

        /// <summary>
        /// Method to remmove retail by customerid
        /// </summary>
        /// <param name="retailCustomerID">Represents Customerid</param>
        public static void RemoveRetailCustomerByID(string retailCustomerID)
        {
            if (_retailStoreList.Exists(r => r.RetailCustomerID == retailCustomerID))
            {
                _retailStoreList.RemoveAll(r => r.RetailCustomerID == retailCustomerID);
            }
            else
            {
                throw new RetailstoreException("Retail Doesn't exists");
            }
        }
        /// <summary>
        /// Method to remove retailstore by customer name
        /// </summary>
        /// <param name="customerName"></param>
        public static void RemoveRetailstoreByCustomerName(string customerName)
        {
            //check weather name exist or not
            if (_retailStoreList.Exists(r => r.CustomerName == customerName))
            {
                _retailStoreList.RemoveAll(r => r.CustomerName == customerName);
            }
            else
            {
                throw new RetailstoreException("retail store doesn't exist");
            }
        }
        /// <summary>
        /// Method to update the customername
        /// </summary>
        /// <param name="retailstore">Reprsents the retailstore object</param>
        public static void UpdateRetailstoreCustomerName(Retailstore retailstore)
        {
            if (_retailStoreList.Exists(r => r.RetailCustomerID == retailstore.RetailCustomerID))
            {
                Retailstore u = _retailStoreList.Find(r => r.RetailCustomerID == retailstore.RetailCustomerID);
                if (u != null)
                {
                    u.CustomerName = retailstore.CustomerName;
                    SaveIntoFile();
                }
            }
            else
            {
                throw new RetailstoreException("Retailstore doesn't exist");
            }
        }/// <summary>
        /// Method to check customerid exists or not
        /// </summary>
        /// <param name="id">reprsensts customerid</param>
        public static bool CheckRetailCustomerID(string id)
        {
            bool res = _retailStoreList.Exists(temp => temp.RetailCustomerID == id);
            return res;
        }
    }
}
