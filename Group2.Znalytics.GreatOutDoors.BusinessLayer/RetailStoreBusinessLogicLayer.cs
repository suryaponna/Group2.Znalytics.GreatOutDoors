using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2.Znalytics.GreatOutDoors.DataLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;


/// <summary>
/// Business Logic for RetailStore
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
   public class RetailStoreBusinessLogicLayer: IRetaiLStoreBusinessLogicLayer
    {
        
       private RetailStoreDataLayer _retailDataAccessLogic;
        public RetailStoreBusinessLogicLayer()
        {
            _retailDataAccessLogic = new RetailStoreDataLayer();
        }
        
        //Creating method for Validating RetailStore Id
        public void Add(RetailStoreID rsid)
        {

            if (rsid.RetailStoreID!= null)
            {
                _retailDataAccessLogic.Add(RetailStoreID);
                
            }
            else
            {
                throw new Exception("Retail store ID can't be null");
            } 
        }
        //Get RetailStoreID
        public List<RetailstoreID> GetRetailstoreIDs()
        {
            return _retailDataAccessLogic.GetRetailStoreIDs();
        }
       
    }

}
