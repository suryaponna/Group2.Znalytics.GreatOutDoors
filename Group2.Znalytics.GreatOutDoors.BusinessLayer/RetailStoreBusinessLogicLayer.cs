//---------Archana

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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

         
         public void AddRetailStoreID(Retailstore rsid)
         {

             if (rsid.RetailStoreID != null)
             {
                 _rdl.AddRetailStoreID(rsid);

             }
             else
             {
                 throw new Exception("Retail store ID can't be null");
             }
         }
         //Get RetailStoreID
        public List<RetailStoreID> GetRetailStoreID()
         {
             return _rdl.GetRetailStoreID();
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
