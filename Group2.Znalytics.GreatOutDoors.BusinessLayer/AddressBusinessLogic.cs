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
        AddressDataLayer dl = new AddressDataLayer();
        AddressDetail ad = new AddressDetail();
        string sample = "";
        int j = 1;
        /// <summary>
        /// Method for Adding Customer Country
        /// </summary>
        /// <param name="ad">parameter is of AddressDeatils</param>
        
        public void AddAddressType(AddressDetail ad,int Type)
        {
            if (Type == 0) 
                sample = sample +AddressDetail._addressType.Home;
            else
                sample=sample + AddressDetail._addressType.Office;
        }
        /// <summary>
        /// Adding Address to Data Layer
        /// </summary>
        public void AddFullAddress(AddressDetail ad)
        {
           dl.AddAddress(ad); 
        }

    }
}