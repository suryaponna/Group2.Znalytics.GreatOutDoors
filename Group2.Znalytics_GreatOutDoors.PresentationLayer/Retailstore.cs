class Program
{
    static void Main()
    {
        Retailstore r = new Retailstore();
        System.Console.WriteLine("********WELCOME TO RETAIL STORE********");

        //retail id
        System.Console.WriteLine("Enter The Retail store Id");
        r.RetailStoreID = (System.Convert.ToInt32(System.Console.ReadLine()));
        System.Console.WriteLine("The retail store Id is:" + r.RetailStoreID);

        //choice of choosing reports
        System.Console.WriteLine("*****Select the choice  for payment choosing reports******");
        System.Console.WriteLine("Enter 1 for Monthly reports");
        System.Console.WriteLine("Enter 2 for Quaterly reports");
        System.Console.WriteLine("Enter 3 for Annual reports");
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
        System.Console.WriteLine("Selected reports are:" + r.Reports);
        System.Console.ReadKey();


        //retail products
        System.Console.WriteLine("******choice of choosing types of products******");
        System.Console.WriteLine("Enter 1 for Electrical Appliances");
        System.Console.WriteLine("Enter 2 for Grocery products");
        System.Console.WriteLine("Enter 3 for Medicines");
        System.Console.WriteLine("Enter 4 for Fashion products");
        System.Console.WriteLine("Enter 5 for Fitness products");
        System.Console.WriteLine("Enter 6 for Industrial products");
        int b = int.Parse(System.Console.ReadLine());
        while (true)
        {
            switch (b)
            {
                case 1:
                    r.RetailProducts = System.Console.ReadLine();
                    r.RetailProducts = "Electrical Appliances";
                    break;
                case 2:
                    r.RetailProducts = System.Console.ReadLine();
                    r.RetailProducts = "Grocery products";
                    break;
                case 3:
                    r.RetailProducts = System.Console.ReadLine();
                    r.RetailProducts = " Medicines";
                    break;
                case 4:
                    r.RetailProducts = System.Console.ReadLine();
                    r.RetailProducts = "Fashion products";
                    break;
                case 5:
                    r.RetailProducts = System.Console.ReadLine();
                    r.RetailProducts = "Fitness products";
                    break;
                case 6:
                    r.RetailProducts = System.Console.ReadLine();
                    r.RetailProducts = "Industrial products";
                    break;
                default:
                    System.Console.WriteLine("Enter Valid option");
                    break;
            }
            System.Console.WriteLine("Selected the type of Retail products are:" + r.RetailProducts);
            System.Console.ReadKey();

        }
       // System.Console.WriteLine();

    }

}