using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class OrderPresentationLayer
    {
        static void Main()
        {


            OrderProduct op;
            op = new OrderProduct(); //Local variable
            Console.WriteLine("------------------------Welcome to Great OutDooors-------------------------");
            Console.WriteLine("Enter the Product ID:");
            op.ProductID = Console.ReadLine();
            Console.WriteLine("The Product ID is:", op.ProductID);
            Console.WriteLine("Enter the UserName:");
            op.UserName = Console.ReadLine();
            Console.WriteLine("UserName is:"op.UserName);
            Console.WriteLine(op.ProductID);
            int choice = 0;
           
                //Choose the category
                Console.WriteLine("1.Personal Accessories");
                Console.WriteLine("2.Camping Equipment");
                Console.WriteLine("3.Golf Equipment");
                Console.WriteLine("4.Mountaineering Equipment");
                Console.WriteLine("5.Outdoor Protection");
                int Choice = int.Parse(Console.ReadLine());
               switch(choice)
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
                    Console.WriteLine("Outddor Protection"); break;
                default:
                    Console.WriteLine("Unknown Product"); break;


            }
            do
            {
                Console.WriteLine("Enter the OrderDetails");
                Console.WriteLine("1.Add OrderDetails");
                Console.WriteLine("2.View OrderDetails");
                Console.WriteLine("3.Update OrderDetails");
                Console.WriteLine("4.Delete OrderDetails");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter Choice:");
                choice = int.Parse(Console.ReadLine());


            }
            }
            }
            

            


            
        }

        private static void AddOrderDetails()
        {
            throw new NotImplementedException();
        }
    }
}
