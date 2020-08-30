//---------Archana

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.PresentationLayer

{
    public class RetailStorePresentation
    {
        public static void Main()
        {

            //creating object for Retailstore
            Retailstore r;
            r = new Retailstore();
            //
            RetailStoreBusinessLogicLayer retailStoreBusinessLogic = new RetailStoreBusinessLogicLayer();

            Console.WriteLine("----------------------------WELCOME TO ZNALYTICS RETAIL STORE----------------------------");

            //retail id
            Console.WriteLine("Enter The Retail store Id");
            r.RetailStoreID = Console.ReadLine();
            Console.WriteLine("The retail store Id is:" + r.RetailStoreID);
            //customer name has to enter
            Console.WriteLine("Enter Customer Name");
            r.CustomerName = Console.ReadLine();
            Console.WriteLine("customer name is:" + r.CustomerName);


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
            Console.WriteLine("--------------------------------------------------------------");


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
                            r.RetailProducts = "Books";
                            //categories  of Books
                            Console.WriteLine("----------Categories of BOOKS-----------");
                            Console.WriteLine("\n 1.Comic \n 2.Aptitude \n 3.Historical Fiction \n 4.Educational Books" +
                           "\n 5.Literary Fiction \n 6.Dective and Mystery \n 7.Exit");
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
                                            r.RetailProducts = "Comic Books";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Aptitude Books");
                                            r.RetailProducts = "Aptitude ";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Historical Fiction");
                                            r.RetailProducts = "Historical Fiction";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Educational Books");
                                            r.RetailProducts = "Educational Books";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Literary Fiction");
                                            r.RetailProducts = "Literary Fiction";
                                            AddProductQuantity();
                                            break;
                                        case 6:
                                            Console.WriteLine("Dective and Mystery");
                                            r.RetailProducts = "Dective and Mystery";
                                            AddProductQuantity();
                                            break;
                                        default:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice1 != 7);
                            break;

                        case 2:
                            r.RetailProducts = "Electrical Appliances";
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
                                            r.RetailProducts = "Iron Box";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Water Purifiers");
                                            r.RetailProducts = "Water Purifiers";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Air Purifiers");
                                            r.RetailProducts = "Air Purifiers";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Refridgerators");
                                            r.RetailProducts = "Refridgerators";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Washing Machines");
                                            r.RetailProducts = "Washing Machines";
                                            AddProductQuantity();
                                            break;
                                        default:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice2 != 6);
                            break;
                        case 3:
                            r.RetailProducts = "Grocery products";
                            //Choice of choosing Catagories of Grocery products 
                            Console.WriteLine("---------------Catagories of Grocery products---------------");
                            Console.WriteLine("\n 1.Beverages \n 2.Dairy products \n 3.Frozen foods\n 4.Meat" +
                                " \n 5.Cleaner products \n 6.Vegetables \n 7.Exit");

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
                                            r.RetailProducts = "Beverages";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Dairy products");
                                            r.RetailProducts = "Dairy products";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Frozen foods");
                                            r.RetailProducts = "Frozen foods";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Meat");
                                            r.RetailProducts = "Meat";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Cleaner products");
                                            r.RetailProducts = "Cleaner products";
                                            AddProductQuantity();
                                            break;
                                        case 6:
                                            Console.WriteLine("Vegeatables");
                                            r.RetailProducts = "Vegeatables";
                                            AddProductQuantity();
                                            break;
                                        case 7:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice3 != 7);
                            break;
                        case 4:
                            r.RetailProducts = " Medical Products";
                            //Choice of choosing Catagories of Medical Products
                            Console.WriteLine("---------------Catagories of Medical Products---------------");
                            Console.WriteLine("\n 1.Surgical Products\n 2.First Aid kit\n 3.Dialysis Machine\n 4.All types medical drugs" +
                                " \n 5.Exit");
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
                                            r.RetailProducts = "Surgical Products";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("First Aid kit");
                                            r.RetailProducts = "First Aid kit";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Dialysis Machine");
                                            r.RetailProducts = "Dialysis Machine";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("All types medical drugs");
                                            r.RetailProducts = "All types medical drugs";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice4 != 5);
                            break;
                        case 5:
                            r.RetailProducts = "Fashion products";
                            Console.WriteLine("---------------Categories of Fahion Products---------------");
                            Console.WriteLine("\n 1.FootWear  \n 2.Sportswear \n 3.Traditioal \n 4.Accessories " +
                                " \n 5.Jewelry \n 6.Watches \n 7.Formal Wear \n 8.Exit");
                            //Switch Case statement to select the catagories of Fashion products
                            int choice5 = 1;
                            do
                            {
                                bool b = int.TryParse(Console.ReadLine(), out choice3);
                                if (b == true)
                                {
                                    switch (choice3)
                                    {
                                        case 1:
                                            Console.WriteLine("Footwear");
                                            r.RetailProducts = "Footwear";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Sportswear");
                                            r.RetailProducts = "Sportswear";
                                            AddProductQuantity();
                                            r.Cost = 3060;
                                            break;
                                        case 3:
                                            Console.WriteLine("Traditional wear");
                                            r.RetailProducts = "Traditional wear";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Accessories");
                                            r.RetailProducts = "Accessories";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Watches");
                                            r.RetailProducts = "Watches";
                                            AddProductQuantity();
                                            break;
                                        case 6:
                                            Console.WriteLine("Jewelry");
                                            r.RetailProducts = "Jewelry";
                                            AddProductQuantity();
                                            break;
                                        case 7:
                                            Console.WriteLine("Formal Wear");
                                            r.RetailProducts = "Formal Wear";
                                            AddProductQuantity();
                                            break;
                                        case 8:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice3 != 8);
                            break;
                        case 6:
                            r.RetailProducts = "Fitness products";
                            Console.WriteLine("---------------Categories of Fahion Products---------------");
                            Console.WriteLine("\n 1.Treadmills \n 2.Skipping ropes \n 3.Dumbbell \n 4.Yoga Mats " +
                                " \n 5.Exit");

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
                                            r.RetailProducts = "Treadmills";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Skipping ropes");
                                            r.RetailProducts = "Skipping ropes";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Dumbbells");
                                            r.RetailProducts = "Dumbbells";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Yoga Mats");
                                            r.RetailProducts = "Yoga Mats";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice6 != 5);
                            break;
                        case 7:
                            r.RetailProducts = "Industrial products";
                            Console.WriteLine("---------------Categories of Fahion Products---------------");
                            Console.WriteLine("\n 1.Power Generators \n 2.Radiators \n 3.Lubricants \n 4.Raw Materials " +
                                " \n 5.Component Material \n 6.Manufactured Products \n 7.Exit");
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
                                            r.RetailProducts = "Power Generators";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Radiators");
                                            r.RetailProducts = "Radiators";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Lubricants");
                                            r.RetailProducts = "Lubricants";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Raw Material");
                                            r.RetailProducts = "Raw Material";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Component Material");
                                            r.RetailProducts = "Component Material";
                                            AddProductQuantity();
                                            break;
                                        case 6:
                                            Console.WriteLine("Manufactured Products");
                                            r.RetailProducts = "Manufactured Products ";
                                            AddProductQuantity();
                                            break;
                                        case 7:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice7 != 7);
                            break;
                        case 8:
                            r.RetailProducts = System.Console.ReadLine();
                            r.RetailProducts = "Eletronical devices";
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
                                            r.RetailProducts = "Gadgets";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Switches");
                                            r.RetailProducts = "Switches";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Chargers");
                                            r.RetailProducts = "Chargers";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Resistors");
                                            r.RetailProducts = "Resistors";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Exit");
                                            break;

                                    }
                                }
                            } while (choice8 != 5);
                            break;
                        case 9:
                            r.RetailProducts = System.Console.ReadLine();
                            r.RetailProducts = "Kitchen Products";
                            Console.WriteLine("---------------Categories of Kitchen Products---------------");
                            Console.WriteLine("\n 1.Pressure cookers\n 2.Stoves \n 3.Flasks \n 4.Tableware " +
                                " \n 5.Bar&Glassware \n 6.Containers \n 7.Exit");
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
                                            r.RetailProducts = "Pressure cooker";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Stoves&Chimney");
                                            r.RetailProducts = "Stoves&Chimney";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Flasks");
                                            r.RetailProducts = "Flasks";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Tableware");
                                            r.RetailProducts = "Tableware";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Bar&Glassware");
                                            r.RetailProducts = "Bar&Glassware";
                                            AddProductQuantity();
                                            break;
                                        case 6:
                                            Console.WriteLine("Containers");
                                            r.RetailProducts = "Containers";
                                            AddProductQuantity();
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
            // Suppliers for transporting
            Console.WriteLine("================ Suppliers For Transporting================");
            Console.WriteLine("Enter true for if you want suppliers else enter false");
            //the customer has enter he want suppliers or not if he want suppliers here we are checking the condition of if-else statement.
            bool k = true;
            bool s = bool.Parse(Console.ReadLine());
            if (s == true)
            {
                Console.WriteLine("Yes I want suppliers" + r.Suppliers);
            }
            else
            {
                k = false;
                Console.WriteLine("No i doesn't want suppliers");
            }
            Console.WriteLine("--------------------------------------------------------------");

            //Outlier Products
            Console.WriteLine("================ Damaged Products ================");


            System.Console.WriteLine("----------------------------------------------------\n| :) THANK YOU FOR CHOOSING OUR RETAIL STORE (: |\n----------------------------------------------------\n");
            Console.ReadKey();
        }
        /// <summary>
        /// Method t add quantity of products
        /// </summary>
        public static void AddProductQuantity()
        {
           
                 Retailstore r = new Retailstore();
                RetailStoreBusinessLogicLayer rdl = new RetailStoreBusinessLogicLayer();
                Console.WriteLine("Enter the quantity of products:");
                r.QuantityOfProducts = int.Parse(Console.ReadLine());
                Console.WriteLine("The quantity of product is:" + r.QuantityOfProducts);
                 rdl.AddProductQuantity();
        
        }
         public static void GetProductQuantity()
         {
            Retailstore r = new Retailstore();
             RetailStoreBusinessLogicLayer rdl = new RetailStoreBusinessLogicLayer();
            rdl.GetProductQuantity();
            List<Retailstore> rs = rdl.GetProductQuantity();
            foreach(Retailstore item in rs)
            {
                Console.WriteLine("get the details of  quantity of products");
                Console.WriteLine(item.QuantityOfProducts);
            }

        }
    }
}

