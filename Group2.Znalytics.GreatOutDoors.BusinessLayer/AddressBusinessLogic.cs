﻿//------------------------------------Surya-----------------------------------------------------------
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using System.Collections.Generic;
using System.Linq;
using Znalytics.Group2.GreatOutDoor.Entity;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System.Globalization;

using Group2.Znalytics.GreatOutDoors.DataLayer;

///--------------------Surya 
/// <summary>
/// Business Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.BusinessLayer
{
    public class AddressBusinessLogic : IAddressBusinessLayer
    {

        //List<string> TotalAddresses = new List<string>();
        AddressDataLayer dll;
        /// <summary>
        /// List Of world countries
        /// </summary>
        List<string> CountriesList = new List<string>(){"Afghanistan","Albania","Algeria","American Samoa","Andorra","Angola","Anguilla","Antarctica",
        "Antigua and Barbuda","Argentina","Armenia","Aruba","Australia","Austria","Azerbaijan","Bahamas","Bahrain","Bangladesh","Barbados",
        "Belarus","Belgium","Belize","Benin","Bermuda","Bhutan","Bolivia","Bosnia and Herzegovina","Botswana","Bouvet Island","Brazil","British Indian Ocean Territory",
        "Brunei Darussalam","Bulgaria","Burkina Faso","Burundi","Cambodia","Cameroon","Canada","Cape Verde","Cayman Islands","Central African Republic",
        "Chad","Chile","China","Christmas Island","Cocos (Keeling) Islands","Colombia","Comoros","Congo","Congo, the Democratic Republic of the","Cook Islands","Costa Rica",
        "Cote D'Ivoire","Croatia","Cuba","Cyprus","Czech Republic","Denmark","Djibouti","Dominica","csminican", "Republic","Ecuador","Egypt",
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
        "Saint Helena","Saint Kitts and Nevis","Saint Lucia","Saint Pierre and Miquelon","Saint Vincent and the Grenadines","Samoa",    "San Marino",
        "Sao Tome and Principe","Saudi Arabia","Senegal","Serbia and Montenegro","Seychelles","Sierra Leone","Singapore","Slovakia",
        "Slovenia","Solomon Islands","Somalia","South Africa","South Georgia and the South Sandwich Islands","Spain","Sri Lanka","Sudan",
        "Suriname","Svalbard and Jan Mayen","Swaziland","Sweden","Switzerland","Syrian Arab Republic","Taiwan, Province of China","Tajikistan",
        "Tanzania, United Republic of","Thailand","Timor-Leste","Togo","Tokelau","Tonga","Trinidad and Tobago","Tunisia","Turkey",
        "Turkmenistan","Turks and Caicos Islands","Tuvalu","Uganda","Ukraine","United Arab Emirates","United Kingdom","United States","United States Minor Outlying Islands",
        "Uruguay","Uzbekistan","Vanuatu","Venezuela","Viet Nam","Virgin Islands, British","Virgin Islands, US","Wallis and Futuna","Western Sahara",
        "Yemen","Zambia","Zimbabwe",
         };
        /// <summary>
        /// States List only Indian states are considered
        /// </summary>
        List<string> StatesList = new List<string>(){"Andhra Pradesh", "Assam", "Arunachal Pradesh", "Bihar", "Goa", "Gujarat", "Jammu Kashmir", "Jharkhand", "West Bengal", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Orissa",
            "Punjab", "Rajasthan", "Sikkim","Tamil Nadu","Tripura, Uttaranchal","Uttar Pradesh","Haryana", "Himachal Pradesh","Chhattisgarh"};
        /// <summary>
        /// Contries Phone Codes same were Taken we can add codes by AddPhoneCode()
        /// </summary>
        List<string> NumberCodes = new List<string>() { "91", "93", "355", "213", "376", "244", "244", "672", "374", "297", "61", "43", "973", "375" };
        /// <summary>
        /// C0nstructer creating Address Data LAyer Object 
        /// </summary>
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
                if (StatesList.Contains(address.State))
                {
                    string[] PhoneNumber = address.MobileNumber.Split(' ');
                    if (PhoneNumber[0].Length == 2 && PhoneNumber[1].Length == 10)
                    {
                        string[] NumberCode = PhoneNumber[0].Split('+');
                        if (NumberCodes.Contains(NumberCode[1]))
                        {
                            string Number = PhoneNumber[1].ToString();
                            if (Number.All(char.IsDigit))
                            {
                                if (dll.CustomerAddressList.Contains(address))
                                {
                                    AddressDetail samp = dll.CustomerAddressList.Find(temp => temp.CustomerId == address.CustomerId);
                                    address.AddressId = samp.AddressId + 1;
                                    dll.Add(address);
                                }
                                else {
                                    dll.Add(address);
                                }
                            }
                            else {
                                throw new AddressException("Enter only digits");
                            }
                        }
                        else {
                            throw new AddressException("The enteres Number code doent belongs to any country please check once");
                        }
                    }
                }
                else {
                    throw new AddressException("Enter Valid State");
                }
            }
            else {
                throw new AddressException("Enteres Country was not valid please check once");
            }
        }
        /// <summary>
        /// checking entered country was in list or not
        /// </summary>
        /// <param name="ad"></param>
        public void ValidatingCountry(AddressDetail ad) {
            TextInfo CountryText = new CultureInfo("en-US",false).TextInfo;
            ad.CustomerCountry =CountryText.ToTitleCase(ad.CustomerCountry);
            var b = CountriesList.Contains(ad.CustomerCountry);
            if (b != true)
            {
                throw new AddressException("Enteres Country was not valid please check once");
            }
        } 
        /// <summary>
        /// another way of checking entered country is in list or not
        /// </summary>
        /// <param name="countryName"></param>
        /// <returns></returns>
        public bool IsCountryExists(string countryName)
        {
            TextInfo CountryText = new CultureInfo("en-US", false).TextInfo;
            countryName = CountryText.ToTitleCase(countryName);
            return CountriesList.Contains(countryName);
        }
        /// <summary>
        /// checking enteres state was in list or not
        /// </summary>
        /// <param name="ad"></param>
        public void ValidatingState(AddressDetail ad) {
            TextInfo CountryText = new CultureInfo("en-US", false).TextInfo;
            ad.CustomerCountry = CountryText.ToTitleCase(ad.CustomerCountry);
            var b = StatesList.Contains(ad.State);
            if (b != true) {
                throw new AddressException("Enteres State was not valid please check once");
            }
        }
        public void ValidatingPhoneNumber(AddressDetail ad) {
            string[] PhoneNumber = ad.MobileNumber.Split(' ');
            if (PhoneNumber[0].Length == 2 && PhoneNumber[1].Length == 10) {
                string[] NumberCode = PhoneNumber[0].Split('+');
                if (!NumberCodes.Contains(NumberCode[1])){
                    throw new AddressException("The enteres Number code doent belongs to any country please check once");
                }
                string Number = PhoneNumber[1].ToString();
                if (!Number.All(char.IsDigit)) {
                    throw new AddressException("Enter only digits");
                }
                
            }
        }
        
        /// <summary>
        /// Updating Existing Customer Address
        /// </summary>
        /// <param name="Id"> AddressId</param>
        /// <param name="ad">Cutomer Address Object </param>
        public void UpdateExistingAddress(AddressDetail ad) {

            try
            {
                if (ad != null) { dll.UpdateExistingAddress(ad); }
                else
                {
                    throw new AddressException("Address You want to find was not valid one");
                }
            }
            catch (AddressException ae)when(ae.Message== "Address Not Found, add this address as a new one") { 
            }
        }
        /// <summary>
        /// Retunrning Default Address
        /// </summary>
        /// <param name="ad">Customer Address Object</param>
        /// <returns></returns>
        public  AddressDetail RetunDefaultAddress(AddressDetail ad) {
            AddressDetail DeafultAddress=null;
            try
            {
                 DeafultAddress= dll.RetunDefaultAddress(ad);
                
            }
            catch (AddressException ae)when(ae.Message== "No default Address you Might not enteres your address while singup") { 
                
            }
            return DeafultAddress;

        }
        /// <summary>
        /// Returning Particular Address Of a Customer
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public AddressDetail ReturnAddress(AddressDetail ad) {
            AddressDetail ReturnedAddress=null;
            try { ReturnedAddress = dll.ReturnAddress(ad); }
            catch (AddressException ae) when (ae.Message == "Requested Address Not Found") { }
            return ReturnedAddress;
        }
        /// <summary>
        /// Removing Particular Address Od A Customer
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="Id"></param>
        public void RemoveAddress(AddressDetail ad) {
            try { dll.RemoveAddress(ad); }
            catch (AddressException aa) when (aa.Message == "Dear Customer You dont Have this address any more you no need to delete") { }
        }
        /// <summary>
        /// Returning All Addresses Of the Customer
        /// </summary>
        /// <param name="ad">Customer Address Object</param>
        /// <returns></returns>
        public List<AddressDetail> GetAllCustomerAddresses(AddressDetail ad) {
            List<AddressDetail> AllAddresses = dll.GetAllCustomerAddresses(ad.CustomerId);
            return AllAddresses;
        }
        /// <summary>
        /// Adding Another Address to Existing Customer
        /// </summary>
        /// <param name="ad"></param>
        public void AddAnotherAddressToCustomer(AddressDetail ad) {
            dll.AddAnotherAddressToCustomer(ad);
        }
        /// <summary>
        /// Changing Deafult Address method calling to Data Layer
        /// </summary>
        /// <param name="ad"></param>
        public void ChangeDefaultAddrees(AddressDetail ad) {
            dll.ChangeDefaultAddrees(ad);
        }
        public void RemoveAllAddresses(AddressDetail ad) {
            try
            {
                dll.RemoveAllAddresses(ad);
            }
            catch (AddressException ae) when (ae.Message == "Dear Customer No addresses For you") { }
        }
        /// <summary>
        /// Adding country to CountriesList
        /// </summary>
        /// <param name="country"></param>
        public void AddCountrie(string Country) {

            CountriesList.Add(Country);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="State"></param>
        public void AddState(string State) {
            StatesList.Add(State);
        }
        /// <summary>
        /// Adding new Phone Code to numbercode list
        /// </summary>
        /// <param name="PhoneCode"></param>
        public void PhoneCode(string PhoneCode) {
            NumberCodes.Add(PhoneCode);
        }

    }
}