class Product
{

    static void Main()
    {
        // creating the object for ProductDeatils class
        ProductDetails p = new ProductDetails();
      
        int Choice;
        bool b;
        while (true)
        {
            System.Console.WriteLine("1. CustomerLogin");
            System.Console.WriteLine("2.ProductDeatils");
            System.Console.WriteLine("3. Categories");
            System.Console.WriteLine("4. Exit");

            b = int.TryParse(System.Console.ReadLine(), out Choice);

            if (b == true)
            {

                switch (Choice)
                {
                    case 1:
                        System.Console.WriteLine("enter the ProductName:");
                        p.ProductName = System.Console.ReadLine();
                        System.Console.WriteLine("enter the ProductId");
                        p.ProductID = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter the ProductType");
                        p.ProductType = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter the Produccolor");
                        p.ProductColor = int.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("enter the Productprice:");
                        p.ProductPrice = System.Convert.ToDouble(System.Console.ReadLine());
                        p.AddProducts(p); //adding the products into the List
                        System.Console.WriteLine("PRODUCTS ARE ADDED SUCCESSFULLY");
                        break;


                    case 2:
                        ///<summary>///
                        ///Displaying the products which are added///
                        ///</summary>///
                        System.Console.WriteLine("***Product Details***");
                        System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
                        System.Console.WriteLine("-----------------------------------------------------------------------");
                        System.Console.WriteLine(p.ProductName + "    " + p.ProductID + "     " + p.Price);

                        break;

                    default:
                        System.Console.WriteLine("Please Enter the Correct Option");
                        break;


                }



            }
            else
            {
                System.Console.WriteLine("Please Enter the only digits");
            }



        }

    }
}