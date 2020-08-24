using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group2.GreatOutDoor.Entity;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public interface IRetailStoreBusinessLogicLayer
       
    {
        void AddRetailStore();
        List<RetailStoreID> GetRetailStoreID();
        Retailstore GetRetailstoreByRetailStoreID(string RetailStoreID);
    }
}
