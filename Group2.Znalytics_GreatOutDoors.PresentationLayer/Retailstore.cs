using System;


namespace Group2.Znalytics.GreatOutDoors.RetailStore.PresentationLayer
{
    class RetailStorePresentation
    {
        static void Main()
        {
            //creating object
            Retailstore r = new Retailstore();
            System.Console.WriteLine("================WELCOME TO RETAIL STORE================");

            //retail id
            System.Console.WriteLine("Enter The Retail store Id");
            r.RetailStoreID = (System.Convert.ToInt32(System.Console.ReadLine()));
            System.Console.WriteLine("The retail store Id is:" + r.RetailStoreID);

            //choice of choosing reports
            System.Console.WriteLine("================Select the choice  for payment choosing reports================");
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

            //retail products

            System.Console.WriteLine("================choice of choosing types of products================");
            System.Console.WriteLine("Enter 1 for Electrical Appliances cost range is  1000-100000");
            System.Console.WriteLine("Enter 2 for Grocery products cost range is  1000-5000");
            System.Console.WriteLine("Enter 3 for Medical Products cost range is  10-30000");
            System.Console.WriteLine("Enter 4 for Fashion products cost range is  100-5000");
            System.Console.WriteLine("Enter 5 for Fitness products cost range is  100-50000");
            System.Console.WriteLine("Enter 6 for Industrial products cost range is  1000-500000");
            System.Console.WriteLine("Enter 7 for Eletronical devices cost range is  1000-100000");
            System.Console.WriteLine("Enter 8 for Kitchen Products cost range is  100-535000");
            System.Console.WriteLine("Enter morethan 9 to exit");
            int b = int.Parse(System.Console.ReadLine());

            while (b <= 8)
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
                        r.RetailProducts = " Medical Products";
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
                    case 7:
                        r.RetailProducts = System.Console.ReadLine();
                        r.RetailProducts = "Eletronical devices";
                        break;
                    case 8:
                        r.RetailProducts = System.Console.ReadLine();
                        r.RetailProducts = "Kitchen Products";
                        break;
                    default:
                        System.Console.WriteLine("In Valid option");
                        break;

                }
                System.Console.WriteLine("Selected the type of Retail products are:" + r.RetailProducts);
                b = int.Parse(System.Console.ReadLine());
            }

            // Suppliers for transporting
            System.Console.WriteLine("================ Suppliers For Transporting================");
            System.Console.WriteLine("Enter true for if you want suppliers else enter false");
            //r.Suppliers = System.Console.ReadLine();
            bool k = true;
            bool s = bool.Parse(System.Console.ReadLine());
            if (s == true)
            {
                System.Console.WriteLine("Yes I want suppliers");
            }
            else
            {
                k = false;
                System.Console.WriteLine("No i doesn't want suppliers");
            }
            //System.Console.WriteLine("get suppliers:" + r.Suppliers);

            //Outlier Products
            System.Console.WriteLine("================ Damaged Products ================");
            // replace:
            //System.Console.WriteLine("I ");




            System.Console.WriteLine("================ THANK YOU FOR CHOOSING OUR RETAIL STORE ================");
            System.Console.ReadKey();
        }
    }
}