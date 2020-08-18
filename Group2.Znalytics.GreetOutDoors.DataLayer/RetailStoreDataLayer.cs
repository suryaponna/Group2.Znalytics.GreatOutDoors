using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreattOutDoors.DataLayer
{
    public class RetailStoreDataLayer
    {
        List<string> DataBase = new List<string>();
        public void AddAddress(string retailStore)
        {
            DataBase.Add(retailStore);
        }
    }
}
