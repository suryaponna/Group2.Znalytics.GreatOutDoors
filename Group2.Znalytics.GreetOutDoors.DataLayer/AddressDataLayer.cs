using System.Collections.Generic;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;
/// <summary>
/// Data Layer
/// </summary>
public class DataLayer {
    List<AddressDetails> DataBase = new List<AddressDetails>();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="address">Attribute to add adddress in to collection</param>
    public void AddAddress(AddressDetails address) {
        DataBase.Add(address);
    }
    
} 