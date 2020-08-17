using System.Collections.Generic;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;

public class LogicLayer {
    List<string> DataBase = new List<string>();
    AddressDetails ad = new AddressDetails();
    private string _name;
    public void SetName(){
        _name=ad.CustomerCountry ;
    }
} 