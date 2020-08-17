using Znalytics.Group2.GreatOutDoor.Entity;
using System.Collections.Generic;
public class BusinessLogic{
    
    //List<string> TotalAddresses = new List<string>();
    DataLayer dl = new DataLayer();
    public void AddAddress(AddressDetails ad) {
        int i = 0, j = 1;
        string sample = " ";
        if (ad.CustomerCountry.Length < 15)
        {
            sample = sample + ad.CustomerCountry + ",";
            //dl.AddAddress(ad.CustomerCountry);
        }
        else {
            j = 0;
        }
        if (ad.CustomerName.Length < 15)
        {
            sample = sample + ad.CustomerName + ",";
            //dl.AddAddress(ad.CustomerName);
        }
        else {
            j = 0;
        }
        if (ad.MobileNumber <= 999999999)
        {
            sample = sample + System.Convert.ToString(ad.MobileNumber) + ",";
            //dl.AddAddress(System.Convert.ToString(ad.MobileNumber));
        }
        else {
            j = 0;
        }
        if (System.Convert.ToString(ad.PinCode).Length < 6)
        {
            sample = sample + System.Convert.ToString(ad.PinCode) + ",";
            //dl.AddAddress(System.Convert.ToString(ad.PinCode));
        }
        else {
            j = 0;
        }
        if (ad.FlatNo.Length < 15)
        {
            sample = sample + ad.FlatNo + ",";
            //dl.AddAddress(ad.FlatNo);
        }
        else {
            j = 0;
        }
        if (ad.AreaColony.Length < 15)
        {
            sample = sample + ad.AreaColony + ",";
            //dl.AddAddress(ad.AreaColony);
        }
        else {
            j = 0;
        }
        if (ad.LandMark.Length < 10)
        {
            sample = sample + ad.LandMark + ",";
            //dl.AddAddress(ad.LandMark);
        }
        else {
            j = 0;
        }
        if (ad.Town.Length < 10)
        {
            sample = sample + ad.Town + ",";
            //dl.AddAddress(ad.Town);
        }
        else {
            j = 0;
        }
        if (ad.State.Length < 15)
        {
            sample = sample + ad.State + ",";
            //dl.AddAddress(ad.State);
        }
        else {
            j = 0;
        }
        if (ad.AddressType.Length < 10)
        {
            sample = sample + ad.AddressType + ",";
            //dl.AddAddress(ad.AddressType);
        }
        else {
            j = 0;
        }
        if (j != 0) {
            dl.AddAddress(sample);
        }
    }
}