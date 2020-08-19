//--------------------Surya
using System.Collections.Generic;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;
/// <summary>
/// Data Access Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.Entity
{
    public class AddressDataLayer
    {
        //AddressDetail ad = new AddressDetail();
        private List<AddressDetail> _dataBase;
        public AddressDataLayer()
        {
            _dataBase = new List<AddressDetail>();
        }

        /// <summary>
        /// Adding new Customer Address
        /// </summary>
        /// <param name="address">Attribute to add adddress in to collection</param>
        public void AddAddress(AddressDetail address)
        {
            _dataBase.Add(address);
        }

    }
}

