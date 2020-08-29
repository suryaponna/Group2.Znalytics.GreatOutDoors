using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using System.Collections.Generic;
using System.Linq;
///--------------------Surya 
/// <summary>
/// Business Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.Entity
{
    public class AddressBusinessLogic:IAddressBusinessLayer
    {

        //List<string> TotalAddresses = new List<string>();
        AddressDataLayer dll;
        List<string> CountriesList = new List<string>(){"Afghanistan","Albania","Algeria","American Samoa","Andorra","Angola","Anguilla","Antarctica",
	"Antigua and Barbuda","Argentina","Armenia","Aruba","Australia","Austria","Azerbaijan","Bahamas","Bahrain","Bangladesh","Barbados",
	"Belarus","Belgium","Belize","Benin","Bermuda","Bhutan","Bolivia","Bosnia and Herzegovina","Botswana","Bouvet Island","Brazil","British Indian Ocean Territory",
	"Brunei Darussalam","Bulgaria","Burkina Faso","Burundi","Cambodia","Cameroon","Canada","Cape Verde","Cayman Islands","Central African Republic",
	"Chad","Chile","China","Christmas Island","Cocos (Keeling) Islands","Colombia","Comoros","Congo","Congo, the Democratic Republic of the","Cook Islands","Costa Rica",
	"Cote D'Ivoire","Croatia","Cuba","Cyprus","Czech Republic","Denmark","Djibouti","Dominica","Dominican Republic","Ecuador","Egypt",
	"El Salvador","Equatorial Guinea","Eritrea","Estonia","Ethiopia","Falkland Islands (Malvinas)","Faroe Islands","Fiji","Finland","France",
	"French Guiana","French Polynesia","French Southern Territories","Gabon","Gambia","Georgia","Germany","Ghana","Gibraltar",
	"Greece","Greenland","Grenada","Guadeloupe","Guam","Guatemala","Guinea","Guinea-Bissau","Guyana","Haiti","Heard Island and Mcdonald Islands","Holy See (Vatican City State)",
	"Honduras","Hong Kong","Hungary","Iceland","India","Indonesia","Iran, Islamic Republic of","Iraq","Ireland","Israel","Italy","Jamaica",
	"Japan","Jordan","Kazakhstan","Kenya","Kiribati","Korea, Democratic People's Republic of","Korea, Republic of","Kuwait","Kyrgyzstan","Lao People's Democratic Republic","Latvia",
	"Lebanon","Lesotho","Liberia","Libyan Arab Jamahiriya","Liechtenstein","Lithuania","Luxembourg","Macao","Macedonia, the Former Yugoslav Republic of",
	"Madagascar","Malawi","Malaysia","Maldives","Mali","Malta","Marshall Islands","Martinique","Mauritania","Mauritius","Mayotte",
	"Mexico","Micronesia, Federated States of","Moldova, Republic of","Monaco","Mongolia","Montserrat","Morocco","Mozambique","Myanmar","Namibia",
	"Nauru","Nepal","Netherlands","Netherlands Antilles","New Caledonia","New Zealand","Nicaragua","Niger","Nigeria","Niue",
	"Norfolk Island","Northern Mariana Islands","Norway","Oman","Pakistan","Palau","Palestinian Territory, Occupied","Panama","Papua New Guinea",
	"Paraguay","Peru","Philippines","Pitcairn","Poland","Portugal","Puerto Rico","Qatar","Reunion","Romania","Russian Federation","Rwanda",
	"Saint Helena","Saint Kitts and Nevis","Saint Lucia","Saint Pierre and Miquelon","Saint Vincent and the Grenadines","Samoa",	"San Marino",
	"Sao Tome and Principe","Saudi Arabia","Senegal","Serbia and Montenegro","Seychelles","Sierra Leone","Singapore","Slovakia",
	"Slovenia","Solomon Islands","Somalia","South Africa","South Georgia and the South Sandwich Islands","Spain","Sri Lanka","Sudan",
	"Suriname","Svalbard and Jan Mayen","Swaziland","Sweden","Switzerland","Syrian Arab Republic","Taiwan, Province of China","Tajikistan",
	"Tanzania, United Republic of","Thailand","Timor-Leste","Togo","Tokelau","Tonga","Trinidad and Tobago","Tunisia","Turkey",
	"Turkmenistan","Turks and Caicos Islands","Tuvalu","Uganda","Ukraine","United Arab Emirates","United Kingdom","United States","United States Minor Outlying Islands",
	"Uruguay","Uzbekistan","Vanuatu","Venezuela","Viet Nam","Virgin Islands, British","Virgin Islands, US","Wallis and Futuna","Western Sahara",
	"Yemen","Zambia","Zimbabwe",
	};
		List<string> StatesList = new List<string>();
        List<string> NumberCodes = new List<string>();
        

        public  AddressBusinessLogic()
        {
            dll = new AddressDataLayer();

        }
        
        /// <summary>
        /// Validating Address and Calling Data Layer Method  
        /// </summary>
        /// <param name="address"></param>
        public void AddAddress(AddressDetail address)
        {

            var b = CountriesList.Contains(address.CustomerCountry);
            if (b == true)
            {

            }
            //dll.Add(address);
        }
        
        public bool IsCountryExists(string countryName)
        {
            return CountriesList.Contains(countryName);
        }
        
        /// <summary>
        /// Updating Existing Customer Address
        /// </summary>
        /// <param name="Id"> AddressId</param>
        /// <param name="ad">Cutomer Address Object </param>
        public void UpdateExistingAddress(AddressDetail ad) {
            dll.UpdateExistingAddress(ad);
        }
        /// <summary>
        /// Retunrning Default Address
        /// </summary>
        /// <param name="ad">Customer Address Object</param>
        /// <returns></returns>
        public  AddressDetail RetunDefaultAddress(AddressDetail ad) { 
            AddressDetail DeafultAddress=dll.RetunDefaultAddress(ad);
            return DeafultAddress;
        }
        /// <summary>
        /// Returning Particular Address Of a Customer
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public AddressDetail ReturnAddress(AddressDetail ad) {
            AddressDetail ReturnedAddress = dll.ReturnAddress(ad);
            return ReturnedAddress;
        }
        /// <summary>
        /// Removing Particular Address Od A Customer
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="Id"></param>
        public void RemoveAddress(AddressDetail ad) {
            dll.RemoveAddress(ad);
        }
        /// <summary>
        /// Returning All Addresses Of the Customer
        /// </summary>
        /// <param name="ad">Customer Address Object</param>
        /// <returns></returns>
        public List<AddressDetail> GetAllCustomerAddresses(AddressDetail ad) {
            List<AddressDetail> AllAddresses = dll.GetAllCustomerAddresses(ad);
            return AllAddresses;
        }
        /// <summary>
        /// Adding Another Address to Existing Customer
        /// </summary>
        /// <param name="ad"></param>
        public void AddressAnotherAddressToCustomer(AddressDetail ad) {
            dll.AddressAnotherAddressToCustomer(ad);
        }
        
        
    
    }
}