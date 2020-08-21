using Group2.Znalytics.GreetOutDoors.Product.Entities;

class Product
{

    static void Main()
    {
        // creating the object for ProductDeatils class
        ProductDetails p = new ProductDetails();
        ProductBusiness pb = new ProductBusiness();

        int Choice;
        bool b;
        while (true)
        {

            System.Console.WriteLine("1.ProductDetails");
            System.Console.WriteLine("2. Categories");
            System.Console.WriteLine("3. Exit");

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
                        pb.AddProducts(p); //adding the products into the List
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
                    case 3:
                        ///<summary>///
                        ///list of  product categories    ///
                        /// </summary>///
                        System.Console.WriteLine("personal accessories ");
                        p.personal accessories = System.Console.ReadLine();
                        System.Console.WriteLine("golf equipment");
                        p.golf equipment = System.Console.ReadLine();
                        System.Console.WriteLine("camping equipment");
                        p.camping equipment = System.Console.ReadLine();
                        System.Console.WriteLine("mountaineering equipment ");
                        p.mountaineering equipment = System.Console.ReadLine();
                        System.Console.WriteLine("outdoor protection");
                        p.outdoor protection = System.Console.ReadLine();
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