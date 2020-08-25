using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System.Collections.Generic;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public interface IRetailStoreBusinessLogicLayer
       
    {
        void AddRetailStoreID(Retailstore rsid);
        List<Retailstore> GetRetailStoreIDs();
        Retailstore GetRetailstoreByRetailStoreID(int RetailStoreID);
    }
}
