//using Znalytics.Group2.GreatOutDoor.Entity;


using System;
namespace Znalytics.Group2.GreatOutDoor.Entity
{
    public class Address
    {
        static void Main()
        {
        NewAddress:
            int spec = 0,sam=0;
            int Type;
            AddressDetail ad = new AddressDetail();
            AddressBusinessLogic bd = new AddressBusinessLogic();
            System.Console.WriteLine("------------------Enter Your Shipping Details ------------------");
            System.Console.WriteLine("Enter Country:");
            ad.CustomerCountry = (System.Console.ReadLine());
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
            AddressType:
            if (val)
            {
                bd.AddAddressType(ad,Type);
            }
            else
                throw new Exception("Enter valid option 0 or 1");            
        Add:
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
            //System.Console.WriteLine("Address Type: " + ad.AddressType);
            if (spec == 1)
            {
                goto Lab;
            }

            System.Console.WriteLine("If you want to add new address enter 1");
            System.Console.WriteLine("If you want to modify  address enter 2");
            System.Console.WriteLine("Enter 3 to Finalize the adress ");
            int a = System.Convert.ToInt32(System.Console.ReadLine());
            if (a == 3)
            {
                goto Lab;
            }
            if (a == 1)
            {
                System.Console.WriteLine("Enter New Address Details");
                goto NewAddress;
            }
            else
            {
                System.Console.WriteLine("Select your Fileds to modify");
                while (true)
                {
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
                    int b = int.Parse(System.Console.ReadLine());
                    switch (b)
                    {
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
                            ad.PinCode = System.Console.ReadLine());
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
                        case 11:
                            System.Console.WriteLine("---------Mofification are finished-------");
                            spec = 1;
                            goto Add;
                        default:
                            System.Console.WriteLine("Enter valid Option");
                            break;

                    }

                }
            }
        Lab:
            bd.AddFullAddress(ad);
            System.Console.WriteLine("----------Thank You for For your Interest to Buy the Product----------------- ");
            System.Console.ReadKey();

        }

    }
}





