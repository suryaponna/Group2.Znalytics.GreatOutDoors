//---------Archana

using System;
using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.DataLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;


/// <summary>
/// Business Logic for RetailStore
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public class RetailStoreBusinessLogicLayer : IRetailStoreBusinessLogicLayer
    {

       private RetailStoreDataLayer _rdl;
         public RetailStoreBusinessLogicLayer()
         {
             _rdl = new RetailStoreDataLayer();
         }

         //Method to add retail store id list
         public void AddRetailStoreID(Retailstore rsid)
         {
            //Retail store can't be null
             if (rsid.RetailStoreID != null)
             {
                 _rdl.AddRetailStoreID(rsid);

             }
             else
             {
                 throw new Exception("Retail store ID can't be null");
             }
         }

       public Retailstore GetRetailstoreByRetailStoreID(int RetailStoreID)
        {
            throw new NotImplementedException();
        }

        public List<Retailstore> GetRetailStoreID()
        {
            throw new NotImplementedException();
        }

        //Get RetailStoreID
        public List<Retailstore> GetRetailStoreIDs()
         {
             return _rdl.GetRetailStoreIDs();
         }

        public class RetailStoreID
        {
        }

        /** RetailStoreDataLayer d = new RetailStoreDataLayer();
public void AddRetailStoreID(Retailstore rsid)
{
    if(rsid.RetailStoreID!=null)
    {
        d.AddRetailStoreID(rsid);
    }
}
public List<RetailStoreID>GetRetailStoreIDs()
{
    return d.AddGetRetailStoreIDs();
}*/

    }

}
