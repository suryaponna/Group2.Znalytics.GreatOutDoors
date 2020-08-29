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
            Customer c;
            c = new Customer(); //Local variable

            Console.WriteLine("=========================ORDER THE PRODUCT========================");
            Console.WriteLine("Enter Customer Name");
            c.CustName = Console.ReadLine();
        }
    }
}
