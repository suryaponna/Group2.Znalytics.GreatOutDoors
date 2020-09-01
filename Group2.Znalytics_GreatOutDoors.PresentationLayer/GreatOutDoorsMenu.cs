
using static System.Console;
using Znalytics.Group2.GreatOutDoor.Entity;
using Znalytics.Group2.GreatOutDoor.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections;

using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System.CodeDom;
/**
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreatOutDoors.RetailProducts.EntityLayer;
using Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer;
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using Group2.Znalytics.GreatOutDoors.RetailProducts.BusinessLogicLayer;
using System.Security.Cryptography.X509Certificates;*/

/*namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
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
                        //// Changing Shipping Address
                    case 4:     ChangeShippingAddress();
                                break;
                    default:    WriteLine("Enter Valid Option");
                                break;  
                }
            }
        }
        /**public static void RetailstoreMenu()
        {
            int choice = -1;
            do
            {
                Console.WriteLine("------------------------------:) WELCOME TO RETAIL STORE (:------------------------------");
                Console.WriteLine("RETAILSTORE MENU");
                Console.WriteLine("1. Add Retailstore");
                Console.WriteLine("2. Display Retailstore");
                Console.WriteLine("3. Display Retailstore by RetailstoreID");
                Console.WriteLine("4. Delete Retailstore");
                Console.WriteLine("5. Update Reatilstore");
                Console.WriteLine("6. Add Products");
                Console.WriteLine("7. Display Retail Products");
                Console.WriteLine("8. Get Products By Id");
                Console.WriteLine("9. Remove products");
                Console.WriteLine("10. Update Products");
                Console.WriteLine("11. Add quantity of products");
                Console.WriteLine("12. SuppliersForTransporting");
                Console.WriteLine("13. Exit");

                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {
                    switch (choice)
                    {
                        case 1: AddRetailstore(); break;
                        case 2: GetRetailstores(); break;
                        case 3: GetRetailstoreByRetailstoreID(); break;
                        case 4: RemoveRetailstore(); break;
                        case 5: UpdateRetailstore(); break;
                        case 6: AddProducts(); break;
                        case 7: GetRProducts(); break;
                        case 8: GetProductsByID(); break;
                        case 9: RemoveProduct(); break;
                        case 10: UpdateProducts(); break;
                        case 11: AddQuantityOfProducts(); break;
                        case 12: SuppliersForTransporting(); break;
                        default: break;

                    }
                }
            } while (choice != 13);
        }*/
      /*  static void CustomerSignUp() {
            SelectProducts();








        }
        static void CustomerSignIn() {



            SelectProducts();
        }
        static void SelectProducts() {
            WriteLine("-----------------These are the Products Hope you find out what you want---------------");

        }
        /// <summary>
        /// Method for Changing Shipping Address
        /// </summary>
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
                WriteLine("Enter true if this is your Default address otherwise enter false");
                ad.DefaultAddressOrNot = Convert.ToBoolean(ReadLine());
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
        /// <summary>
        /// Changing Default Address of a Customer
        /// </summary>
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
        /// <summary>
        /// Removing Particular Address For a Customer
        /// </summary>
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
        /// <summary>
        /// Updating one address of the Customer Addresses
        /// </summary>
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
                WriteLine("State: " + address.DefaultAddressOrNot);
            }
            WriteLine("Enter Your Address Id to change");
            int Option;
            bool b = int.TryParse(ReadLine(),out Option);
            if (b) {
                try
                {
                    AddressDetail add = Addresses[Option];
                    AddressBusinessLogic updating = new AddressBusinessLogic();
                    WriteLine("Enter Your Details to be Updates");
                    do
                    {
                        WriteLine("Enter 1 to Update Country");
                        WriteLine("Enter 2 to Update Customer Name");
                        WriteLine("Enter 3 to Update Customer Mobile Number");
                        WriteLine("Enter 4 to Update Mobile Number");
                        WriteLine("Enter 5 to Update Pincode");
                        WriteLine("Enter 6 to Update FaltNo");
                        WriteLine("Enter 7 to Update Area");
                        WriteLine("Enter 8 to Update LandMark");
                        WriteLine("Enter 9 to Update Town");
                        WriteLine("Enter 10 update State");
                        WriteLine("Enter 11 to Update DefaultAddress");
                        WriteLine("Enter 12 to Update Address Type");
                        int Option1;
                        bool bb = int.TryParse(ReadLine(), out Option1);
                        if (bb) {
                            switch (Option1) {
                                case 1: 
                                    add.CustomerCountry = ReadLine();
                                    updating.ValidatingCountry(add);
                                    break;
                                case 2:
                                    add.CustomerName = ReadLine();
                                    //updating.ValidatingCountry(add);
                                    break;
                                case 3:
                                    add.MobileNumber = ReadLine();
                                    updating.ValidatingPhoneNumber(add);
                                    break;
                                case 4:
                                    add.PinCode = ReadLine();
                                    break;
                                case 5:
                                    add.PinCode = ReadLine();
                                    break;
                                case 6:
                                    add.FlatNo = ReadLine();
                                    break;
                                case 7:
                                    add.AreaColony = ReadLine();
                                    break;
                                case 8:
                                    add.LandMark = ReadLine();
                                    break;
                                case 9:
                                    add.Town = ReadLine();
                                    updating.ValidatingState(add);
                                    break;
                                case 10:
                                    add.DefaultAddressOrNot = Convert.ToBoolean(ReadLine());
                                    break;
                                case 11:
                                    int Type;
                                    bool val = int.TryParse(ReadLine(), out Type);
                                    add.AddressId = (AddressType)Type;
                                    break;
                            }
                        }

                    } while (true);
                    ab.UpdateExistingAddress(add);

                }
                catch(AddressException ae) {
                    WriteLine("Enter Valid Address id to Update");
                }
            }
        }
        /// <summary>
        /// Removing Customer All Addresses
        /// </summary>
        static void RemoveMyAddresses() {
            AddressDetail ad = new AddressDetail();
            AddressBusinessLogic ab = new AddressBusinessLogic();
            try { ab.RemoveAllAddresses(ad); }
            catch (AddressException ae) {
                throw new AddressException("For you there were no Adderesses");
            }
            
        }
        static void ReturnPresentation()
        {
            Return rm = new Return();
        }



        /**
                /// <summary>
                /// AddRetailStore is a static method
                /// </summary>
                /// <param name="RetailCustomerID">Represents ID of Retail customer id</param>
                /// <param name="CustomerName">Represents retail customer name</param>
                /// <param name="Reports">Reprsents payment choice</param>
                public static void AddRetailstore()
                {
                    try
                    {
                        Retailstore r = new Retailstore();
                        RetailStoreBusinessLogicLayer rbl = new RetailStoreBusinessLogicLayer();
                        Console.WriteLine("Enter the Retail Store Details");
                        Console.WriteLine("Enter Retail store ID starts with ZRS and length of 8");
                        r.RetailCustomerID = Console.ReadLine();
                        Console.WriteLine("Enter choice of reports for the Choosing for the payment method");
                        //choice of choosing reports for paying  the amount
                        Console.WriteLine("================Select the choice  for payment choosing reports================");
                        Console.WriteLine("Enter 1 for Monthly reports");
                        Console.WriteLine("Enter 2 for Quaterly reports");
                        Console.WriteLine("Enter 3 for Annual reports");
                        int Choice = int.Parse(Console.ReadLine());
                        //Switch case for selecting the choice choosing reports to pay the amount
                        switch (Choice)
                        {
                            case 1:
                                Console.WriteLine("Monthly reports");
                                r.Reports = "Monthly reports";
                                break;
                            case 2:
                                Console.WriteLine("Quarterly reports");
                                r.Reports = "Quarterly reports";
                                break;
                            case 3:
                                Console.WriteLine("Annual reports");
                                r.Reports = "Annual Reports";
                                break;
                            default:
                                Console.WriteLine("Unknown choice");
                                break;
                        }
                        Console.WriteLine("Selected reports are:" + r.Reports);
                        rbl.AddRetailstore(r);
                        Console.WriteLine("Details are added ");


                    }
                    catch (RetailstoreException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                /// <summary>
                /// Method to get the Retailstore details
                /// </summary>
                public static void GetRetailstores()
                {
                    //created an object for Retailstore business class is stored in a reference variable
                    RetailStoreBusinessLogicLayer rbl = new RetailStoreBusinessLogicLayer();
                    //Retailstore list is stored in reference variable
                    List<Retailstore> retailstoreList = rbl.GetRetailstores();
                    Console.WriteLine("---------------------------------WELCOME TO GREAT OUTDOOR DETAIL RETAIL STORE---------------------------------");
                    Console.WriteLine("------------------- RETAILSTORE DETAILS ---------------");
                    Console.WriteLine("RetailCustomerID" + " " + "CustomerName" + " " + "Reports");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    foreach (Retailstore var in retailstoreList)
                    {
                        Console.WriteLine("Customer Retail store id is:" + var.RetailCustomerID);
                        Console.WriteLine("Choice of choosing payments reports are:" + var.Reports);
                    }
                }
                /// <summary>
                /// Method to get Retail store details by  retailcusomerid
                /// </summary>
                public static void GetRetailstoreByRetailstoreID()
                {
                    try
                    {
                        //created an object for Retailstore business class is stored in a reference variable
                        RetailStoreBusinessLogicLayer rbl = new RetailStoreBusinessLogicLayer();
                        Console.WriteLine("Enter existing customer id");
                        string rcID = Console.ReadLine();
                        //Condition to check whether customer id exists or not
                        Retailstore rs = rbl.GetRetailstoreByRetailstoreID(rcID);
                        if (rs != null)
                        {
                            Console.WriteLine("RetailCustomerID" + " " + "Reports");
                            Console.WriteLine(rs.RetailCustomerID + " " + rs.Reports);

                        }
                        else
                        {
                            Console.WriteLine("Sorry details are not exist");
                        }

                    }
                    catch (RetailstoreException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                /// <summary>
                /// Method to Remove retailstore details
                /// </summary>
                public static void RemoveRetailstore()
                {
                    Retailstore e = new Retailstore();//Creating object for retail store class
                    RetailStoreBusinessLogicLayer rbl = new RetailStoreBusinessLogicLayer();//creating object for retail storebusinesslogic layer
                    //Console.WriteLine("Select the type you want to remove the retailstore details ");
                    Console.WriteLine("1. RetailCustomerID");
                    ///<summary>
                    ///Method to remove retailer customer id
                    /// </summary>
                    void RemoveRetailCustomerByID()
                    {
                        Retailstore r = new Retailstore();
                        Console.WriteLine("Enter Customer Id to be deleted");
                        string retailCustomerID = Console.ReadLine();
                        try
                        {
                            if (rbl.GetRetailstoreByRetailstoreCustomerID(r.RetailCustomerID) == null)
                            {
                                rbl.RemoveRetailCustomerByID(retailCustomerID);
                                Console.WriteLine("REMOVED");
                            }
                        }
                        catch (RetailstoreException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    }
                }
                public static void UpdateRetailstore()
                {
                    RetailStoreBusinessLogicLayer rbl = new RetailStoreBusinessLogicLayer();
                    Console.WriteLine("1.Update By id");
                    //method to update customer name 
                    void UpdateRetailstoreByRetailCustomerID()
                    {
                        try
                        {
                            Console.WriteLine("Enter existing Retailcustomer Id");
                            String rsID = Console.ReadLine();
                            Retailstore rs = rbl.GetRetailstoreByRetailstoreCustomerID(rsID);
                            if (rs != null)
                            {
                                Console.WriteLine("Enter customer ID");
                                rs.RetailCustomerID = Console.ReadLine();
                                rbl.UpdateRetailstoreByRetailCustomerID(rs);
                                Console.WriteLine(" Customer Name is updated successfully!!!!");
                            }
                            else
                            {
                                Console.WriteLine("RETAIL ID doesn't Exist");
                            }
                        }
                        catch (RetailstoreException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                /// <summary>
                /// AddProducts is a static method  
                /// </summary>
                public static void AddProducts()
                {
                    try
                    {
                        RProducts p = new RProducts();
                        RetailProductsBusinessLogicLayer rp = new RetailProductsBusinessLogicLayer();
                        Console.WriteLine("Enter Product ID Starts with ZRSPID and length should be 10");
                        p.ProductID = Console.ReadLine();
                        Console.WriteLine("You have entered the correct ProductId");
                        Console.WriteLine("You are choose to Add the Products");
                        Console.WriteLine("Select the type of the products and Quantity of the products");
                        List<string> s = new List<String>();
                        p.RetailProducts = s;

                        //Catagories of Products in retail store
                        Console.WriteLine("------------------------------TYPES OF PRODUCTS IN OUR RETAIL STORE------------------------------");

                        Console.WriteLine("Enter 1. for Book Catagories and cost range is  20-3499");
                        Console.WriteLine("Enter 2. for Electrical Appliances and cost range is  1000-100000");
                        Console.WriteLine("Enter 3. for Grocery products and cost range is  1000-5000");
                        Console.WriteLine("Enter 4. for Medical Products and  cost range is  10-30000");
                        Console.WriteLine("Enter 5. for Fashion products and cost range is  100-5000");
                        Console.WriteLine("Enter 6. for Fitness products and cost range is  100-50000");
                        Console.WriteLine("Enter 7. for Industrial products and cost range is  1000-500000");
                        Console.WriteLine("Enter 8. for Eletronical devices and cost range is  1000-100000");
                        Console.WriteLine("Enter 9. for Kitchen Products and cost range is  100-535000");
                        Console.WriteLine("Enter more than 10. to exit");
                        int ch = 1;
                        do
                        {
                            bool a = int.TryParse(Console.ReadLine(), out ch);
                            if (a == true)
                            {
                                switch (ch)
                                {
                                    case 1:
                                        Console.WriteLine("Books");
                                        s.Add("Books");
                                        //categories  of Books
                                        Console.WriteLine("----------Categories of BOOKS-----------");
                                        Console.WriteLine("\n 1.Comic \n 2.Aptitude \n 3.Historical Fiction \n 4.Educational Books \n 5.Literary Fiction \n 6.Dective and Mystery \n 7.Exit");
                                        //Switch Case statement to select the categories of Books
                                        int choice1 = 1;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice1);
                                            if (b == true)
                                            {
                                                switch (choice1)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Comic Books");
                                                        s.Add("Comic Books");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("Aptitude Books");
                                                        s.Add("Aptitude ");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Historical Fiction");
                                                        s.Add("Historical Fiction");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Educational Books");
                                                        s.Add("Educational Books");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Literary Fiction");
                                                        s.Add("Literary Fiction");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 6:
                                                        Console.WriteLine("Dective and Mystery");
                                                        s.Add("Dective and Mystery");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    default:
                                                        Console.WriteLine("Exit");
                                                        break;
                                                }
                                                   Console.WriteLine("Total cost of products is 3456");
                                            }
                                        } while (choice1 != 7);
                                        break;
                                    case 2:
                                        Console.WriteLine("Electrical Appliances");
                                        s.Add("Electrical Appliances");
                                        Console.WriteLine("--------Catagories of Electrical Appliances---------");
                                        Console.WriteLine("\n 1.Iron Box \n 2.Water Purifiers \n 3.Air Purifiers \n 4.Refridgerators \n 5.Washing Machines \n 6.Exit");
                                        //Switch Case statement to select the catagorie of electrical appliances
                                        int choice2 = 1;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice2);
                                            if (b == true)
                                            {
                                                switch (choice2)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Iron Box");
                                                        s.Add("Iron Box");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("Water Purifiers");
                                                        s.Add("Water Purifiers");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Air Purifiers");
                                                        s.Add("Air Purifiers");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Refridgerators");
                                                        s.Add("Refridgerators");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Washing Machines");
                                                        s.Add("Washing Machines");
                                                        //AddProductQuantity();
                                                        break;
                                                    default:
                                                        Console.WriteLine("Exit");
                                                        break;
                                                }
                                                Console.WriteLine("Total cost of products is 250678");
                                            }
                                        } while (choice2 != 6);
                                        break;
                                    case 3:
                                        Console.WriteLine("Grocery Products");
                                        s.Add("Grocery products");
                                        //Choice of choosing Catagories of Grocery products 
                                        Console.WriteLine("---------------Catagories of Grocery products---------------");
                                        Console.WriteLine("\n 1.Beverages \n 2.Dairy products \n 3.Frozen foods\n 4.Meat \n 5.Cleaner products \n 6.Vegetables \n 7.Exit");

                                        //Switch Case statement to select the catagories of Grocery products
                                        int choice3 = 18;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice3);
                                            if (b == true)
                                            {
                                                switch (choice3)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Beverages");
                                                        s.Add("Beverages");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("Dairy products");
                                                        s.Add("Dairy products");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Frozen foods");
                                                        s.Add("Frozen foods");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Meat");
                                                        s.Add("Meat");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Cleaner products");
                                                        s.Add("Cleaner products");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 6:
                                                        Console.WriteLine("Vegeatables");
                                                        s.Add("Vegeatables");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 7:
                                                        Console.WriteLine("Exit");
                                                        break;
                                                }
                                                Console.WriteLine("Total cost of products is 2678");
                                            }
                                        } while (choice3 != 7);
                                        break;
                                    case 4:
                                        s.Add(" Medical Products");
                                        //Choice of choosing Catagories of Medical Products
                                        Console.WriteLine("---------------Catagories of Medical Products---------------");
                                        Console.WriteLine("\n 1.Surgical Products\n 2.First Aid kit\n 3.Dialysis Machine\n 4.All types medical drugs \n 5.Exit");
                                        //Switch Case statement to select the catagories of Grocery products
                                        int choice4 = 1;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice4);
                                            if (b == true)
                                            {
                                                switch (choice4)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Surgical Products");
                                                        s.Add("Surgical Products");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("First Aid kit");
                                                        s.Add("First Aid kit");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Dialysis Machine");
                                                        s.Add("Dialysis Machine");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("All types medical drugs");
                                                        s.Add("All types medical drugs");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Exit");
                                                        break;
                                                }
                                                Console.WriteLine("Total cost of products is 50678");
                                            }
                                        } while (choice4 != 5);
                                        break;
                                    case 5:
                                        s.Add("Fashion products");
                                        Console.WriteLine("---------------Categories of Fahion Products---------------");
                                        Console.WriteLine("\n 1.FootWear  \n 2.Sportswear \n 3.Traditioal \n 4.Accessories \n 5.Jewelry \n 6.Watches \n 7.Formal Wear \n 8.Exit");
                                        //Switch Case statement to select the catagories of Fashion products
                                        int choice5 = 1;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice5);
                                            if (b == true)
                                            {
                                                switch (choice5)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Footwear");
                                                        s.Add("Footwear");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("Sportswear");
                                                        s.Add("Sportswear");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Traditional wear");
                                                        s.Add("Traditional wear");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Accessories");
                                                        s.Add("Accessories");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Watches");
                                                        s.Add("Watches");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 6:
                                                        Console.WriteLine("Jewelry");
                                                        s.Add("Jewelry");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 7:
                                                        Console.WriteLine("Formal Wear");
                                                        s.Add("Formal Wear");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 8:
                                                        Console.WriteLine("Exit");
                                                        break;
                                                }
                                                Console.WriteLine("Total cost of products is 6580");
                                            }
                                        } while (choice5 != 8);
                                        break;
                                    case 6:
                                        s.Add("Fitness products");
                                        Console.WriteLine("---------------Categories of Fitness Products---------------");
                                        Console.WriteLine("\n 1.Treadmills \n 2.Skipping ropes \n 3.Dumbbell \n 4.Yoga Mats  \n 5.Exit");

                                        //Switch Case statement to select the catagories of Fitness Items
                                        int choice6 = 1;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice6);
                                            if (b == true)
                                            {
                                                switch (choice6)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Formal Wear");
                                                        s.Add("Treadmills");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("Skipping ropes");
                                                        s.Add("Skipping ropes");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Dumbbells");
                                                        s.Add("Dumbbells");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Yoga Mats");
                                                        s.Add("Yoga Mats");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Exit");
                                                        break;
                                                }
                                                Console.WriteLine("Total cost of products is 50678");
                                            }
                                        } while (choice6 != 5);
                                        break;
                                    case 7:
                                        s.Add("Industrial products");
                                        Console.WriteLine("---------------Categories of Industrial Products---------------");
                                        Console.WriteLine("\n 1.Power Generators \n 2.Radiators \n 3.Lubricants \n 4.Raw Materials \n 5.Component Material \n 6.Manufactured Products \n 7.Exit");
                                        //Switch Case statement to select the catagories of Fashion Products
                                        int choice7 = 1;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice7);
                                            if (b == true)
                                            {
                                                switch (choice7)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Power Generators");
                                                        s.Add("Power Generators");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("Radiators");
                                                        s.Add("Radiators");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Lubricants");
                                                        s.Add("Lubricants");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Raw Material");
                                                        s.Add("Raw Material");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Component Material");
                                                        s.Add("Component Material");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 6:
                                                        Console.WriteLine("Manufactured Products");
                                                        s.Add("Manufactured Products ");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 7:
                                                        Console.WriteLine("Exit");
                                                        break;
                                                }
                                                Console.WriteLine("Total cost of products is 500678");
                                            }
                                        } while (choice7 != 7);
                                        break;
                                    case 8:

                                        s.Add("Eletronical devices");
                                        Console.WriteLine("---------------Catagories of Electronical devices---------------");
                                        Console.WriteLine("\n 1.Gadgets\n 2.Switches \n 3.Chargers \n 4.Resistors \n 5.Exit");
                                        //Switch Case statement to select the catagories of Electronical devices
                                        int choice8 = 1;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice8);
                                            if (b == true)
                                            {
                                                switch (choice8)
                                                {
                                                    case 1:
                                                        Console.WriteLine("gadgets");
                                                        s.Add("Gadgets");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("Switches");
                                                        s.Add("Switches");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Chargers");
                                                        s.Add("Chargers");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Resistors");
                                                        s.Add("Resistors");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Exit");
                                                        break;

                                                }
                                                Console.WriteLine("Total cost of products is 50678");
                                            }
                                        } while (choice8 != 5);
                                        break;
                                    case 9:
                                        s.Add("Kitchen Products");
                                        Console.WriteLine("---------------Categories of Kitchen Products---------------");
                                        Console.WriteLine("\n 1.Pressure cookers\n 2.Stoves \n 3.Flasks \n 4.Tableware  \n 5.Bar&Glassware \n 6.Containers \n 7.Exit");
                                        //Switch Case statement to select the categories of Grocery products
                                        int choice9 = 1;
                                        do
                                        {
                                            bool b = int.TryParse(Console.ReadLine(), out choice9);
                                            if (b == true)
                                            {
                                                switch (choice9)
                                                {
                                                    case 1:
                                                        Console.WriteLine("Pressure cooker");
                                                        s.Add("Pressure cooker");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 2:
                                                        Console.WriteLine("Stoves&Chimney");
                                                        s.Add("Stoves&Chimney");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 3:
                                                        Console.WriteLine("Flasks");
                                                        s.Add("Flasks");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 4:
                                                        Console.WriteLine("Tableware");
                                                        s.Add("Tableware");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 5:
                                                        Console.WriteLine("Bar&Glassware");
                                                        s.Add("Bar&Glassware");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 6:
                                                        Console.WriteLine("Containers");
                                                        s.Add("Containers");
                                                        AddQuantityOfProducts();
                                                        break;
                                                    case 7:
                                                        Console.WriteLine("Exit");
                                                        break;
                                                }
                                            }
                                        } while (choice9 != 7);
                                        break;
                                }
                            }
                        } while (ch != 10);

                        Console.WriteLine("--------------------------------------------------------------");
                    }
                    catch (RetailstoreException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                /// <summary>
                /// GetProducts method represents get the products from the lsit
                /// </summary>
                public static void GetRProducts()
                {
                    RetailProductsBusinessLogicLayer rp = new RetailProductsBusinessLogicLayer();
                    List<RProducts> retailerProductsList = rp.GetRProducts();
                    Console.WriteLine("----Products in List---------");
                    Console.WriteLine("Products");
                    foreach (RProducts item in retailerProductsList)
                    {
                        Console.WriteLine(item.RetailProducts + " " + item.ProductID);
                    }
                }
                /// <summary>
                /// Removeproduct method which removes the products from the list if ProductId doesnot match
                /// </summary>
                public static void RemoveProduct()
                {
                    //creating the object for Product details class
                    RProducts p = new RProducts();
                    RetailProductsBusinessLogicLayer rp = new RetailProductsBusinessLogicLayer();
                    Console.WriteLine("Enter the productID to be deleted");
                    string productID = Console.ReadLine();
                    if (rp.CheckProductID(productID) != true)
                    {
                        p.RemoveProduct(productID);
                        Console.WriteLine("Product id does not exists ");
                    }
                    else
                    {
                        throw new RetailstoreException();
                    }

                }
                /// <summary>
                /// GetProductBYID is a static method represents the details of products presents in the list
                /// </summary>
                public static void GetProductsByID()
                {
                    //RProducts p = new RProducts();
                    RetailProductsBusinessLogicLayer rp = new RetailProductsBusinessLogicLayer();
                    Console.WriteLine("enter productID");
                    string productID = Console.ReadLine();
                    if (rp.CheckProductID(productID))
                    {
                        RProducts r = rp.GetProductsByID(productID);
                        Console.WriteLine(r.ProductID + " " + r.RetailProducts);

                    }
                    else
                    {
                        throw new RetailstoreException("ProductId does not exists");
                    }


                }
                /// <summary>
                /// Update products method represents based on ProductId we can change the products
                /// </summary>
                public static void UpdateProducts()
                {
                    RProducts p = new RProducts();
                    RetailProductsBusinessLogicLayer rp = new RetailProductsBusinessLogicLayer();
                    Console.WriteLine("1.Replace product");
                    Console.WriteLine("Enter Existing ProductID to replace the product");
                    p.ProductID = Console.ReadLine();
                    if (rp.CheckProductID(p.ProductID))
                    {
                        Console.WriteLine("Enter name of product to replace it");
                        if (ValidateRetailProducts(p.RetailProducts))
                        {
                            rp.UpdateProducts(p);
                            Console.WriteLine("Products are updated!!!");
                        }
                        else
                        {
                            throw new RetailstoreException("Please check Product name!");
                        }
                    }
                    else
                    {
                        throw new RetailstoreException("Products are updated");
                    }

                }
                private static bool ValidateRetailProducts(List<string> retailProducts)
                {
                    throw new NotImplementedException();
                }

                /// <summary>
                /// Add quantity represents that customer has to add the products the based on his choice
                /// </summary>
                public static void AddQuantityOfProducts()
                {

                    RProducts p = new RProducts();
                    RetailProductsBusinessLogicLayer rp = new RetailProductsBusinessLogicLayer();
                    Console.WriteLine("Enter the quantity of products:");
                    p.QuantityOfProducts = int.Parse(Console.ReadLine());
                    Console.WriteLine("The quantity of product is:" + p.QuantityOfProducts);
                    rp.AddQuantityOfProducts(p);

                    //p.Cost = double.Parse(Console.ReadLine());
                    Console.WriteLine("TOTAL COST IS:" + p.Cost * p.QuantityOfProducts);
                    
                }
                public static void SuppliersForTransporting()
                {
                    RProducts p = new RProducts();
                    Console.WriteLine("================ Suppliers For Transporting================");
                    Console.WriteLine("Enter true for if you want suppliers else enter false");
                    //the customer has enter he want suppliers or not if he want suppliers here we are checking the condition of if-else statement.
                    bool k = true;
                    bool s = bool.Parse(Console.ReadLine());
                    if (s == true)
                    {
                        Console.WriteLine("Yes I want suppliers" + p.Suppliers);
                    }
                    else
                    {
                        k = false;
                        Console.WriteLine("No");
                    }
                    Console.WriteLine("--------------------------------------------------------------");
                    System.Console.WriteLine("----------------------------------------------------\n| :) THANK YOU FOR CHOOSING OUR RETAIL STORE (: |\n----------------------------------------------------\n");
                    Console.ReadKey();
                }
                /// <summary>
                /// Checking the product ID
                /// </summary>
                /// <param name="productID"></param>
                 public bool CheckProductID(string productID)
                 {
                     RetailProductsBusinessLogicLayer rp = new RetailProductsBusinessLogicLayer();
                     bool res = rp.CheckProductID(productID);
                     if (res == true)
                     {
                         Console.WriteLine("Product ID Exists");
                         return res;
                     }
                     return res;
                 }*/



 