using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group2.GreatOutDoor.Entity;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public interface IAddressDataLayer
    {
        /// <summary>
        /// Method return Default address of Customer
        /// </summary>
        /// <param name="ad">Customer Adddress Object</param>
        /// <returns></returns>
        AddressDetail RetunDefaultAddress(AddressDetail ad);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        AddressDetail ReturnAddress(AddressDetail ad);
        /// <summary>
        /// Removing Particular Address
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="Id"></param>
        void RemoveAddress(AddressDetail ad);
        /// <summary>
        /// Returns All Addresses OF Particular Customer
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        List<AddressDetail> GetAllCustomerAddresses(AddressDetail ad);
        /// <summary>
        /// Adding Another Address To Customer
        /// </summary>
        /// <param name="ad">new Address Object</param>
        void AddressAnotherAddressToCustomer(AddressDetail ad);
        void UpdateExistingAddress(AddressDetail ad);
        


    }
}
