using System.Collections.Generic;
///--------------------Surya 
/// <summary>
/// Business Logic for Address
/// </summary>
using Znalytics.Group2.GreatOutDoor.Entity;
namespace Znalytics.Group2.GreatOutDoor.Entity
{
    public class AddressBusinessLogic
    {

        //List<string> TotalAddresses = new List<string>();
        AddressDataLayer dll;
        

        public AddressBusinessLogic()
        {
            dll = new AddressDataLayer();
        }
        
        
        public void AddAddress(AddressDetail address)
        {
            dll.Add(address);
        }
        
        
        AddressDetail ad = new AddressDetail();
        string samplee = "";
        int j = 1;
        /// <summary>
        /// Method for Adding Customer Country
        /// </summary>
        /// <param name="ad">parameter is of AddressDeatils</param>

        /// <summary>
        /// Adding Address to Data Layer
        /// </summary>
        public void AddFullAddres(AddressDetail ad)
        {
            dll.Add(ad);
        }
        public void UpdateExistingAddress(AddressDetail ad) { 
            
        }

    }
}