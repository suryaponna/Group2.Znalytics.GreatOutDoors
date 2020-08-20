//------------------------Surya
using Znalytics.Group2.GreatOutDoor.Entity;
/// <summary>
/// Abstract class of Adddress data which consists of Methods
/// </summary>
namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public abstract class AbstractAddress
    {
        public abstract AddressDetail CustomerNewAddress(AddressDetail ad);
        public abstract AddressDetail CustomerAddressUpdate(AddressDetail ad);
        public abstract AddressDetail CustomerAddressDelete(AddressDetail ad);
        public abstract AddressDetail CustomerAdddresses(AddressDetail ad);

    }
}
