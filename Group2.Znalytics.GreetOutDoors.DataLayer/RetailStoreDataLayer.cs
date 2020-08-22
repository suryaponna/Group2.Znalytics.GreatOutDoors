//---------Archana
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
        private static List<Retailstore> _retailstoreid;
        public RetailStoreDataLayer()
        {
            _retailstoreid = new List<Retailstore>();

        }

        //Add retailstore id
        public void AddRetailStoreID(Retailstore rsid)
        {
            _retailstoreid.Add(rsid);
        }
    }
}
