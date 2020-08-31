//---------Archana

//Importing Statements
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.DataAccessLayer;
using Group2.Znalytics.GreatOutDoors.IBusinessLogicLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer;


//Created a namespace for businesslogic layer of Retail store
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    /// <summary>
    /// Represents Businesslogic class of Retail store and Implementing an interface
    /// </summary>
    public class RetailStoreBusinessLogicLayer : IRetailStoreBusinessLogicLayer
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
       //private RetailStoreDataAccessLayer _retailStoreDataAccessLayer;

        public RetailStoreBusinessLogicLayer()
        {
            //_retailStoreDataAccessLayer = new RetailStoreDataAccessLayer();
        }


        /// <summary>
        /// Method to add retail store details
        /// </summary>
        /// <param name="r">represents the retail store object</param>
        public void AddRetailstore(Retailstore r)
        {
            try
            {
                //Retail customer id not be null
                if (r.RetailCustomerID != null)
                {
                    //RetailStoreDataAccessLayer.AddRetailStore(r);

                }
            }
            catch (RetailstoreException ex)
            {
                throw new RetailstoreException(ex.Message);

            }
        }
        /// <summary>
        /// Method to get the added details
        /// </summary>
        public List<Retailstore> GetRetailstores()
        {
            return RetailStoreDataAccessLayer.GetRetailstores();
        }
        /// <summary>
        /// Method to Get retail store details by retail store id
        /// </summary>
        /// <param name="retailCustomerID">Reprsensts retail customerid</param>
        /// <returns>Returns the customerID</returns>
        public Retailstore GetRetailstoreByRetailstoreCustomerID(string retailCustomerID)
        {
            try
            {
                //Retail store Id should not be null

                if (retailCustomerID != null)
                {
                    return RetailStoreDataAccessLayer.GetRetailstoreByRetailstoreCustomerID(retailCustomerID);

                }
                else
                {
                    return null;

                }
            }
            catch (RetailstoreException ex)
            {
                throw new RetailstoreException(ex.Message);
            }
        }

        public Retailstore GetRetailstoreByRetailstoreID(string rcID)
        {
            throw new RetailstoreException();
        }
        public void RemoveRetailCustomerByID(string retailCustomerID)
        {
            try
            {
                if (retailCustomerID != null)
                {
                    RetailStoreDataAccessLayer.RemoveRetailCustomerByID(retailCustomerID);
                }
            }
            catch (RetailstoreException ex)
            {
                throw new RetailstoreException(ex.Message);
            }
        }
        /// <summary>
        /// Remove the details based on customer name
        /// </summary>
        /// <param name="retailCustomerName">represents the customer name</param>
        public void RemoveRetailstoreByCustomerName(string retailCustomerName)
        {
            try
            {
                if (retailCustomerName != null)
                {
                    RetailStoreDataAccessLayer.RemoveRetailstoreByCustomerName(retailCustomerName);
                }
            }
            catch (RetailstoreException ex)
            {
                throw new RetailstoreException(ex.Message);
            }
        }
        /// <summary>
        /// method to Update the customername
        /// </summary>
        /// <param name="retailstore">represents retailstore object</param>
        public void UpdateRetailstoreCustomerName(Retailstore retailstore)
        {
            try
            {
                if (retailstore.RetailCustomerID != null)
                {
                    RetailStoreDataAccessLayer.UpdateRetailstoreCustomerName(retailstore);
                }
            }
            catch (RetailstoreException ex)
            {
                throw new RetailstoreException(ex.Message);
            }
        }
        /** public bool CheckRetailCustomerID(string id)
         {
             return RetailStoreDataAccessLayer.CheckRetailCustomerID(id);
         }*/


    }

}

