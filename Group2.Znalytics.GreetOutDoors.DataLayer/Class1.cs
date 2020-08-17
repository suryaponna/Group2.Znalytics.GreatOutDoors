using System.Collections.Generic;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;

public class DataLayer {
    List<string> DataBase = new List<string>();
    public void AddAddress(string address) {
        DataBase.Add(address);
    }
    
} 