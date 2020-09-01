using System;
using GreatOutdoorsProduct.Entities;
using GreatOutdoorsProduct.BusinessLayer;

namespace Group2.Znalytics.GreatOutDoors.PresentationLayer

{
    /// <summary>
    /// Represents class for Menu Presentation
    /// </summary>
    class ProductMenuPresentation
    {
       
        /// <summary>
        /// Starting point of the program
        /// </summary>
        static void Main()
        {
            ProductMenu();
        Console.ReadKey();
        }

       /* private static void ProductMenu()
        {
            throw new NotImplementedException();
        }*/

        /// <summary>
        /// Execution starts from main method 
        /// </summary>
        public static void ProductMenu()
        {
            int choice = -1;
            do
            {
                Console.WriteLine("------------------------------:) WELCOME TO Product(:------------------------------");
                Console.WriteLine("PRODUCTS MENU");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product"); 
                Console.WriteLine("3. Remove Product");
                Console.WriteLine("4. Exit");


                bool b = int.TryParse(Console.ReadLine(), out choice);
                if (b == true)
                {

                    switch (choice)
                    {
                        case 1:
                            AddProduct();//adding projects
                            break;

                        case 2:
                            DisplayProducts();//displaying the products
                            break;
                        case 3:
                            RemoveProduct();//removing the product
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
            } while (choice != 5);

            /// <summary>
            /// Method to Add Product details to the list
            /// </summary>
                         void AddProduct()
            {
                // creating the object for ProductDetails class
                Product p = new Product();
                ProductBusinessLayer pb = new ProductBusinessLayer();
                System.Console.WriteLine("***PRODUCT DETAILS***");
                System.Console.WriteLine("enter the ProductName:");
                p.ProductName = System.Console.ReadLine();
                System.Console.WriteLine("enter the ProductId");
                p.ProductID = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine("enter the ProductType");
                //p.ProductType = System.Console.ReadLine();
                System.Console.WriteLine("enter the Produccolor");
                //p.ProductColor = System.Console.ReadLine();
                System.Console.WriteLine("enter the Productprice:");
                //pb.AddProducts(p); //adding the products into the List
                System.Console.WriteLine("PRODUCTS ARE ADDED SUCCESSFULLY");
            }
           ///method for displaying the product
            void DisplayProducts()
            {
                Product p = new Product();
                ///<summary>///
                ///Displaying the products which are added///
                ///</summary>///
                System.Console.WriteLine("***Product Details***");
                System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
                System.Console.WriteLine("-----------------------------------------------------------------------");
                System.Console.WriteLine(p.ProductName + "    " + p.ProductID + "     " + p.SellingPrice);

            }
            //method for removing product
            void RemoveProduct()
            {
                Product Product = new Product();// creating the object fro ProductDeatils class
                ProductBusinessLayer pb = new ProductBusinessLayer();// Creating thhe object for ProductBusiness class
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
                        case 1: RemoveProductByProductID(); break;
                        case 2: RemoveProductByProductName(); break;
                        default:
                            System.Console.WriteLine("Please Choose enter correct Option");
                            break;

                    }

                }
                else
                {
                    System.Console.WriteLine("Please Enter Correct Option");
                }
                ///<summary>
                ///method for removing the product by product id
                ///</summary>
                
                void RemoveProductByProductID()
                {
                    System.Console.Write("Enter the ProductID to be Deleted:");
                    int ProductId = int.Parse(System.Console.ReadLine());

                    pb.RemoveProductByProductID(ProductId);
                    System.Console.WriteLine("Product Removed");


                }
                ///<summary>
                ///method for removing the product by product id
                ///</summary>
                void RemoveProductByProductName()
                {
                    System.Console.Write("Enter the ProductName:");
                    string name = System.Console.ReadLine();

                    pb.RemoveProductByProductName(name);
                    System.Console.WriteLine("Product Removed");
                }


            }
        }
    }

} 

