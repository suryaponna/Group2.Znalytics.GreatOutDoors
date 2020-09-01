using GreatOutdoorsProduct.Entities;
using Group2.Znalytics.GreatOutDoors.BusinessLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics_GreatOutDoors.PresentationLayer
{
    //Represents PresentationLayer of OrderProduct
    class OrderPresentationLayer
    {
        //Execution Starts from the Main Method
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
            try
            {
                OrderProduct order = new OrderProduct();
                OrderBusinessLayer orderLayer = new OrderBusinessLayer();

                //Calling the method from BusinessLogicLayer to display the details
                Console.WriteLine("============Product Details==========");
                Console.WriteLine("Enter ProductID to select Products that you want to order");
                order.ProductID = Console.ReadLine();
                Console.WriteLine("Enter Quantity");
                int quantity = int.Parse(Console.ReadLine());
                Product p = orderLayer.ProductDetails(order.ProductId);
                order.TotalPrice += p.CostPrice * quantity;
                Console.WriteLine("================AddressDetails of customer==========");
                Console.WriteLine("Enter your CustomerId to Choose your Address");
                int CustomerID = int.Parse(Console.ReadLine());
                Customer customerAddress = orderLayer.GetOrderDetailsByCustomerID(CustomerID);
                order.CustomerAddressId = CustomerID;

                Console.WriteLine("Price for selected Products is:" + order.TotalPrice);
                Console.WriteLine("Enter 1 if you want to Confirm Your Order");
                int i = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    Console.WriteLine("Your OrderID is:" + orderLayer.OrderID());
                    //orderLayer.AddOrderDetails(order);
                }
                else
                {
                    Console.WriteLine("You didn't confirm your orders,please Try again");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Represents method for updating the order details
        /// </summary>
        static void UpdateOrderDetails()
        {
            OrderBusinessLayer orderBusiness = new OrderBusinessLayer();
            int choice = 0;
            do
            {
                Console.WriteLine("Choose the following details which do you want to update");
                Console.WriteLine("1.Product Details");
                Console.WriteLine("2.Quantity");
                Console.WriteLine("3.Customer Details");
                Console.WriteLine("4.Exit");

                Console.WriteLine("Enter Choice:");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter OrderID");
                int orderId = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:


                        Console.WriteLine("Enter ProductID");
                        string ProductId = Console.ReadLine();
                        orderBusiness.UpdateProductDetails(orderId, ProductId); ;
                        break;

                    case 2:
                        Console.WriteLine("Enter Quantity");
                        int quantity = int.Parse(Console.ReadLine());
                        orderBusiness.UpdateQuantity(orderId, quantity);
                        break;
                    case 3:
                        Console.WriteLine("Enter AddressID");
                        string addressID = Console.ReadLine();
                        orderBusiness.UpdateCustomerAddressDetails(orderId, addressID);
                        break;
                    case 4:
                        Console.WriteLine("Enter CustomerID");
                        int customerId = int.Parse(Console.ReadLine());
                        orderBusiness.UpdateCustomerAddressDetails(orderId, customerId);
                        break;
                    case 5:
                        Console.WriteLine("Exit"); break;
                }


            } while (choice != 4);
        }
        /// <summary>
        /// Represents a method for cancel order
        /// </summary>
        static void CancelOrder()
        {
            Console.WriteLine("Enter OrderId");
            int orderId = int.Parse(Console.ReadLine());
            OrderBusinessLayer orderBusiness = new OrderBusinessLayer();
            orderBusiness.CancelOrderDetails(orderId);
        }

        /// <summary>
        /// Represents method to view the Order Details
        /// </summary>

        static void ViewOrderDetails()
        {
            OrderBusinessLayer orderBusiness = new OrderBusinessLayer();
            Console.WriteLine("Enter CustomerID");
            int CustomerID = int.Parse(Console.ReadLine());
            //List<OrderProduct> orderProducts = orderBusiness.GetOrderDetailsByCustomerID(CustomerID);
           /* foreach (var order in orders)
            {
                Console.WriteLine("ProductId:" + order.ProductId);
                Console.WriteLine("CustomerAddressId:" + order.CustomerAddressId);
                Console.WriteLine("TotalPrice:" + order.TotalPrice);
                Console.WriteLine("Quantity;" + order.Quantity);
            }*/
           
        }

    }
}


  
            
























































































 
