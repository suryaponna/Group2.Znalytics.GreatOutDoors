
using static System.Console;
using Znalytics.Group2.GreatOutDoor.Entity;
using Znalytics.Group2.GreatOutDoor.BusinessLayer;

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class GreatOutDoorsMenu
    {
        static void Main() {
            WriteLine("----------------WelCome TO GreatOutDoors hope you find your things here----------------");
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
            System.Console.WriteLine("------------------Enter Your Shipping Details ------------------");
            System.Console.WriteLine("Enter Country:");
            ad.CustomerCountry = (System.Console.ReadLine());
            bd.IsCountryExists(ad.CustomerCountry);
            System.Console.WriteLine("Enter Your Name:");
            ad.CustomerName = (System.Console.ReadLine());
            System.Console.WriteLine("Enter Mobile Number:");
            ad.MobileNumber = (System.Convert.ToInt64(System.Console.ReadLine()));
            System.Console.WriteLine("Enter Your Pincode:");
            ad.PinCode = (System.Console.ReadLine());
            System.Console.WriteLine("Enter Flat/DoorNumber:");
            ad.FlatNo = (System.Console.ReadLine());
            System.Console.WriteLine("Enter Your Area");
            ad.AreaColony = (System.Console.ReadLine());
            System.Console.WriteLine("Enter your LandMark:");
            ad.LandMark = (System.Console.ReadLine());
            System.Console.WriteLine("Enter your Town/City:");
            ad.Town = (System.Console.ReadLine());
            System.Console.WriteLine("Enter your State");
            ad.State = (System.Console.ReadLine());
            System.Console.WriteLine("Enter your Address 0 for Type Home or 1 for Office");
            bool val = int.TryParse(System.Console.ReadLine(), out Type);
            ad.AddressId = (AddressType)Type;
            System.Console.WriteLine("These are your Address Details");
            System.Console.WriteLine("Country: " + ad.CustomerCountry);
            System.Console.WriteLine("Name: " + ad.CustomerName);
            System.Console.WriteLine("Mobile Number: " + ad.MobileNumber);
            System.Console.WriteLine("PinCode: " + ad.PinCode);
            System.Console.WriteLine("FlatNo " + ad.FlatNo);
            System.Console.WriteLine("Area: " + ad.AreaColony);
            System.Console.WriteLine("LandMark: " + ad.LandMark);
            System.Console.WriteLine("Town/City: " + ad.Town);
            System.Console.WriteLine("State: " + ad.State);
            System.Console.WriteLine("Address Type: " + ad.AddressId);


        }



    }
}
