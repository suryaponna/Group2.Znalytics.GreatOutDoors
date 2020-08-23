﻿//created by meghana
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreetOutDoors.Product.Entities;

class Product
{

    static void Main()
    {
        // creating the object for ProductDeatils class
        ProductDetails p = new ProductDetails();
        ProductBusiness pb = new ProductBusiness();

        int Choice;
        bool b;
        while (true)
        {

            System.Console.WriteLine("PRODUCT DETAILS");
            System.Console.WriteLine("********************");
            System.Console.WriteLine("1. Add Product")
            Ssytem.Console.WriteLine("2. Add Product Categories");
            System.Console.WriteLine("2. Show Product");
            System.Console.WriteLine("3. Remove Product");
            b = int.TryParse(System.Console.ReadLine(), out Choice);

            if (b == true)
            {

                switch (Choice)
                {
                    case 1:
                        AddProduct();
                        break;

                    case 2:
                        DisplayProducts();
                        break;
                    case 3:
                        RemoveProduct();
                        break;
                    default:
                        System.Console.WriteLine("enter the valid option");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("invalid option");
            }
        }

        while (Choice ! = 4) ;

        void AddProduct()
        {
            // creating the object for ProductDetails class
            ProductDetails p = new ProductDetails();
            ProductBusiness pb = new ProductBusiness();
            System.Console.WriteLine("***PRODUCT DETAILS***");
            System.Console.WriteLine("enter the ProductName:");
            p.ProductName = System.Console.ReadLine();
            System.Console.WriteLine("enter the ProductId");
            p.ProductID = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("enter the ProductType");
            p.ProductType = System.Console.ReadLine();
            System.Console.WriteLine("enter the Produccolor");
            p.ProductColor = System.Console.ReadLine();
            System.Console.WriteLine("enter the Productprice:");
            pb.AddProducts(p); //adding the products into the List
            System.Console.WriteLine("PRODUCTS ARE ADDED SUCCESSFULLY");
        }
        void AddProductCategories()
        {
            System.Console.WriteLine("personal accessories ");
            p.personal accessories = System.Console.ReadLine();
            System.Console.WriteLine("golf equipment");
            p.golf equipment = System.Console.ReadLine();
            System.Console.WriteLine("camping equipment");
            p.camping equipment = System.Console.ReadLine();
            System.Console.WriteLine("mountaineering equipment ");
            p.mountaineering equipment = System.Console.ReadLine();
            System.Console.WriteLine("outdoor protection");
            p.outdoor protection = System.Console.ReadLine();

        }
        void DisplayProducts()
        {

            ///<summary>///
            ///Displaying the products which are added///
            ///</summary>///
            System.Console.WriteLine("***Product Details***");
            System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
            System.Console.WriteLine("-----------------------------------------------------------------------");
            System.Console.WriteLine(p.ProductName + "    " + p.ProductID + "     " + p.Price);

        }
        void RemoveProduct()
        {
            ProductEntity Product = new ProductEntity();// creating the object fro ProductDeatils class
            ProductBusiness pb = new ProductBusiness();// Creating thhe object for ProductBusiness class
            System.Console.WriteLine("select on which type you want to remove a product");
            System.Console.WriteLine("1.based on ProductId");
            System.Console.WriteLine("2.based on ProductName");
            int Option;
            bool a;
            a = int.TryParse(System.Console.ReadLine(), out Option);

            if (a == true)
            {
                switch (Option)
                {
                    case 1: RemoveProductByID(); break;
                    case 2: RemoveProductByProductName(); break;
                    default: System.Console.WriteLine("Please Choose enter correct Option"); 
                    break;

                }

            }
            else
            {
                System.Console.WriteLine("Please Enter Correct Option");
            }
            void RemoveProductByID()
            {
                System.Console.Write("Enter the ProductID to be Deleted:");
                int id = int.Parse(System.Console.ReadLine());

                pb.RemoveProductByID(id);
                System.Console.WriteLine("Product Removed");


            }
            void RemoveProductByProductName()
            {
                System.Console.Write("Enter the ProductName:");
                string name = System.Console.ReadLine();

                pb.RemoveProductByName(name);
                System.Console.WriteLine("Product Removed");
            }

        }

    }

}