public class ProductPresentationLayer
{
    public static void Main()
    {

        //creating object for productcategories
        Product p;
        p = new Product();
        //ProductBusinessLayer ProductBusinessLayer = new ProductBusinessLayer();


        Console.WriteLine("----------------------------WELCOME TO ZNALYTICS PRODUCTS STORE----------------------------");

        //Product id
        Console.WriteLine("Enter The Product Id");
        p.ProductID = int.Parse(Console.ReadLine());
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
                System.Console.WriteLine("Personal Accessories");
                p.SetProduct("Personal Accessories");
                break;
            case 2:
                System.Console.WriteLine("Camping Equipment");
                p.SetProduct("Camping Equipment");
                break;
            case 3:
                System.Console.WriteLine("Golf Equipment");
                p.SetProduct("Golf Equipment");
                break;
            case 4:
                System.Console.WriteLine("Mountaineering Equipment");
                p.SetProduct("Mountaineering equipment");
                break;
            case 5:
                System.Console.WriteLine("OutDoor Protection");
                p.SetProduct("Outdoor Protection");
                break;
            default:
                System.Console.WriteLine("Unknown choice");
                break;
        }
        System.Console.WriteLine("Selected product categories are:" + p.ProductName);

        System.Console.WriteLine("--------------------------------------------------------------");


