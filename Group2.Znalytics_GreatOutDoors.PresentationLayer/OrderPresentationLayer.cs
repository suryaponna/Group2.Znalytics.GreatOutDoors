/*using GreatOutdoorsProduct.Entities;
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    class OrderPresentationLayer
    {
        public void Menu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("ORDER DETAILS MENU");
                Console.WriteLine("1.Place Order");
                Console.WriteLine("2.Update OrderDetails");
                Console.WriteLine("3.Cancel Order");
                Console.WriteLine("4.View OrderDetails");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter Choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PlaceOrder();
                        break;
                    case 2:
                        UpdateOrderDetails();
                        break;
                    case 3:
                        CancelOrder();
                        break;
                    case 4:
                        ViewOrderDetails();
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                }
            } while (choice != 5);
        }

        /// <summary>
        /// Method for adding Ordrdetails to List
        /// </summary>

        public void PlaceOrder()
        {
            OrderProduct order = new OrderProduct();
            OrderBusinessLayer orderLayer = new OrderBusinessLayer();


            Console.WriteLine("============Product Details==========");
            int choice = 0;
            do
            {
                Console.WriteLine("Enter 1 if you want to select products from orders or else enter 2");
                Console.WriteLine("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter ProductID to select products");
                        string productId = Console.ReadLine();
                        Console.WriteLine("Enter Quantity");
                        int quantity = int.Parse(Console.ReadLine());


                        Product p = orderLayer.ProductDetails(productId);

                        order.totalPrice += p.CostPrice * quantity;
                        order.Quantity += quantity;
                        break;
                    case 2: Console.WriteLine("Exit"); break;
                }
                while (choice == 1)

                    Console.WriteLine("==================AddressDetails=====================");
                Console.WriteLine("Enter your CustomerID to choose Your Address");
                int CustomerId = int.Parse(Console.ReadLine());
                Customer customerAddress = orderLayer.GetCustomerDetailsByCustomerId(CustomerId);
                Console.WriteLine("Price for Selected Product is:" + order.totalPrice);
                Console.WriteLine("Enter 1 if you want to confirm you order");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    order.OrderID = orderLayer.OrderID();
                    Console.WriteLine("Your OrderID is:" + order.OrderID);
                    orderLayer.AddOrderDetails(order);
                }
                else
                {
                    Console.WriteLine("You Didn't confirmed your order,Try again");
                }
            } while (choice != 2);

                catch (Exception ex)

            {
                Console.WriteLine(ex.Message);

            }
        }

    }

    /// <summary>
    /// Represents method for updating the order details
    /// </summary>
    public void UpdateOrderDetails()
    {
        OrderBusinessLayer orderBusiness = new OrderBusinessLayer();
        int choice = 0;
        do
        {
            Console.WriteLine("Choose the following details which do you want to update");
            Console.WriteLine("1.Product Details");
            Console.WriteLine("2.Quantity");
            Console.WriteLine("3.Customer Details");
            Console.WriteLine("$.Exit");

            Console.WriteLine("Enter Choice:");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter OrderID");
            int orderId = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    List<Product> products = new List<Product>();
                    do
                    {
                        Console.WriteLine("Enter ProductID");
                        string ProductId = Console.ReadLine();
                        Product p = OrderBusinessLayer.ProductDetails(ProductId);
                        products.Add(p);
                        Console.WriteLine("Enter 1 if you want to Update one more otherwise enter2");
                        Console.WriteLine("EnterChoice:");
                        choice = int.Parse(Console.ReadLine());
                    } while (choice == 1)
                        orderLayer.UpdateProductDetails(orderId, products)
                            break;
                case 2:
                    OrderProduct order = new OrderProduct();
                    Console.WriteLine("Enter ProductID");
                    string productId = Console.ReadLine();
                    Console.WriteLine("Enter the quantity you want to replace");
                    int Quantity = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter AddressID");
                    string AddressID = Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Enter Custome ID");
                    int CustomerId = int.Parse(Console.ReadLine());
                    Customer customerAddress = OrderBusinessLayer.GetCustomerDetailsbyCustomerId(CustomerId);
                    OrderBusinessLayer.UpdateCustomerAddressDeeetails(orderId, customerAddress);
                    break;
                case 5: Console.WriteLine("Exit"); break;
            }

        } while (choice != 4);



    }
    /// <summary>
    /// Represents a method for cancel order
    /// </summary>
    public void CancelOrder()
    {
        Console.WriteLine("Enter OrderId");
        int orderId = int.Parse(Console.ReadLine());
        OrderBusinessLayer orderLayer = new OrderBusinessLayer();
        orderLayer.CancelOrderDetails(orderId);
    }
}


        
    }
}
*/
            


        
