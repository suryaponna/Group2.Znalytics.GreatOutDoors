///--------------------Surya
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group2.GreatOutDoor.Entity;
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    /// <summary>
    /// Inetrface for Business Layer
    /// </summary>
    public interface IAddressBusinessLayer
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
        void AddAnotherAddressToCustomer(AddressDetail ad);
        /// <summary>
        /// Updating Existing Method
        /// </summary>
        /// <param name="ad"></param>
        void UpdateExistingAddress(AddressDetail ad);
        /// <summary>
        /// Changed Defalut Address of Customer
        /// </summary>
        /// <param name="ad"></param>
        void ChangeDefaultAddrees(AddressDetail ad);
        /// <summary>
        /// Adding Country to existing Countries List
        /// </summary>
        /// <param name="Country"></param>
        void AddCountrie(string Country);
        /// <summary>
        /// Adding States To existing States List
        /// </summary>
        /// <param name="State"></param>
        void AddState(string State);
        /// <summary>
        /// Adding Phone Code existing Phone Codes List
        /// </summary>
        /// <param name="PhoneCode"></param>
        void PhoneCode(string PhoneCode);

    }
}