        //Catagories of Products in retail store
        System.Console.WriteLine("------------------------------Types of product and their categories ,cost ranges from------------------------------");

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
                        System.Console.WriteLine("Personal Accessories");
                        p.SetProduct("PersonalAccessories");
                        //categories  of Personal accessories
                        System.Console.WriteLine("----------Categories of personal accessories-----------");
                        System.Console.WriteLine("\n 1.jackets \n 2.cravats \n 3.ties \n 4.hats" +
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
                                        System.Console.WriteLine("jackets");
                                        p.SetProduct("jackets");
                                        //AddProductQuantity();
                                        break;
                                    case 2:
                                        System.Console.WriteLine("cravats");
                                        p.SetProduct("cravats ");
                                        //AddProductQuantity();
                                        break;
                                    case 3:
                                        System.Console.WriteLine("ties");
                                        p.SetProduct("ties");
                                        //AddProductQuantity();
                                        break;
                                    case 4:
                                        System.Console.WriteLine("hats");
                                        p.SetProduct("hats");
                                        //AddProductQuantity();
                                        break;
                                    case 5:
                                        System.Console.WriteLine("boots and shoes");
                                        p.SetProduct("boots and shoes");
                                        //AddProductQuantity();
                                        break;
                                    default:
                                        System.Console.WriteLine("Exit");
                                        break;
                                }
                            }
                        } while (choice1 != 5);
                        break;

                    case 2:
                        p.SetProduct("Camping Euipment");
                        System.Console.WriteLine("--------Catagories of Camping Equipment---------");
                        System.Console.WriteLine("\n 1.Tent  \n 2.Sleeping bags \n 3.Camping pillow \n 4.Headlamps \n 5.Camp table \n 6.Exit");

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
                                        System.Console.WriteLine("Tent");
                                        p.SetProduct("Tent");
                                        //AddProductQuantity();
                                        break;
                                    case 2:
                                        System.Console.WriteLine("sleeping bags");
                                        p.SetProduct("sleeping bags");
                                        //AddProductQuantity();
                                        break;
                                    case 3:
                                        System.Console.WriteLine("camping pillow");
                                        p.SetProduct("camping pillow");
                                        break;
                                    case 4:
                                        System.Console.WriteLine("headlamps");
                                        p.SetProduct("headlamps");
                                        //AddProductQuantity();
                                        break;
                                    case 5:
                                        System.Console.WriteLine("camp table");
                                        p.SetProduct("camp table");
                                        //AddProductQuantity();
                                        break;
                                    default:
                                        System.Console.WriteLine("Exit");
                                        break;
                                }
                            }
                        } while (choice2 != 3);
                        break;
                    case 3:
                        p.SetProduct("Golf Equipment");
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
                                        System.Console.WriteLine("Balls");
                                        p.SetProduct("Balls");
                                        //AddProductQuantity();
                                        break;
                                    case 2:
                                        System.Console.WriteLine("Golf clubs");
                                        p.SetProduct("Golf clubs");
                                        //AddProductQuantity();
                                        break;
                                    case 3:
                                        System.Console.WriteLine("Ball markers");
                                        p.SetProduct("Ball markers");
                                        //AddProductQuantity();
                                        break;
                                    case 4:
                                        System.Console.WriteLine("Tees");
                                        p.SetProduct("Tees");
                                        //AddProductQuantity();
                                        break;
                                    case 5:
                                        System.Console.WriteLine("Golf bag");
                                        p.SetProduct("Golf bag");
                                        //AddProductQuantity();
                                        break;
                                    case 7:
                                        System.Console.WriteLine("Exit");
                                        break;
                                }
                            }
                        } while (choice3 != 4);
                        break;
                    case 4:
                        p.SetProduct(" Mountaineering Equipment");
                        //Choice of choosing Catagories of Mountaineering Equipment
                        System.Console.WriteLine("---------------Catagories of Mountainering euipment---------------");
                        System.Console.WriteLine("\n 1.Climbing pack\n 2.Rope\n 3.Helmet\n 4.Crampons" +
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
                                        System.Console.WriteLine("Climbing pack");
                                        p.SetProduct("Climbing pack");
                                        //AddProductQuantity();
                                        break;
                                    case 2:
                                        System.Console.WriteLine("Rope");
                                        p.SetProduct("Rope");
                                        //AddProductQuantity();
                                        break;
                                    case 3:
                                        System.Console.WriteLine("Helmet");
                                        p.SetProduct("Helmet");
                                        //AddProductQuantity();
                                        break;
                                    case 4:
                                        System.Console.WriteLine("Crampons");
                                        p.SetProduct("Crampons");
                                        //AddProductQuantity();
                                        break;
                                    case 5:
                                        System.Console.WriteLine("Ice axe");
                                        p.SetProduct("Ice axe");
                                        //AddProductQuantity();
                                        break;
                                    case 6:
                                        System.Console.WriteLine("Exit");
                                        break;
                                }
                            }
                        } while (choice4 != 5);
                        break;
                    case 5:
                        p.SetProduct("Outdoor Protection");
                        System.Console.WriteLine("---------------Categories of Outdoor Protection---------------");
                        System.Console.WriteLine("\n 1.Mask  \n 2.solar powered light \n 3.Traditioal \n 4.Accessories " +
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
                                        System.Console.WriteLine("Mask");
                                        p.SetProduct("Mask");
                                        //AddProductQuantity();
                                        break;
                                    case 2:
                                        System.Console.WriteLine("Sportswear");
                                        p.SetProduct("Sportswear");
                                        //AddProductQuantity();
                                        //r.Cost = 3060;
                                        break;
                                    case 3:
                                        System.Console.WriteLine("Traditional wear");
                                        //AddProductQuantity();
                                        break;
                                    case 4:
                                        System.Console.WriteLine("Accessories");
                                        p.SetProduct("Accessories");
                                        //AddProductQuantity();
                                        break;
                                    case 5:
                                        System.Console.WriteLine("Watches");
                                        p.SetProduct("Watches");
                                        //AddProductQuantity();
                                        break;
                                    case 6:
                                        System.Console.WriteLine("Jewelry");
                                        p.SetProduct("Jewelry");
                                        //AddProductQuantity();
                                        break;
                                    case 7:
                                        System.Console.WriteLine("Formal Wear");
                                        p.SetProduct("Formal Wear");
                                        //AddProductQuantity();
                                        break;
                                    case 8:
                                        System.Console.WriteLine("Exit");
                                        break;
                                }
                            }
                        } while (choice5 != 5);
                        break;
                }
            }
        } while (ch != 6);
        System.Console.WriteLine("--------------------------------------------------------------");
    }
}
          