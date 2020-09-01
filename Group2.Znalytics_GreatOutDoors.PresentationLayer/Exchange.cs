using System;

namespace ZnalyticsGreatOutDoors.PresentationLayer
{
    //class
    class Details
    {
        static void Main()
        {
            int select;
            Details d = new Details();
            Console.WriteLine("GREAT OUTDOORS"); 
            Console.WriteLine("Enter Your Name:");
            string a = System.Console.ReadLine();
            Console.WriteLine("Enter Your Mobile Number");
            string b = System.Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            string c = System.Console.ReadLine();
            Console.WriteLine("Enter Product Id");
            string e = System.Console.ReadLine();
            Console.WriteLine("Select your Reason For Exchanging the Product");
            Console.WriteLine("______________________________________");
            Console.WriteLine("1.Unsatisfactory Product");
            Console.WriteLine("2.Wrong Product");
            Console.WriteLine("3.Low Quality");


            Console.WriteLine("Enter Your Choice");
            select = Convert.ToInt32(Console.ReadLine());

            switch (select)
            {
                case 1:
                    Console.WriteLine("Unsatisfactory Product");
                    break;
                case 2:
                    Console.WriteLine("Wrong Product");
                    break;
                case 3:
                    Console.WriteLine("Low Quality");
                    break;
            }
            Console.WriteLine("EXCHANGE THE PRODUCT");






            Console.ReadKey();
        }

    }
}