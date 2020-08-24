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

            // public static void ReturnsPresentationLogic()

            Return rm;
            rm = new Return();

            

            int choice;
            System.Console.WriteLine("Select your reason for returning");
            System.Console.WriteLine("______________________");
            System.Console.WriteLine("1. Unsatisfactory Product");
            System.Console.WriteLine("2. Defective Product");
            System.Console.WriteLine("3. Incomplete Product");
            System.Console.WriteLine("4. Wrong Product Ordered");
            System.Console.WriteLine("5. Wrong Product Shipped");

            System.Console.WriteLine(" Enter your Choice for returning the product");
            choice = System.Convert.ToInt32(System.Console.ReadLine());
            //switch case to select reasons for returning the product
            switch (choice)
            {
                case 1:
                    System.Console.WriteLine(" Unsatisfactory Product");
                    break;
                case 2:
                    System.Console.WriteLine("Defective Product");
                    break;
                case 3:
                    System.Console.WriteLine("Incomplete Product");
                    break;
                case 4:
                    System.Console.WriteLine("Wrong Product Ordered");
                    break;
                case 5:
                    System.Console.WriteLine(" Wrong Product Shipped");
                    break;
            }


            System.Console.WriteLine("Enter ProductID");
            rm.ProductID = (System.Console.ReadLine());
            System.Console.WriteLine(rm.ProductID);

            System.Console.WriteLine("Enter ProductName");
            rm.ProductName = System.Console.ReadLine();
            System.Console.WriteLine(rm.ProductName);

            System.Console.WriteLine("Enter ProductDate");
            rm.Productdate = (System.Console.ReadLine());
            System.Console.WriteLine(rm.Productdate);

            System.Console.WriteLine("Enter ProductQuantity");
            rm.ProductQuantity = (System.Convert.ToInt32(System.Console.ReadLine()));
            System.Console.WriteLine(rm.ProductQuantity);

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
           

            void AddReturn()
            {
                ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
                

                Console.Write("Enter new Product Name: ");
                rm.ProductName = Console.ReadLine();

                rbl.AddReturn(rm);
                Console.WriteLine("Product  Added");

            }
            void GetReturnByProductID()
            {
                ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
                rbl.GetReturnByProductID();
            }

            

           void GetReturns()
            {
                ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
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
}

