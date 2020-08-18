class Master
{
    static void Main()
    {
        Master m = new Master();

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
                break;
            case 1:
                System.Console.WriteLine("golf equipment");
                break;
            case 2:
                System.Console.WriteLine("camping equipment");
                break;
            case 3:
                System.Console.WriteLine("mountaineering equipment");
                break;
            case 4:
                System.Console.WriteLine("outdoor protection");
                break;
            case 5:
                System.Console.WriteLine("personal accessories");
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
        m.SetNumber(System.Convert.ToInt64(System.Console.ReadLine()));
        System.Console.WriteLine("your Number:" + m.GetId());
        System.Console.ReadLine();
    }
}
