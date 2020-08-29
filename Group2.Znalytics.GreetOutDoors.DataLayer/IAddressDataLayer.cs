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
        void RemoveAddress(AddressDetail ad,int Id);
        List<AddressDetail> GetAllCustomerAddresses(AddressDetail ad);
        void AddressAnotherAddressToCustomer(AddressDetail ad);
        void UpdateExistingAddress(int id,AddressDetail ad);
        


    }
}
