﻿using Znalytics.Group2.GreatOutDoor.Entity;
using System.Collections.Generic;
/// <summary>
/// Business Logic for Address
/// </summary>
public class BusinessLogic{
    
    //List<string> TotalAddresses = new List<string>();
    DataLayer dl = new DataLayer();
    string sample = "";
    int j = 1;
    /// <summary>
    /// Method for Adding Customer Country
    /// </summary>
    /// <param name="ad">parameter is of AddressDeatils</param>
    public void AddCountry(AddressDetails ad) {
       
        if (ad.CustomerCountry.Length < 15)
        {
            this.sample = this.sample + ad.CustomerCountry + ",";
            //dl.AddAddress(ad.CustomerCountry);
        }
        else {
            this.j = 0;
        }
    }
    /// <summary>
    /// Method for Validating Customer Name
    /// </summary>
    /// <param name="ad">parameter is of AddressDeatils</param>
    public void AddCustomerName(AddressDetails ad) {
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
    public void AddMobileNumber(AddressDetails ad) {
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
    public void AddPinCode(AddressDetails ad) {
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
    public void AddFlatNo(AddressDetails ad) {
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
    public void AddAreaColony(AddressDetails ad) {
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
    public void AddLandMark(AddressDetails ad) {
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
    public void AddTown(AddressDetails ad) {
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
    public void AddState(AddressDetails ad) {
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
    public void AddAddressType(AddressDetails ad) {
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
    public void AddFullAddress() {
        if (this.j != 0) { dl.AddAddress(sample); }
    }

}

