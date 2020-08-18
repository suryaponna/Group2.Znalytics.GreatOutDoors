//--------------------Surya
using System.Collections.Generic;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;
/// <summary>
/// Data Layer
/// </summary>
public class DataLayer {
    List<AddressDetail> DataBase = new List<AddressDetail>();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="address">Attribute to add adddress in to collection</param>
    public void AddAddress(AddressDetail address) {
        DataBase.Add(address);
    }
    
} 