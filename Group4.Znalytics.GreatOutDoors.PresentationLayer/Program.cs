/// <summary>
/// 
/// </summary>
class Product
{
    static void Main()
    {
        ReturnsModule r;
        r = new ReturnsModule();
        int choice;
        System.Console.WriteLine("Select your reason ");
        System.Console.WriteLine("______________________");
        System.Console.WriteLine("1. Unsatisfactory Product");
        System.Console.WriteLine("2. Defective Product");
        System.Console.WriteLine("3. Incomplete Product");
        System.Console.WriteLine("4. Wrong Product Ordered");
        System.Console.WriteLine("5. Wrong Product Shipped");

        System.Console.WriteLine(" Enter your Choice");
        choice = System.Convert.ToInt32(System.Console.ReadLine());
        //switch case to select reasons
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
        r.ProductID = (System.Console.ReadLine());
        System.Console.WriteLine(r.ProductID);

        System.Console.WriteLine("Enter ProductName");
        r.ProductName = (System.Console.ReadLine());
        System.Console.WriteLine(r.ProductName);

        System.Console.WriteLine("Enter ProductDate");
        r.Productdate = (System.Console.ReadLine());
        System.Console.WriteLine(r.Productdate);

        System.Console.WriteLine("Enter ProductQuantity");
        r.ProductQuantity = (System.Convert.ToInt32(System.Console.ReadLine()));
        System.Console.WriteLine(r.ProductQuantity);

        System.Console.WriteLine("Enter Producttype");
        r.Producttype = (System.Console.ReadLine());
        System.Console.WriteLine(r.Producttype);


        System.Console.WriteLine("--------------- Deatils are --------------");
        System.Console.WriteLine("Product Id: " + r.ProductID);
        System.Console.WriteLine("Employee Name: " + r.ProductName);
        System.Console.WriteLine("number of hours you worked: " + r.Productdate);
        System.Console.WriteLine("Hourly price of yours: " + r.ProductQuantity);
        System.Console.WriteLine("Gross Salary of your is: " + r.Producttype);
        System.Console.WriteLine("ThankYou for your Response");
        System.Console.ReadKey();


    }
}