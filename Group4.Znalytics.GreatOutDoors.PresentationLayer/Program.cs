class Program
{
    static void Main()
    {

        System.Console.WriteLine("********WELCOME TO RETAIL STORE********");
        //retail store id
        System.Console.WriteLine("Enter The Retail store Id");
        //int a = int.Parse(System.Console.ReadLine());
        Retailstore r = new Retailstore();
        r.RetailStoreID = (System.Convert.ToInt32(System.Console.ReadLine()));
        System.Console.WriteLine("The retail store Id is:" + r.RetailStoreID);
        System.Console.WriteLine(r.RetailStoreID);


        //choice of choosing reports
        System.Console.WriteLine("*****Select the choice  for payment choosing reports******");
        System.Console.WriteLine("1.Monthly reports");
        System.Console.WriteLine("2.Quaterly reports");
        System.Console.WriteLine("3.Annual reports");
        int Choice = int.Parse(System.Console.ReadLine());
        switch (Choice)
        {
            case 1:
                System.Console.WriteLine("Monthly reports");
                r.Reports = "Monthly reports";
                break;
            case 2:
                System.Console.WriteLine("Quarterly reports");
                r.Reports = "Quarterly reports";
                break;
            case 3:
                System.Console.WriteLine("Annual reports");
                r.Reports = "Annual Reports";
                break;
            default:
                System.Console.WriteLine("Unknown choice");
                break;
        }


        System.Console.Write("Selected reports are:" + r.Reports);
        System.Console.ReadKey();

    }
}


