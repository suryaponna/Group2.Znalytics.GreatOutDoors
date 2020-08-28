using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group2.GreatOutDoor.Entity;
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public interface IAddressBusinessLayer
    {
        AddressDetail RetunDefaultAddress(AddressDetail ad);
        AddressDetail ReturnAddress(AddressDetail ad, int Id);
        void RemoveAddress(AddressDetail ad, int Id);
        List<AddressDetail> CustomerAllAddress(AddressDetail ad);
        void AddressAnotherAddressToCustomer(AddressDetail ad);
        void UpdateExistingAddress(int id, AddressDetail ad);
    }
}
