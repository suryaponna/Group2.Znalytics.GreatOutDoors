using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group2.GreatOutDoor.Entity;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public interface IAddressInterface
    {
        void AddNewAddress(AddressDetail ad);
        void UpdateAddress(AddressDetail ad);
        void DeleteAddress(AddressDetail ad);
        void GetAllAddresses(AddressDetail ad);
    }
}
