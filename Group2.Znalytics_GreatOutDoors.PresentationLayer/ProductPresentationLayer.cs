using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using GreatOutdoorsProduct.Entities;
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
                            p.Product = "PersonalAccessories";
                            //categories  of Personal accessories
                            Console.WriteLine("----------Categories of personal accessories-----------");
                            Console.WriteLine("\n 1.jackets \n 2.cravats \n 3.ties \n 4.hats" +
                           "\n 5.boots and shoes  \n  6.Exit");
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
                                            Console.WriteLine("jackets");
                                            p.Product = "jackets";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("cravats");
                                            p.Product = "cravats ";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("ties");
                                            p.Product = "ties";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("hats");
                                            p.Product = "hats";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("boots and shoes");
                                            p.Product = "boots and shoes";
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
                            p.Product = "Camping Euipment";
                            Console.WriteLine("--------Catagories of Camping Equipment---------");
                            Console.WriteLine("\n 1.Tent  \n 2.Sleeping bags \n 3.Camping pillow \n 4.Headlamps \n 5.Camp table \n 6.Exit");

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
                                            Console.WriteLine("Tent");
                                            p.Product = "Tent";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("sleeping bags");
                                            p.Product = "sleeping bags";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("camping pillow");
                                            p.Product = "camping pillow";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("headlamps");
                                            p.Product = "headlamps";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("camp table");
                                            p.Product = "camp table";
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
                            p.Product = "Golf Equipment";
                            //Choice of choosing Catagories of Golf Equipment
                            Console.WriteLine("---------------Catagories of golf equipment---------------");
                            Console.WriteLine("\n 1.Balls \n 2.Golf clubs \n 3.Ball markers\n 4.Tees" +
                                " \n 5.Golf bag \n 6.Exit");

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
                                            Console.WriteLine("Balls");
                                            p.Product = "Balls";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Golf clubs");
                                            p.Product = "Golf clubs";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Ball markers");
                                            p.Product = "Ball markers";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Tees");
                                            p.Product = "Tees";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Golf bag");
                                            p.Product = "Golf bag";
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
                            p.Product = " Mountaineering Equipment";
                            //Choice of choosing Catagories of Mountaineering Equipment
                            Console.WriteLine("---------------Catagories of Mountainering euipment---------------");
                            Console.WriteLine("\n 1.Climbing pack\n 2.Rope\n 3.Helmet\n 4.Crampons" +
                                " \n 5.Ice axe \n 6.Exit");
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
                                            Console.WriteLine("Climbing pack");
                                            p.Product = "Climbing pack";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Rope");
                                            p.Product = "Rope";
                                            AddProductQuantity();
                                            break;
                                        case 3:
                                            Console.WriteLine("Helmet");
                                            p.Product = "Helmet";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Crampons");
                                            p.Product = "Crampons";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Ice axe");
                                            p.Product = "Ice axe";
                                            AddProductQuantity();
                                            break;
                                        case 6:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice4 != 5);
                            break;
                        case 5:
                            p.Product = "Outdoor Protection";
                            Console.WriteLine("---------------Categories of Outdoor Protection---------------");
                            Console.WriteLine("\n 1.Mask  \n 2.solar powered light \n 3.Traditioal \n 4.Accessories " +
                                " \n 5.Jewelry \n 6.Watches \n 7.Formal Wear \n 8.Exit");
                            //Switch Case statement to select the catagories of outdoor protection
                            int choice5 = 1;
                            do
                            {
                                bool b = int.TryParse(Console.ReadLine(), out choice3);
                                if (b == true)
                                {
                                    switch (choice3)
                                    {
                                        case 1:
                                            Console.WriteLine("Mask");
                                            p.Product = "Mask";
                                            AddProductQuantity();
                                            break;
                                        case 2:
                                            Console.WriteLine("Sportswear");
                                            p.Product = "Sportswear";
                                            AddProductQuantity();
                                            //r.Cost = 3060;
                                            break;
                                        case 3:
                                            Console.WriteLine("Traditional wear");
                                            p.Product = "Traditional wear";
                                            AddProductQuantity();
                                            break;
                                        case 4:
                                            Console.WriteLine("Accessories");
                                            p.Product = "Accessories";
                                            AddProductQuantity();
                                            break;
                                        case 5:
                                            Console.WriteLine("Watches");
                                            p.Product = "Watches";
                                            AddProductQuantity();
                                            break;
                                        case 6:
                                            Console.WriteLine("Jewelry");
                                            p.Product = "Jewelry";
                                            AddProductQuantity();
                                            break;
                                        case 7:
                                            Console.WriteLine("Formal Wear");
                                            p.Product = "Formal Wear";
                                            AddProductQuantity();
                                            break;
                                        case 8:
                                            Console.WriteLine("Exit");
                                            break;
                                    }
                                }
                            } while (choice5 != 5);
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
            ProductBusinessLayer pbl = new ProductBusinessLayer();
            Console.WriteLine("Enter the quantity of products:");
            p.QuantityOfProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("The quantity of product is:" + p.QuantityOfProducts);
            pdl.AddProductQuantity();

        }
        public static void GetProductQuantity()
        {

            Product p = new Product();
            ProductBusinessLogicLayer pbll = new ProductBusinessLogicLayer();
            pdl.GetProductQuantity();
            List<Product> p = pdl.GetProductQuantity();
            foreach (Retailstore item in rs)
            {
                Console.WriteLine("get the details of  quantity of products");
                Console.WriteLine(item.QuantityOfProducts);
            }

        }
    }
}
