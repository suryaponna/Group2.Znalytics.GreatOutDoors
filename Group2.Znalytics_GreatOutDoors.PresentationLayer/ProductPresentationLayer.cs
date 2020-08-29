//created by meghana
using Group2.Znalytics.GreatOutDoors.Product.Entities;

class Product
{

    static void Main()
    {
        // creating the object for ProductDetails class
        Product p;
        p = new Product();
        //ProductBusinessLayer ProductBusinessLayer = new ProductBusinessLayer();

        System.Console.WriteLine("***\n |PRODUCTS|\n***\n");

        //Product id
        System.Console.WriteLine("Enter The ProductId");
        p.Product Id= (System.Convert.ToInt32(System.Console.ReadLine()));
        System.Console.WriteLine("The product is:" + p.productID);

        //choice of choosing reports
        System.Console.WriteLine("******select the option that you want******");
        System.Console.WriteLine("Enter 1 for Product details");
        System.Console.WriteLine("Enter 2 for Product Category");
        System.Console.WriteLine("Enter 3 for Product subCategory");
        System.Console.WriteLine("Enter 4 for exit");
        int Choice = int.Parse(System.Console.ReadLine());
        switch (Choice)
        {
            case 1:
                System.Console.WriteLine("Product details");
                p.Product details = "product details";
                break;
            case 2:
                System.Console.WriteLine("Product category");
                p.Product Category = "Product Category";
                break;
            case 3:
                System.Console.WriteLine("Product subCategory");
                p.Product SubCategory = "Product SubCategory ";
                break;
            default:
                System.Console.WriteLine("Unknown choice");
                break;
        }
        System.Console.WriteLine("Selected Products are:" + p.Productdetails);
        System.Console.WriteLine("******");

        //Catagories of Products 
        System.Console.WriteLine("TYPES OF PRODUCTS");
        System.Console.WriteLine("---------------------------------");
        System.Console.WriteLine("1.Personal Accessories");
        System.Console.WriteLine("2.Golf Equiment");
        System.Console.WriteLine("3.Camping Euipment");
        System.Console.WriteLine("4.Mountaineering Euipment");
        System.Console.WriteLine("5.Outdoor Protection");
        System.Console.WriteLine("Enter more than 6 to exit");
        int ch = 1;
        do
        {
            bool a = int.TryParse(System.Console.ReadLine(), out ch);
            if (a == true)
            {
                switch (ch)
                {
                    case 1:
                        System.Console.WriteLine("Personal Accesories");
                        Product p;
                        p = new Product();

                        //different types of personal accessories
                        System.Console.WriteLine("----------Personal Accessories-----------");
                        System.Console.WriteLine("\n 1.Jackets \n 2.Boots and Shoes \n 3.cravats \n 4.Ties" +
                       "\n 5.Stockings \n 6.Shawls \n 7.necklaces \n 8.exit");

                        // Switch Case statement to select the categories of personal accessories
                        int choice1 = 1;
                        do
                        {
                            bool b = int.TryParse(System.Console.ReadLine(), out choice1);
                            if (b == true)
                            {
                                switch (choice1)
                                {
                                    case 1:
                                        System.Console.WriteLine("Jackets");
                                        //p.Product Category = "Jackets";
                                        break;
                                    case 2:
                                        System.Console.WriteLine("Boots and Shoes");
                                        //p.Product Category = "Boots and Shoes ";
                                        break;
                                    case 3:
                                        System.Console.WriteLine("Cravats");
                                        //p.Product Category = "Cravats";
                                        break;
                                    case 4:
                                        System.Console.WriteLine(" ties");
                                        //p.Product Category = "ties";
                                        break;
                                    case 5:
                                        System.Console.WriteLine("stockings");
                                        //p.Product Category = "stockings";
                                        break;
                                    case 6:
                                        System.Console.WriteLine("Shawls");
                                        //p.Product Category = "shawls";
                                        break;
                                    case 7:
                                        System.Console.WriteLine("Necklaces");
                                        //p.Product Category = "Necklaces";
                                        break;
                                    default:
                                        System.Console.WriteLine("Exit");
                                        break;
                                }
                            }
                        } while (choice1 != 6);
                        break;


                    case 2:

                        System.Console.WriteLine("Golf Equipment");
                        Product p;
                        p = new Product();

                        //different types of personal accessories
                        System.Console.WriteLine("----------Golf Euipment-----------");
                        System.Console.WriteLine("\n 1.Golf wedges \n 2.Golf cart\n 3.Club head covers \n 4.Ball mark repair tool" +
                       "\n 5.Ball markers \n 6.Shoes \n 7.Gloves \n 8.exit");

                        // Switch Case statement to select the categories of Books
                        int choice2 = 1;
                        do
                        {
                            bool b = int.TryParse(System.Console.ReadLine(), out choice2);
                            if (b == true)
                            {
                                switch (choice2)
                                {
                                    case 1:
                                        System.Console.WriteLine("Golf wedges");
                                        //p.Product Category = "Golf wedges";
                                        break;
                                    case 2:
                                        System.Console.WriteLine("Golf cart");
                                        //p.Product Category = "Golf cart ";
                                        break;
                                    case 3:
                                        System.Console.WriteLine("Club head covers");
                                        //p.Product Category = "Club head covers";
                                        break;
                                    case 4:
                                        System.Console.WriteLine(" Ball mark repair tool");
                                        //p.Product Category = "Ball mark repair tool";
                                        break;
                                    case 5:
                                        System.Console.WriteLine("Ball markers");
                                        //p.Product Category = "Ball markers";
                                        break;
                                    case 6:
                                        System.Console.WriteLine("Shoes");
                                        //p.Product Category = "Shoes";
                                        break;
                                    case 7:
                                        System.Console.WriteLine("Gloves");
                                        //p.Product Category = "Gloves";
                                        break;
                                    default:
                                        System.Console.WriteLine("Exit");
                                        break;
                                }
                            }
                        } while (choice2 != 5);
                        break;





