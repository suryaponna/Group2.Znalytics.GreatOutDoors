using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Data Access Layer
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.DataLayer
{
    public class RetailStoreDataLayer
    {
        //private fields
        private static List<RetailStoreID> _retailstoreid;
        static RetailStoreDataLayer()
        {
            _retailstoreid = new List<RetailStoreID>();
          
        }
        
        //Add retailstore id
        public void Add(RetailStoreID rsid)
        {
            _retailstoreid.Add(rsid);
        }
    }
}
