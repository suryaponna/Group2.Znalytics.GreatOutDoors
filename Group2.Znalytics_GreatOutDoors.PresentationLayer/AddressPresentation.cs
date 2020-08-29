//-----------------------Surya----------------------------------------
/**
using System;
namespace Znalytics.Group2.GreatOutDoors.Entity
{
    public class Address
    {
        static void Main()
        {
            int choice;
            int Type;
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
            bool val=int.TryParse(System.Console.ReadLine(),out Type);
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
            System.Console.WriteLine("Enter Folllowing Options for further process");
            System.Console.WriteLine("Enter 1 to to update existing Address");
            System.Console.WriteLine("Enter 2 to to add new Shipping Address");
            System.Console.WriteLine("Enter 3 for all details are correct");
            bool ch = int.TryParse(System.Console.ReadLine(),out choice);
            if (ch) {
                do
                {
                     switch (choice)
                    {
                        case 1:
                            UpdateAddress(ad);
                            break;
                        case 2:
                            AddNewAddress(ad);
                            break;
                        case 3:
                            AddNewAddress(ad);
                            break;
                        default: Console.WriteLine("Enter 1 , 2 or 3");
                                break;
                    }

                } while (choice <= 4);
            }


        
        }
        static void UpdateAddress(AddressDetail ad) {
        Update:
            int choice2;
            System.Console.WriteLine("Enter your option for updating Particular field");
            System.Console.WriteLine("For Country enter 1");
            System.Console.WriteLine("For Name enter 2");
            System.Console.WriteLine("For Mobile Number enter 3");
            System.Console.WriteLine("for PinCode Enter 4 ");
            System.Console.WriteLine("For FlatNo Enter 5");
            System.Console.WriteLine("For Area Enter 6");
            System.Console.WriteLine("For LandMark Enter 7");
            System.Console.WriteLine("For Town/City Enter 8");
            System.Console.WriteLine("For State Enter 9");
            System.Console.WriteLine("For Address Type Enter 10 ");
            System.Console.WriteLine("To Finish Modifiying Enter 11");
            bool c= int.TryParse(System.Console.ReadLine(),out choice2);
            if (c)
            {
                do {
                    switch(choice2){
                        case 1:
                            System.Console.WriteLine("Enter Country:");
                            ad.CustomerCountry = (System.Console.ReadLine());
                            break;

                        case 2:
                            System.Console.WriteLine("Enter Your Name:");
                            ad.CustomerName = (System.Console.ReadLine());
                            break;
                        case 3:
                            System.Console.WriteLine("Enter Mobile Number:");
                            ad.MobileNumber = (System.Convert.ToInt64(System.Console.ReadLine()));
                            break;
                        case 4:
                            System.Console.WriteLine("Enter Your Pincode:");
                            ad.PinCode = System.Console.ReadLine();
                            break;
                        case 5:
                            System.Console.WriteLine("Enter Flat/DoorNumber:");
                            ad.FlatNo = (System.Console.ReadLine());
                            break;
                        case 6:
                            System.Console.WriteLine("Enter Your Area");
                            ad.AreaColony = (System.Console.ReadLine());
                            break;
                        case 7:
                            System.Console.WriteLine("Enter your LandMark:");
                            ad.LandMark = (System.Console.ReadLine());
                            break;
                        case 8:
                            System.Console.WriteLine("Enter your Town:");
                            ad.Town = (System.Console.ReadLine());
                            break;
                        case 9:
                            System.Console.WriteLine("Enter your State:");
                            ad.State = (System.Console.ReadLine());
                            break;
                        case 10:
                            System.Console.WriteLine("Enter Your Address Type");
                            int Type1;
                            bool val = int.TryParse(System.Console.ReadLine(), out Type1);
                            ad.AddressId = (AddressType)Type1;
                            break;

                        case 11:
                            AddressBusinessLogic bd = new AddressBusinessLogic(ad);
                            bd.AddAddress(ad);
                            System.Console.WriteLine("---------Mofification are finished-------");
                            
                            break;
                            //break;
                        default:
                            System.Console.WriteLine("Enter valid Option");
                            break;

                    }

                } while (choice2<=11);
            }
            else {
                goto Update;
            }
        }
        static void AddNewAddress(AddressDetail ad) {
            
        }
        static void AddAddress(AddressDetail ad) {
            AddressBusinessLogic bd = new AddressBusinessLogic(ad);
            bd.AddAddress(ad);
        }
    

    }
    
}
*/




