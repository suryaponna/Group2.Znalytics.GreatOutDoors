using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.PresentationLayer

{
    public class ProductPresentationLayer
    {
        public static void Main()
        {

            //creating object for productcategories
            Product p;
            p = new Product();
            ProductBusinessLayer ProductBusinessLayer = new ProductBusinessLayer();

            Console.WriteLine("----------------------------WELCOME TO ZNALYTICS STORE----------------------------");

            //Product id
            Console.WriteLine("Enter The Product Id");
            p.ProductID = Console.ReadLine();
            Console.WriteLine("The product Id is:" + p.ProductID);
            //product name has to enter
            Console.WriteLine("Enter ProductName");
            p.ProductName = Console.ReadLine();
            Console.WriteLine("product name is:" + p.ProductName);


            //choice the option which you want to select
            System.Console.WriteLine("================Select the choice================");
            System.Console.WriteLine("Enter 1 for Personal accessories");
            System.Console.WriteLine("Enter 2 for camping equipment ");
            System.Console.WriteLine("Enter 3 for golf eqiupment");
            System.Console.WriteLine("Enter 4 for mountaineering eqiupment");
            System.Console.WriteLine("Enter 5 for outdoor protection");
            int Choice = int.Parse(Console.ReadLine());
            //Switch case for selecting the choice for product
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Personal Accessories");
                    p.Product = "Personal Accessories";
                    break;
                case 2:
                    Console.WriteLine("Camping Equipment");
                    p.Product = "Camping Equipment";
                    break;
                case 3:
                    Console.WriteLine("Golf Equipment");
                    p.Product = "Golf Equipment";
                    break;
                case 4:
                    Console.WriteLine("Mountaineering Equipment");
                    p.Product = "Mountaineering equipment";
                    break;
                case 5:
                    Console.WriteLine("OutDoor Protection");
                    p.Product = "Outdoor Protection";
                    break;
                default:
                    Console.WriteLine("Unknown choice");
                    break;
            }
            Console.WriteLine("Selected product categories are:" + p.product);
            Console.WriteLine("--------------------------------------------------------------");


            //Catagories of Products in retail store
            Console.WriteLine("------------------------------Types of product and their categories ,cost ranges from------------------------------");

            System.Console.WriteLine("Enter 1. for Personal Accessories and cost range is  1500-3499");
            System.Console.WriteLine("Enter 2. for Camping equipment and cost range is  500-4000");
            System.Console.WriteLine("Enter 3. for Golf equipment and cost range is  1500-5000");
            System.Console.WriteLine("Enter 4. for Mountaineering Equipment and  cost range is  500-2000");
            System.Console.WriteLine("Enter 5. for Outdoor Protection and cost range is  100-5000");
            System.Console.WriteLine("Enter more than 6. to exit");
            int ch = 1;
            do
            {
                bool a = int.TryParse(Console.ReadLine(), out ch);
                if (a == true)
                {
                    switch (ch)
                    {
                        case 1:
                            Console.WriteLine("Personal Accessories");
                            p.Products = "PersonalAccessories";
                            //categories  of Personal accessories
                            Console.WriteLine("----------Categories of personal accessories-----------");
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
                            } while (choice2 != 5);
                            break;

                        case 2:
                            r.RetailProducts = "Camping Euipment";
                            Console.WriteLine("--------Catagories of Camping Equipment---------");
                            Console.WriteLine("\n 1.Iron Box \n 2.Water Purifiers \n 3.Air Purifiers \n 4.Refridgerators \n 5.Washing Machines \n 6.Exit");

                            //Switch Case statement to select the catagorie of camping
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
                            } while (choice3 != 4);
                            break;
                        case 3:
                            r.RetailProducts = "Golf Equipment";
                            //Choice of choosing Catagories of Golf Equipment
                            Console.WriteLine("---------------Catagories of golf equipment---------------");
                            Console.WriteLine("\n 1.Beverages \n 2.Dairy products \n 3.Frozen foods\n 4.Meat" +
                                " \n 5.Cleaner products \n 6.Vegetables \n 7.Exit");

                            //Switch Case statement to select the catagories of Golf euipment
                            int choice3 = 2;
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
                            } while (choice3 != 4);
                            break;
                        case 4:
                            r.RetailProducts = " Mountaineering Equipment";
                            //Choice of choosing Catagories of Mountaineering Equipment
                            Console.WriteLine("---------------Catagories of Mountainering euipment---------------");
                            Console.WriteLine("\n 1.Surgical Products\n 2.First Aid kit\n 3.Dialysis Machine\n 4.All types medical drugs" +
                                " \n 5.Exit");
                            //Switch Case statement to select the catagories of Mountaineering equipment
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
                            p.Product = "Outdoor Protection";
                            Console.WriteLine("---------------Categories of Outdoor Protection---------------");
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
                            }
                            break;
                    }
                }
            } while (ch != 6);
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
            System.Console.WriteLine("----------------------------------------------------\n| :) THANK YOU FOR CHOOSING THE PRODUCTS (: |\n----------------------------------------------------\n");
            Console.ReadKey();
        }
        /// <summary>
        /// Method to add quantity of products
        /// </summary>
        public static void AddProductQuantity()
        {

            Product p = new Product();
            ProductBusinessLogicLayer pbll = new ProductBusinessLogicLayer();
            Console.WriteLine("Enter the quantity of products:");
            p.QuantityOfProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("The quantity of product is:" + p.QuantityOfProducts);
            pdl.AddProductQuantity();

        }
        public static void GetProductQuantity()
        {

            Product p = new Product();
            ProductBusinessLogicLayer pbll = new ProductBusinessLogicLayer();
            rdl.GetProductQuantity();
            List<Product> p = pdl.GetProductQuantity();
            foreach (Retailstore item in rs)
            {
                Console.WriteLine("get the details of  quantity of products");
                Console.WriteLine(item.QuantityOfProducts);
            }

        }
    }
}
