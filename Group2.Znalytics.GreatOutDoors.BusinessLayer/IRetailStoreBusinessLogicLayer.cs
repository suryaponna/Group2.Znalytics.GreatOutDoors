//-----CREATED BY ARCHANA
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

//created namespace for interface business logic layer
namespace Group2.Znalytics.GreatOutDoors.IBusinessLogicLayer
{
    /// <summary>
    /// Reprsenrs an interface business logic layer
    /// </summary>
    public interface IRetailStoreBusinessLogicLayer
    {
        /// <summary>
        /// Method to add the details of retailstore
        /// </summary>
        /// <param name="retailstore">which represents the object for retailstore</param>
        void AddRetailstore(Retailstore retailstore);
        /// <summary>
        /// Method to get the list of retailstore
        /// </summary>
        /// <returns></returns>
        List<Retailstore> GetRetailstores();
        Retailstore GetRetailstoreByRetailstoreID(string RetailCustomerID);
    }
}
