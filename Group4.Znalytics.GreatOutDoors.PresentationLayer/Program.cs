class program
{
    static void Main()
    {
        int a, b=20;
        
        System.Console.WriteLine("Hello World");
        //System.Console.ReadKey();
        System.Console.WriteLine("Enter a value");
        a = int.Parse(System.Console.ReadLine());
        if(a>b)
        {
            System.Console.WriteLine("a is bigger");
        }
        else
        {
            System.Console.WriteLine("b  is bigger");
        }
        System.Console.ReadKey();
        
    }
}