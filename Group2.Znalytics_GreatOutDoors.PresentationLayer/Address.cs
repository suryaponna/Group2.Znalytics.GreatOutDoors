using Znalytics.Group2.GreatOutDoor.Entity;
public class Address
{
    static void Main()
    {
    NewAddress:
        int spec = 0;
        BusinessLogic bd = new BusinessLogic();
        AddressDetails ad = new AddressDetails();
        Retail r = new Retail();
        System.Console.WriteLine("------------------Enter Your Shipping Details ------------------");
        System.Console.WriteLine("Enter Country:");
        ad.CustomerCountry = (System.Console.ReadLine());
        bd.AddCountry(ad);
        System.Console.WriteLine("Enter Your Name:");
        ad.CustomerName = (System.Console.ReadLine());
        bd.AddCustomerName(ad);
        System.Console.WriteLine("Enter Mobile Number:");
        ad.MobileNumber = (System.Convert.ToInt64(System.Console.ReadLine()));
        bd.AddMobileNumber(ad);
        System.Console.WriteLine("Enter Your Pincode:");
        ad.PinCode = (System.Convert.ToInt64(System.Console.ReadLine()));
        bd.AddPinCode(ad);
        System.Console.WriteLine("Enter Flat/DoorNumber:");
        ad.FlatNo = (System.Console.ReadLine());
        bd.AddFlatNo(ad);
        System.Console.WriteLine("Enter Your Area");
        ad.AreaColony = (System.Console.ReadLine());
        bd.AddAreaColony(ad);
        System.Console.WriteLine("Enter your LandMark:");
        ad.LandMark = (System.Console.ReadLine());
        bd.AddLandMark(ad);
        System.Console.WriteLine("Enter your Town/City:");
        ad.Town = (System.Console.ReadLine());
        bd.AddTown(ad);
        System.Console.WriteLine("Enter your State");
        ad.State = (System.Console.ReadLine());
        bd.AddState(ad);
        System.Console.WriteLine("Enter your Address Type");
        ad.AddressType = (System.Console.ReadLine());
        bd.AddAddressType(ad);
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
        System.Console.WriteLine("Address Type: " + ad.AddressType);
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
                        bd.AddCountry(ad);
                        break;

                    case 2:
                        System.Console.WriteLine("Enter Your Name:");
                        ad.CustomerName = (System.Console.ReadLine());
                        bd.AddCustomerName(ad);
                        break;
                    case 3:
                        System.Console.WriteLine("Enter Mobile Number:");
                        ad.MobileNumber = (System.Convert.ToInt64(System.Console.ReadLine()));
                        bd.AddMobileNumber(ad);
                        break;
                    case 4:
                        System.Console.WriteLine("Enter Your Pincode:");
                        ad.PinCode = (System.Convert.ToInt64(System.Console.ReadLine()));
                        bd.AddPinCode(ad);
                        break;
                    case 5:
                        System.Console.WriteLine("Enter Flat/DoorNumber:");
                        ad.FlatNo = (System.Console.ReadLine());
                        bd.AddFlatNo(ad);
                        break;
                    case 6:
                        System.Console.WriteLine("Enter Your Area");
                        ad.AreaColony = (System.Console.ReadLine());
                        bd.AddAreaColony(ad);
                        break;
                    case 7:
                        System.Console.WriteLine("Enter your LandMark:");
                        ad.LandMark = (System.Console.ReadLine());
                        bd.AddLandMark(ad);
                        break;
                    case 8:
                        System.Console.WriteLine("Enter your Town:");
                        ad.Town = (System.Console.ReadLine());
                        bd.AddTown(ad);
                        break;
                    case 9:
                        System.Console.WriteLine("Enter your State:");
                        ad.State = (System.Console.ReadLine());
                        bd.AddState(ad);
                        break;
                    case 10:
                        System.Console.WriteLine("Enter your Address Type:");
                        ad.AddressType = (System.Console.ReadLine());
                        bd.AddAddressType(ad);
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





// PRODCUT MASTER//


class Basic
{
    static void Main()
    {
        Master m = new Master();

        System.Console.WriteLine("Select The below options for your product");
        System.Console.WriteLine("enter 1 for  personal accessories ");
        System.Console.WriteLine("enter 2 for golf equipment");
        System.Console.WriteLine("enter 3 for camping equipment");
        System.Console.WriteLine("enter 4 for mountaineering equipment ");
        System.Console.WriteLine("enter 5 for outdoor protection");
        System.Console.WriteLine("Enter your product option ");
        int choice = System.Convert.ToInt32(System.Console.ReadLine());
        switch (choice)
        {
            case 0:
                System.Console.WriteLine("personal accessories");
                break;
            case 1:
                System.Console.WriteLine("golf equipment");
                break;
            case 2:
                System.Console.WriteLine("camping equipment");
                break;
            case 3:
                System.Console.WriteLine("mountaineering equipment");
                break;
            case 4:
                System.Console.WriteLine("outdoor protection");
                break;
            case 5:
                System.Console.WriteLine("personal accessories");
                break;
        }
        System.Console.WriteLine("Enter your Id");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your id:" + m.GetId());
        System.Console.WriteLine("Enter your FirstName");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your FirstName:" + m.GetId());
        System.Console.WriteLine("Enter your LastName");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your LastName:" + m.GetId());
        System.Console.WriteLine("Enter your Number");
        m.SetNumber(System.Convert.ToInt64(System.Console.ReadLine()));
        System.Console.WriteLine("your Number:" + m.GetId());
        System.Console.ReadLine();
    }
}
