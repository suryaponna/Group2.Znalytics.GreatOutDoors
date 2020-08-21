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
   public class RetailStoreBusinessLogicLayer
    {

        private RetailStoreDataLayer _retailDataAccessLogic;
        public RetailStoreBusinessLogicLayer()
        {
            _retailDataAccessLogic = new RetailStoreDataLayer();
        }

        
        public void Add(RetailStoreID rsid)
        {

            if (rsid.RetailStoreID != null)
            {
                _retailDataAccessLogic.Add(RetailStoreID);

            }
            else
            {
                throw new Exception("Retail store ID can't be null");
            }
        }
        //Get RetailStoreID
       public List<RetailStoreID> GetRetailStoreID()
        {
            return _retailDataAccessLogic.GetRetailStoreID();
        }

    }
   


}
