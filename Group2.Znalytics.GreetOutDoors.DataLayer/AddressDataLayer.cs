using System.Collections.Generic;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;
/// <summary>
/// Data Layer
/// </summary>
public class DataLayer {
    List<string> DataBase = new List<string>();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="address">Attribute to add adddress in to collection</param>
    public void AddAddress(string address) {
        DataBase.Add(address);
    }
    
} 