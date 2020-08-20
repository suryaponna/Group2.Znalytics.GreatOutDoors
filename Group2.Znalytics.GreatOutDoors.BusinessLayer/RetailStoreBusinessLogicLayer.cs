using Group2.Znalytics.GreatOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Business Logic for RetailStore
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
   public class RetailStoreBusinessLogicLayer
    {
       // RetailStoreDataLayer dl = new RetailStoreDataLayer();
       // RetailStoreadd ad = new RetailStoreadd();
        
        public void AddRetailStoreID(RetailStore rs)
        {

            if (rs.RetailStoreID.Length != null)
            {
                RetailStoreDataLayer rdl = new RetailStoreDataLayer();
                rdl.AddRetailStoreID(rs);
                
            }
           
        }
    }
}
