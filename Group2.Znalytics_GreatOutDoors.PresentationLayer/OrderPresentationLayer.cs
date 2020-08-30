using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Console.WriteLine("ORDER THE PRODUCT");
            Console.WriteLine("Person Login");
            Console.WriteLine("Enter the ProductID");
            Console.WriteLine(op.ProductID);
            int choice = 0;
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

                switch(choice)
                {
                    case 1: AddOrderDetails();break;
                        

                       
            }
            }
            

            


            
        }

        private static void AddOrderDetails()
        {
            throw new NotImplementedException();
        }
    }
}
