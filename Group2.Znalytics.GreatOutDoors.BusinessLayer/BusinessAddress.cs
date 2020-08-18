using System.Collections.Generic;
///--------------------Surya 
/// <summary>
/// Business Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.Entity
{
    public class AddressBusinessLogic
    {

        //List<string> TotalAddresses = new List<string>();
        DataLayer dl = new DataLayer();
        AddressDetail ad = new AddressDetail();
        string sample = "";
        int j = 1;
        /// <summary>
        /// Method for Adding Customer Country
        /// </summary>
        /// <param name="ad">parameter is of AddressDeatils</param>
        public void AddCountry(AddressDetail ad)
        {

            if (ad.CustomerCountry.Length < 15)
            {
                this.sample = this.sample + ad.CustomerCountry + ",";
                //dl.AddAddress(ad.CustomerCountry);
            }
            else
            {
                this.j = 0;
            }
        }
        /// <summary>
        /// Method for Validating Customer Name
        /// </summary>
        /// <param name="ad">parameter is of AddressDeatils</param>
        public void AddCustomerName(AddressDetail ad)
        {
            if (ad.CustomerName.Length < 15)
            {
                this.sample = this.sample + ad.CustomerName + ",";
                //dl.AddAddress(ad.CustomerName);
            }
            else
            {
                this.j = 0;
            }

        }
        /// <summary>
        /// Method for Adding Customer Mobile Number
        /// </summary>
        /// <param name="ad">parameter is of AddressDeatils</param>
        public void AddMobileNumber(AddressDetail ad)
        {
            if (ad.MobileNumber <= 999999999)
            {
                this.sample = this.sample + System.Convert.ToString(ad.MobileNumber) + ",";
                //dl.AddAddress(System.Convert.ToString(ad.MobileNumber));
            }
            else
            {
                this.j = 0;
            }
        }
        /// <summary>
        /// Method for Adding Customer Pincode
        /// </summary>
        /// <param name="ad">parameter is of AddressDeatils</param>
        public void AddPinCode(AddressDetail ad)
        {
            if (System.Convert.ToString(ad.PinCode).Length < 6)
            {
                this.sample = this.sample + System.Convert.ToString(ad.PinCode) + ",";
                //dl.AddAddress(System.Convert.ToString(ad.PinCode));
            }
            else
            {
                this.j = 0;
            }

        }
        /// <summary>
        /// Method for Adding Customer Flat number
        /// </summary>
        /// <param name="ad">parameter is of AddressDeatils</param>
        public void AddFlatNo(AddressDetail ad)
        {
            if (ad.FlatNo.Length < 15)
            {
                this.sample = this.sample + ad.FlatNo + ",";
                //dl.AddAddress(ad.FlatNo);
            }
            else
            {
                this.j = 0;
            }

        }
        public void AddAreaColony(AddressDetail ad)
        {
            if (ad.AreaColony.Length < 15)
            {
                this.sample = this.sample + ad.AreaColony + ",";
                //dl.AddAddress(ad.AreaColony);
            }
            else
            {
                this.j = 0;
            }

        }
        public void AddLandMark(AddressDetail ad)
        {
            if (ad.LandMark.Length < 10)
            {
                this.sample = this.sample + ad.LandMark + ",";
                //dl.AddAddress(ad.LandMark);
            }
            else
            {
                this.j = 0;
            }

        }
        public void AddTown(AddressDetail ad)
        {
            if (ad.Town.Length < 10)
            {
                this.sample = this.sample + ad.Town + ",";
                //dl.AddAddress(ad.Town);
            }
            else
            {
                this.j = 0;
            }
        }
        public void AddState(AddressDetail ad)
        {
            if (ad.State.Length < 15)
            {
                sample = sample + ad.State + ",";
                //dl.AddAddress(ad.State);
            }
            else
            {
                this.j = 0;
            }

        }
        public void AddAddressType(AddressDetail ad)
        {
            if (ad.AddressType.Length < 10)
            {
                sample = sample + ad.AddressType + ",";
                //dl.AddAddress(ad.AddressType);
            }
            else
            {
                this.j = 0;
            }
        }
        /// <summary>
        /// Adding Address to Data Layer
        /// </summary>
        public void AddFullAddress(AddressDetail ad)
        {
            if (this.j != 0) { dl.AddAddress(ad); }
        }

    }
}