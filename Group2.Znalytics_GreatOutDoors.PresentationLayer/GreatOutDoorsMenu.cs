
using static System.Console;
using Znalytics.Group2.GreatOutDoor.Entity;
using Znalytics.Group2.GreatOutDoor.BusinessLayer;
using System;

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class GreatOutDoorsMenu
    {
        static void Main() {
            WriteLine("----------------Welcome to GreatOutDoors hope you find your things here----------------");
            WriteLine();
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
                ad.CustomerCountry = (System.Console.ReadLine());
                bd.ValidatingCountry(ad);
                //bd.IsCountryExists(ad.CustomerCountry);
                WriteLine("Enter Your Name:");
                ad.CustomerName = (System.Console.ReadLine());
                bd.ValidatingState(ad);
                WriteLine("Enter Mobile Number:");
                ad.MobileNumber = System.Console.ReadLine();
                bd.ValidatingPhoneNumber(ad);
                WriteLine("Enter Your Pincode:");
                ad.PinCode = (System.Console.ReadLine());
                WriteLine("Enter Flat/DoorNumber:");
                ad.FlatNo = (System.Console.ReadLine());
                WriteLine("Enter Your Area");
                ad.AreaColony = (System.Console.ReadLine());
                WriteLine("Enter your LandMark:");
                ad.LandMark = (System.Console.ReadLine());
                WriteLine("Enter your Town/City:");
                ad.Town = (System.Console.ReadLine());
                WriteLine("Enter your State");
                ad.State = (System.Console.ReadLine());
                WriteLine("Enter your Address 0 for Type Home or 1 for Office");
                bool val = int.TryParse(System.Console.ReadLine(), out Type);
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



    }
}
