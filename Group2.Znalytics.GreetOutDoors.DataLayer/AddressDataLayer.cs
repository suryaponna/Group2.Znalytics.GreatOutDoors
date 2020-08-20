//--------------------Surya
using System.Collections.Generic;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;
using Group2.Znalytics.GreetOutDoors.DataLayer;
/// <summary>
/// Data Access Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.Entity

{
    public class AddressDataLayer
    {
        
        private List<AddressDetail> _dataBase;
        public AddressDataLayer()
        {
            _dataBase = new List<AddressDetail>();
        }

        /// <summary>
        /// Adding new Customer Address
        /// </summary>
        /// <param name="address">Attribute to add adddress in to collection</param>
        public void AddNewAddress(AddressDetail address)
        {
            _dataBase.Add(address);

        }
        

    }
}

