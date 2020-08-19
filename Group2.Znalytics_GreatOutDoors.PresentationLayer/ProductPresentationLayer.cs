class Product
{

    static void Main()
    {
        // creating the object for ProductDeatils class
        ProductDetails p = new ProductDetails();
        // Creating thhe object for ProductBusiness class
        ProductBusiness pb = new ProductBusiness();


        int Choice;
        bool b;
        while (true)
        {
            System.Console.WriteLine("1. ProductDetails");
            System.Console.WriteLine("2.Categories");
            System.Console.WriteLine("3. exit");

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
                        System.Console.WriteLine("enter the Productprice:");
                        p.Price = System.Convert.ToDouble(System.Console.ReadLine());
                        pb.AddProducts(p); //adding the products into the List

                        System.Console.WriteLine("Product Added Sucessfully!!!");

                        System.Console.WriteLine("===============Product Details=============");
                        System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
                        System.Console.WriteLine("-----------------------------------------------------------------------");
                        System.Console.WriteLine(p.ProductName + "    " + p.ProductID + "     " + p.Price);// Displaying the products


                        break;


                    case 2:
                        System.Console.WriteLine("===============Product Details=============");
                        System.Console.WriteLine("ProductName" + "   " + "ProductID" + "  " + "Number of Products Avalilable ");
                        System.Console.WriteLine("-----------------------------------------------------------------------");
                        System.Console.WriteLine(p.ProductName + "    " + p.ProductID + "     " + p.Price);// Displaying the products

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