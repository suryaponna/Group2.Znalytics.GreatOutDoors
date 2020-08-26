//created by K.Prasanna
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreetOutDoors.EntityLayer;
namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class ReturnsPresentation
    {
        static void Main()
        {

            ReturnPresentation();
            Console.ReadKey();
            
        }
        static void ReturnPresentation()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Return and Exchange Module");
                Console.WriteLine("1.ReturnProduct");
                Console.WriteLine("2.ExchangeProduct");
                Console.WriteLine("3.Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: ReturnProduct(); break;
                    case 2: ExchangeProduct(); break;

                }
            } while (choice != 4);
            }
        static void ReturnProduct()
        {
            Return rm = new Return();

            int ch;
            System.Console.WriteLine("Select your reason for returning");
            System.Console.WriteLine("______________________");
            System.Console.WriteLine("01. Unsatisfactory Product");
            System.Console.WriteLine("02. Defective Product");
            System.Console.WriteLine("03. Incomplete Product");
            System.Console.WriteLine("04. Wrong Product Ordered");
            System.Console.WriteLine("05. Wrong Product Shipped");

            System.Console.WriteLine(" Enter your Choice for returning the product");
            ch = System.Convert.ToInt32(System.Console.ReadLine());
            //switch case to select reasons for returning the product
            switch (ch)
            {
                case 01:
                    System.Console.WriteLine(" Unsatisfactory Product");
                    break;
                case 02:
                    System.Console.WriteLine("Defective Product");
                    break;
                case 03:
                    System.Console.WriteLine("Incomplete Product");
                    break;
                case 04:
                    System.Console.WriteLine("Wrong Product Ordered");
                    break;
                case 05:
                    System.Console.WriteLine(" Wrong Product Shipped");
                    break;
            }


            System.Console.WriteLine("Enter ProductID");
            rm.ProductID = System.Convert.ToInt32(System.Console.ReadLine());
           

            System.Console.WriteLine("Enter ProductName");
            rm.ProductName = System.Console.ReadLine();
           

            System.Console.WriteLine("Enter ProductDate");
            rm.Productdate = (System.Console.ReadLine());
            
            System.Console.WriteLine("Enter ProductQuantity");
            rm.ProductQuantity = (System.Convert.ToInt32(System.Console.ReadLine()));
            

            System.Console.WriteLine("Enter the type of product you want to return");
            // Select the producttype 
            System.Console.WriteLine("******choice of choosing types of products******");
            System.Console.WriteLine("Enter 6 for Electrical Appliances");
            System.Console.WriteLine("Enter 7 for Grocery products");
            System.Console.WriteLine("Enter 8 for Medicines");
            System.Console.WriteLine("Enter 9 for Fashion products");
            System.Console.WriteLine("Enter 10 for Fitness products");
            System.Console.WriteLine("Enter 11 for Industrial products");
            int b = int.Parse(System.Console.ReadLine());
            //switch case for choosing producttype
            switch (b)
            {
                case 6:
                    rm.Producttype = System.Console.ReadLine();
                    rm.Producttype = "Electrical Appliances";
                    break;
                case 7:
                    rm.Producttype = System.Console.ReadLine();
                    rm.Producttype = "Grocery products";
                    break;
                case 8:
                    rm.Producttype = System.Console.ReadLine();
                    rm.Producttype = " Medicical Products";
                    break;
                case 9:
                    rm.Producttype = System.Console.ReadLine();
                    rm.Producttype = "Fashion products";
                    break;
                case 10:
                    rm.Producttype = System.Console.ReadLine();
                    rm.Producttype = "Fitness products";
                    break;
                case 11:
                    rm.Producttype = System.Console.ReadLine();
                    rm.Producttype = "Industrial products";
                    break;
                case 12:
                    rm.Producttype = System.Console.ReadLine();
                    rm.Producttype = "Electronical devices";
                    break;
                case 13:
                    rm.Producttype = System.Console.ReadLine();
                    rm.Producttype = "Kitchen products";

                    break;
            }

            System.Console.WriteLine(rm.Producttype);
        }
        static void ExchangeProduct()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            Console.WriteLine("Enter the product you want to Exchange");
            rm.ProductName=Console.ReadLine();
            Console.WriteLine("Enter with which product you want to exchange");
           rm.ProductName= Console.ReadLine();

        }

            void AddReturn()
            {
                ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();

            Console.Write("Enter new Product Name: ");
                rm.ProductName = Console.ReadLine();

                rbl.AddReturn(rm);
                Console.WriteLine("Product  Added");

            }
            void GetReturnByProductID(int Id)
            {
                ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
                Return rm = new Return();
            rbl.GetReturnByProductID(Id);
            }
        void RemoveReturnByProductID()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            System.Console.Write("Enter the ProductID to be Deleted:");
            int id = int.Parse(System.Console.ReadLine());

            rbl.RemoveReturnByProductID(id);
            System.Console.WriteLine("ProductID Removed");


        }
        void RemoveReturnByProductName()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            System.Console.Write("Enter the ProductName:");
            string name = System.Console.ReadLine();

            rbl.RemoveReturnByProductName(name);
            System.Console.WriteLine("Product Removed");
        }



        void GetReturns()
            {
                ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
                Return rm = new Return();
             rbl.GetReturns();

                List<Return> rets = rbl.GetReturns();
                //Displays all the details 
                System.Console.WriteLine("--------------- Detils are --------------");
                System.Console.WriteLine("Product Id: " + rm.ProductID);
                System.Console.WriteLine("Product Name: " + rm.ProductName);
                System.Console.WriteLine("Product date is: " + rm.Productdate);
                System.Console.WriteLine("Product Quantity is: " + rm.ProductQuantity);
                System.Console.WriteLine("Product type is: " + rm.Producttype);
                System.Console.WriteLine("ThankYou for your Response");
                System.Console.ReadKey();

            }

        

    }
}

