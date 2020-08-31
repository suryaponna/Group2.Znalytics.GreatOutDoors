using GreatOutdoorsProduct.Entities;
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class OrderPresentationLayer
    {
        public void Menu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("ORDER DETAILS MENU");
                Console.WriteLine("1.Place Order");
                Console.WriteLine("2.Update OrderDetails");
                Console.WriteLine("3.Cancel Order");
                Console.WriteLine("4.View OrderDetails");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter Choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PlaceOrder();
                        break;
                    case 2:
                        UpdateOrderDEtails();
                        break;
                    case 3:
                        CancelOrder();
                        break;
                    case 4:
                        ViewOrderDetails();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                }
            } while (choice != 5);
        }



        public void PlaceOrder()
        {
            OrderBusinessLayer orderLayer = new OrderBusinessLayer();


            Console.WriteLine("============Product Details==========");

        }
        public void UpdateOrderDetails()
        {
            OrderBusinessLayer orderBusiness = new OrderBusinessLayer();
        }


        public void cancelOrder()
        {

        }
    }
                /* OrderProduct op;
                 op = new OrderProduct(); //Local variable
                 Console.WriteLine("------------------------Welcome to Great OutDooors-------------------------");
                 Console.WriteLine("Enter the Product ID:");
                 op.ProductID = Console.ReadLine();
                 Console.WriteLine("The Product ID is:", op.ProductID);
                 Console.WriteLine("Enter the UserName:");
                 op.UserName = Console.ReadLine();
                 Console.WriteLine("UserName is:", op.UserName);
                 Console.WriteLine(op.ProductID);
                 int choice = 0;

                 //Choose the category
                 Console.WriteLine("1.Personal Accessories");
                 Console.WriteLine("2.Camping Equipment");
                 Console.WriteLine("3.Golf Equipment");
                 Console.WriteLine("4.Mountaineering Equipment");
                 Console.WriteLine("5.Outdoor Protection");
                 int Choice = int.Parse(Console.ReadLine());        
                 switch (choice)
                 {
                     case 1:
                         Console.WriteLine("Personal Accessiories"); break;
                     case 2:
                         Console.WriteLine("Camping Equipment"); break;
                     case 3:
                         Console.WriteLine("Golf Equipment"); break;
                     case 4:
                         Console.WriteLine("Mountaineering Equipment"); break;
                     case 5:
                         Console.WriteLine("Outdoor Protection"); break;
                     default:
                         Console.WriteLine("Unknown Product"); break;


               

        }
    }
}

            


        
