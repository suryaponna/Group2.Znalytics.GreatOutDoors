//-----------------------------------Surya----------------------
using System;
using System.Collections.Generic;
using Znalytics.Group2.GreatOutDoor.Entity;
/// <summary>
/// Interface for Addres Data layer consists of methods to implement
/// </summary>
namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public interface IAddressInterface
    {
        /// <summary>
        /// Interface for Address of Customer consists of  methods to be
        /// </summary>
        /// <param name="ad">object of AddressDetail which consists of total information should pass</param>
        void AddNewAddress(AddressDetail ad);
        /// <summary>
        /// Update existig address of particular customer
        /// </summary>
        /// <param name="ad">object of AddressDetail which consists of total information should pass</param>
        void UpdateAddress(AddressDetail ad);
        /// <summary>
        /// Deleting existing Customer Address 
        /// </summary>
        /// <param name="ad">object of AddressDetail which consists of total information should pass</param>
        void DeleteAddress(AddressDetail ad);
        /// <summary>
        /// Returns total Addresses of the Customer
        /// </summary>
        /// <param name="ad"></param>
        void GetAllAddresses(AddressDetail ad);
    }
}
