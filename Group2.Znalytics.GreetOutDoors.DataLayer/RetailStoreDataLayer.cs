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
        List<Retailstore> _retailstore;
        public RetailStoreDataLayer()
        {
            _retailstore = new List<Retailstore>();
        }
      //  List<string> DataBase = new List<string>();
        public void AddRetailStoreID(Retailstore rs)
        {
            _retailstore.Add(rs);
        }
    }
}
