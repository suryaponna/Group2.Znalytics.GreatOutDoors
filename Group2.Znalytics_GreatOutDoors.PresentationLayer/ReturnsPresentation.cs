//created by K.Prasanna
/**using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System.Reflection.Emit;

/// <summary>
/// This is the Main method for the project
/// </summary>

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class ReturnsPresentation
    {
       
        static void ReturnPresentation()
        {
            int choice = 0;
            do
            {
                // Small menu for Return and Exchange module
                Console.WriteLine("!!!!!!!!!Return and Exchange Module!!!!!!!!");
                Console.WriteLine("1.ReturnProduct");
                Console.WriteLine("2.ExchangeProduct");
                Console.WriteLine("3.AddReturns");
                Console.WriteLine("4.RemoveReturnByProductID");
                Console.WriteLine("5.RemoveReturnByProductName");
                Console.WriteLine("6.GetReturns");
                Console.WriteLine("7.GetReturnByProductName");
                Console.WriteLine("8.GetReturnByProductID");
                Console.WriteLine("9.Update Return");
                Console.WriteLine("10.Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: ReturnProduct(); break;
                    case 2: ExchangeProduct(); break;
                    case 3: AddReturn(); break;
                    case 4: RemoveReturnByProductID(); break;
                    case 5: RemoveReturnByProductName(); break;
                    case 6: GetReturns(); break;
                    case 7: GetReturnByProductName();break;
                    case 8: GetReturnByProductID(); break;
                    case 9: UpdateReturn(); break;
                    case 10: Exit(); break;
                }
            } while (choice != 11);
        }
        // Method for Return Product
        static void ReturnProduct()
        {
            Return rm = new Return();

            int ch;
            // Reasons for Returning a product
            Console.WriteLine("-----Select your reason for returning or Exchanging-----");
            Console.WriteLine("______________________");
            Console.WriteLine("01. Unsatisfactory Product");
            Console.WriteLine("02. Defective Product");
            Console.WriteLine("03. Incomplete Product");
            Console.WriteLine("04. Wrong Product Ordered");
            Console.WriteLine("05. Wrong Product Shipped");

            Console.WriteLine(" ----Enter your Choice for returning the product----");
            ch = Convert.ToInt32(Console.ReadLine());
            //switch case to select reasons for returning the product
            switch (ch)
            {
                case 1:
                    Console.WriteLine(" Unsatisfactory Product");
                    break;
                case 2:
                    Console.WriteLine("Defective Product");
                    break;
                case 3:
                    Console.WriteLine("Incomplete Product");
                    break;
                case 4:
                    Console.WriteLine("Wrong Product Ordered");
                    break;
                case 5:
                    Console.WriteLine(" Wrong Product Shipped");
                    break;
            }


            Console.WriteLine("Enter ProductID");
            rm.ProductID = (Console.ReadLine());


           Console.WriteLine("Enter ProductName");
            rm.ProductName = Console.ReadLine();


            Console.WriteLine("Enter ProductDate");
            rm.Productdate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter ProductQuantity");
            rm.ProductQuantity = (Convert.ToInt32(Console.ReadLine()));


            Console.WriteLine("Enter the type of product you want to return");
            //  Different types of Products 
            Console.WriteLine("******choice of choosing types of products******");
            Console.WriteLine("Enter 1 for Electrical Appliances");
            Console.WriteLine("Enter 2 for Grocery products");
            Console.WriteLine("Enter 3 for Medical products");
            Console.WriteLine("Enter 4 for Fashion products");
            Console.WriteLine("Enter 5 for Fitness products");
            Console.WriteLine("Enter 6 for Industrial products");
            Console.WriteLine("Enter 7 for Electronical devices");
            Console.WriteLine("Enter 8 for Kitchen Products");
            int b = int.Parse(Console.ReadLine());
            //switch case for choosing producttype
            switch (b)
            {
                case 1:
                    rm.Producttype = Console.ReadLine();
                    rm.Producttype = "Electrical Appliances";
                    break;
                case 2:
                    rm.Producttype = Console.ReadLine();
                    rm.Producttype = "Grocery products";
                    break;
                case 3:
                    rm.Producttype = Console.ReadLine();
                    rm.Producttype = " Medical Products";
                    break;
                case 4:
                    rm.Producttype = Console.ReadLine();
                    rm.Producttype = "Fashion products";
                    break;
                case 5:
                    rm.Producttype = Console.ReadLine();
                    rm.Producttype = "Fitness products";
                    break;
                case 6:
                    rm.Producttype = Console.ReadLine();
                    rm.Producttype = "Industrial products";
                    break;
                case 7:
                    rm.Producttype = Console.ReadLine();
                    rm.Producttype = "Electronical devices";
                    break;
                case 8:
                    rm.Producttype = Console.ReadLine();
                    rm.Producttype = "Kitchen products";

                    break;

            }
            Console.WriteLine(rm.Producttype);
            Console.WriteLine("------You can Return your product soon------");
        }



        /// <summary>
        /// Method for exchanging a product
        /// </summary>

        static void ExchangeProduct()
        {
           
            try
            {
                Return rm = new Return();
                Console.WriteLine("Enter the product purchased date");
                rm.Productdate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter the product exchange date");
                rm.ExchangeDate = Convert.ToDateTime(Console.ReadLine());
                ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();


                Console.WriteLine("Enter name of the product you want to exchange");
                rm.ProductName = Console.ReadLine();

                Console.WriteLine("Enter with which product you want to exchange");
                rm.ProductName = Console.ReadLine();
                rbl.ExchangeProduct(rm);
                Console.WriteLine("Your Product will be Exchanged soon!!");
                
            }
            catch (ReturnException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Exit()
        {
            System.Console.WriteLine("----Thankyou----");
        }
        /// <summary>
        /// Method for Add details into returns
        /// </summary>
        static void AddReturn()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();

            Console.Write("Enter new Product Name: ");
            rm.ProductName = Console.ReadLine();

            rbl.AddReturn(rm);
            Console.WriteLine("Product  Added");

           
        }
        
        /// <summary>
        /// Method to remove Return details by ProductId
        /// </summary>
        static void RemoveReturnByProductID()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            System.Console.Write("Enter the ProductID to be Deleted:");
            string ProductId = (System.Console.ReadLine());

            rbl.RemoveReturnByProductID(ProductId);
            System.Console.WriteLine("ProductID Removed");


        }
        /// <summary>
        /// Method to remove Return details by Productname
        /// </summary>
        static void RemoveReturnByProductName()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            System.Console.Write("Enter the ProductName:");
            string ProductName = System.Console.ReadLine();

            rbl.RemoveReturnByProductName(ProductName);
            System.Console.WriteLine("Product Removed");
        }


        /// <summary>
        ///  Method to get the added details
        /// </summary>
        static void GetReturns()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            rbl.GetReturns();

            List<Return> rets = rbl.GetReturns();
            //Displays all the details 
            foreach (Return item in rets)
            {


                System.Console.WriteLine("--------------- Details are --------------");
                Console.WriteLine("ProductID :"+item.ProductID + " ProductName is: " + item.ProductName + " ProductQuantity is: " + item.ProductQuantity + " ProductType " + item.Producttype + "  Productdate :" + item.Productdate + "  ");
            }

        }
        /// <summary>
        /// Method to get Return details by ProductId
        /// </summary>
        static void GetReturnByProductID()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            Console.WriteLine("Enter ProductID");
            rm.ProductID = Console.ReadLine();

            rbl.GetReturnByProductID(rm);
            Console.WriteLine("Your Product ID is:"+rm.ProductID);
        }
        /// <summary>
        /// Method to get Return details by Productname
        /// </summary>
        static void GetReturnByProductName()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            Console.WriteLine("Enter Productname");
            rm.ProductName = Console.ReadLine();

            rbl.GetReturnByProductName(rm);
            Console.WriteLine("Your Product name is:");
        }
        /// <summary>
        /// Method to update Returns
        /// </summary>
        static void UpdateReturn()
        {
            ReturnsBusinessLayer rbl = new ReturnsBusinessLayer();
            Return rm = new Return();
            Console.WriteLine("Enter existing Product name to update");
            rm.ProductName = Console.ReadLine();
            Console.WriteLine("Enter existing Product Id to update");
            rm.ProductID = Console.ReadLine();

            if (rm != null)
            {
               Console.WriteLine("Enter the new Productname ");
               rm.ProductName= Console.ReadLine();
                Console.WriteLine("Enter the new ProductId ");
                rm.ProductName = Console.ReadLine();

                rbl.UpdateReturn(rm);
                Console.WriteLine("ProductName Updated Sucessfully!!!");
                Console.WriteLine("ProductId updated Successfully!!!");

            }
            else
            {
                Console.WriteLine("Product doesn't exist");
            }

            
        }


    }
}
