
using static System.Console;
using Znalytics.Group2.GreatOutDoor.Entity;
using Znalytics.Group2.GreatOutDoor.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections;

using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System.CodeDom;

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class GreatOutDoorsMenu
    {
        static void Main() {
            WriteLine("----------------Welcome to GreatOutDoors hope you find your things here----------------");
            WriteLine();
            AddressDetail ad = new AddressDetail();
            while (true) {
                WriteLine("Enter 1 to sign up");
                WriteLine();
                WriteLine("Enter 2 to sign in");
                int option;
                bool b = int.TryParse(ReadLine(), out option);
                switch(option){
                    case 1:     CustomerSignUp();
                                break;
                    case 2:     CustomerSignIn();
                                break;
                    case 3:     SelectProducts();
                                break;
                    case 4:     ChangeShippingAddress();
                                break;
                    default:    WriteLine("Enter Valid Option");
                                break;  
                }
            }
        }
        static void CustomerSignUp() {
            SelectProducts();








        }
        static void CustomerSignIn() {



            SelectProducts();
        }
        static void SelectProducts() {
            WriteLine("-----------------These are the Products Hope you find out what you want---------------");

        }
        static void ChangeShippingAddress() {
            

            int Type;
            WriteLine("Enter All The Details Below Showed");
            AddressDetail ad = new AddressDetail();
            AddressBusinessLogic bd = new AddressBusinessLogic();

            try
            {
                WriteLine("------------------Enter Your Shipping Details ------------------");
                WriteLine("Enter Country:");
                ad.CustomerCountry = ReadLine();
                bd.ValidatingCountry(ad);
                //bd.IsCountryExists(ad.CustomerCountry);
                WriteLine("Enter Your Name:");
                ad.CustomerName = ReadLine();
                bd.ValidatingState(ad);
                WriteLine("Enter Mobile Number:");
                ad.MobileNumber = ReadLine();
                bd.ValidatingPhoneNumber(ad);
                WriteLine("Enter Your Pincode:");
                ad.PinCode = ReadLine();
                WriteLine("Enter Flat/DoorNumber:");
                ad.FlatNo = ReadLine();
                WriteLine("Enter Your Area");
                ad.AreaColony = ReadLine();
                WriteLine("Enter your LandMark:");
                ad.LandMark = ReadLine();
                WriteLine("Enter your Town/City:");
                ad.Town = ReadLine();
                WriteLine("Enter your State");
                ad.State = ReadLine();
                WriteLine("Enter your Address 0 for Type Home or 1 for Office");
                bool val = int.TryParse(ReadLine(), out Type);
                ad.AddressId = (AddressType)Type;
            }
            catch (Exception ex) {
                WriteLine(ex.Message);
            }
            WriteLine("These are your Address Details");
            WriteLine("Country: " + ad.CustomerCountry);
            WriteLine("Name: " + ad.CustomerName);
            WriteLine("Mobile Number: " + ad.MobileNumber);
            WriteLine("PinCode: " + ad.PinCode);
            WriteLine("FlatNo " + ad.FlatNo);
            WriteLine("Area: " + ad.AreaColony);
            WriteLine("LandMark: " + ad.LandMark);
            WriteLine("Town/City: " + ad.Town);
            WriteLine("State: " + ad.State);
            WriteLine("Address Type: " + ad.AddressId);


        }
        static void ChangeDefaultAddress() {
            AddressBusinessLogic ab = new AddressBusinessLogic();
            AddressDetail ad = new AddressDetail();
            int Id = ad.CustomerId;
            List<AddressDetail> AllAddresses = ab.GetAllCustomerAddresses(ad);
            WriteLine("From Below Addresses choose One");
            foreach (var i in AllAddresses) {
                WriteLine("Address Type: " + i.AddressId);
                WriteLine("Country: " + i.CustomerCountry);
                WriteLine("Name: " + i.CustomerName);
                WriteLine("Mobile Number: " + i.MobileNumber);
                WriteLine("PinCode: " + i.PinCode);
                WriteLine("FlatNo " + i.FlatNo);
                WriteLine("Area: " + i.AreaColony);
                WriteLine("LandMark: " + i.LandMark);
                WriteLine("Town/City: " + i.Town);
                WriteLine("State: " + i.State);
            }
            WriteLine("Enter Your Address Id which is to be changes as default address");
            try
            {
                int AddressId;
                bool b = int.TryParse(ReadLine(), out AddressId);
                if (b)
                {
                    AddressDetail samp = AllAddresses[AddressId];
                    ab.ChangeDefaultAddrees(samp);
                }
                else {
                    throw new AddressException("Enter valid Address Id");
                }
            }
            catch (AddressException ex) {
                WriteLine(ex.Message);
            }
            
        }
        static void RemoveAddress() {
            AddressDetail ad = new AddressDetail();
            AddressBusinessLogic ab = new AddressBusinessLogic();
            List<AddressDetail> Addresses=ab.GetAllCustomerAddresses(ad);
            foreach (var address in Addresses) {
                WriteLine("Address Type: " + address.AddressId);
                WriteLine("Country: " + address.CustomerCountry);
                WriteLine("Name: " + address.CustomerName);
                WriteLine("Mobile Number: " + address.MobileNumber);
                WriteLine("PinCode: " + address.PinCode);
                WriteLine("FlatNo " + address.FlatNo);
                WriteLine("Area: " + address.AreaColony);
                WriteLine("LandMark: " + address.LandMark);
                WriteLine("Town/City: " + address.Town);
                WriteLine("State: " + address.State);
            }
            WriteLine("Enter Your your Address Id to delete");
            int Option;
            bool b= int.TryParse(ReadLine(),out Option);
            if (b) {
                try
                {
                    AddressDetail add = Addresses[Option];
                    ab.RemoveAddress(add);
                }
                catch {
                    throw new AddressException("Enter Valid Address Id which you entered is not there");
                }
            }
            else
            {
                WriteLine("Enter Valid Option with ");
            }
        }
        static void UpdateAddress() {
            WriteLine("These are your addresses");
            AddressDetail ad = new AddressDetail();
            AddressBusinessLogic ab = new AddressBusinessLogic();
            List<AddressDetail> Addresses = ab.GetAllCustomerAddresses(ad);
            foreach (var address in Addresses)
            {
                WriteLine("Address Type: " + address.AddressId);
                WriteLine("Country: " + address.CustomerCountry);
                WriteLine("Name: " + address.CustomerName);
                WriteLine("Mobile Number: " + address.MobileNumber);
                WriteLine("PinCode: " + address.PinCode);
                WriteLine("FlatNo " + address.FlatNo);
                WriteLine("Area: " + address.AreaColony);
                WriteLine("LandMark: " + address.LandMark);
                WriteLine("Town/City: " + address.Town);
                WriteLine("State: " + address.State);
            }
            WriteLine("Enter Your Address Id to change");
            int Option;
            bool b = int.TryParse(ReadLine(),out Option);
            if (b) {
                try
                {
                    AddressDetail add = Addresses[Option];
                    WriteLine("Enter Your Details to be Updates");
                    do
                    {
                        WriteLine("Enter 1 to Update Country"); 
                    } while (true);
                    ab.UpdateExistingAddress(add);

                }
                catch(AddressException ae) {
                    WriteLine("Enter Valid Address id to Update");
                }
            }
        }



         



    }
}
