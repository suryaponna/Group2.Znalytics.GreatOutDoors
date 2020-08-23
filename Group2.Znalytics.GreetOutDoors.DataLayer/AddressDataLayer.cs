//--------------------Surya
using System.Collections.Generic;
using System.Collections;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;
using Group2.Znalytics.GreetOutDoors.DataLayer;
/// <summary>
/// Data Access Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.Entity

{
    public class AddressDataLayer:IEnumerable
    {

        private List<AddressDetail> _customerAddressesList;
        public AddressDataLayer()
        {
            _customerAddressesList = new List<AddressDetail>();
        }
        public IEnumerator GetEnumerator() {
            for (int i = 0; i < _customerAddressesList.Count; i++) {
                yield return _customerAddressesList[i];

            }
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

