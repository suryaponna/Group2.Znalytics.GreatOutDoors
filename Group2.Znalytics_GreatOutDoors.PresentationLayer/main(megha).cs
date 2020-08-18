class program
{
    static void Main()
    {
        ProductMaster m = new ProductMaster();

        System.Console.WriteLine("Select The below options for your product");
        System.Console.WriteLine("enter 1 for  personal accessories ");
        System.Console.WriteLine("enter 2 for golf equipment");
        System.Console.WriteLine("enter 3 for camping equipment");
        System.Console.WriteLine("enter 4 for mountaineering equipment ");
        System.Console.WriteLine("enter 5 for outdoor protection");
        System.Console.WriteLine("Enter your product option ");
        int choice = System.Convert.ToInt32(System.Console.ReadLine());
        switch (choice)
        {
            case 0:
                System.Console.WriteLine("personal accessories");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("bangle");
                        break;
                    case 1:
                        System.Console.WriteLine("hand bags");
                        break;
                    case 2:
                        System.Console.WriteLine("makeup");
                        break;
                }
                break;
            case 1:
                System.Console.WriteLine("golf equipment");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("pitching wedge");
                        break;
                    case 1:
                        System.Console.WriteLine("sand wedge");
                        break;
                    case 2:
                        System.Console.WriteLine("gap wedge");
                        break;
                }
                break;
            case 2:
                System.Console.WriteLine("camping equipment");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("tarptant");
                        break;
                    case 1:
                        System.Console.WriteLine("tent");
                        break;
                    case 2:
                        System.Console.WriteLine("trangia");
                        break;
                }
                break;
            case 3:
                System.Console.WriteLine("mountaineering equipment");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("Climbing");
                        break;
                    case 1:
                        System.Console.WriteLine("gas stove");
                        break;
                    case 2:
                        System.Console.WriteLine("climbing rope");
                        break;
                }
                break;
            case 4:
                System.Console.WriteLine("outdoor protection");
                switch (choice)
                {
                    case 0:
                        System.Console.WriteLine("outdoor");
                        break;
                    case 1:
                        System.Console.WriteLine("hand bags");
                        break;
                    case 2:
                        System.Console.WriteLine("makeup");
                        break;
                }
                break;

        }



        System.Console.WriteLine("Enter your Id");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your id:" + m.GetId());
        System.Console.WriteLine("Enter your FirstName");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your FirstName:" + m.GetId());
        System.Console.WriteLine("Enter your LastName");
        m.SetId(System.Console.ReadLine());
        System.Console.WriteLine("your LastName:" + m.GetId());
        System.Console.WriteLine("Enter your Number");
        m.SetPhoneNumber(System.Convert.ToInt64(System.Console.ReadLine()));
        System.Console.WriteLine("your PhoneNumber:" + m.GetId());
    }
}






