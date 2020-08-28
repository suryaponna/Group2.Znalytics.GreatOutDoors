using System;
using System.Collections.Generic;
using Znalytics.Group2.GreatOutdoors.BusinessLogicLayer;
using Znalytics.GreatOutdoors.CustomerDetailModule.Entities;

namespace Znalytics.GreatOutDoors.CustomerDetailModule.PresentationLayer
{
    /// <summary>
    /// Represents Login information of the customer
    /// </summary>
    class CustomerDetailPL
    {
        //Execution starts from main method
        static void Main()
        {
            CustomerDetailsPresentation();
            Console.ReadKey();
        }

        //Displaying Customers menu
        //static method is nothing but all instances of class share the same copy of the methoad and its data.
        static void CustomerDetailsPresentation()
        {
            int choice = 0;
            //do while loop is known as exit controlled loop,it verifies the condition after execution of statements inside the loop
            do
            {
                Console.WriteLine("Customer Personal Details");
                Console.WriteLine("1. Add Customer");//if you choose an option '1' it shows to Add Customer
                Console.WriteLine("2. View Customer");
                Console.WriteLine("3. Update Customer");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());
                
                //switch statement is a selection control mechanism which executes one case after the another till break statement appears.
                switch (choice)
                {
                    case 1: AddCustomer(); break;
                    case 2: ViewCustomer(); break;
                    case 3: UpdateCustomer(); break;
                }
            } while (choice != 4);//if neither of the above three methods
        }

        CustomerDetailBLL customerdetailBusinessLogicLayer = new CustomerDetailBLL();
        //Add customer method
        public static void AddCustomer()
         {
            //Creating object for CustomerPersonalDetail class 
            CustomerDetail customers = new CustomerDetail();

            //Reading customer name manually
             Console.Write("Enter customer name: ");
             customers.CustomerName = Console.ReadLine();

            //Reading customer Id manually
             Console.Write("Enter customer Id: ");
             customers.CustomerId = Console.ReadLine();

            //Reading mailId of customer manually
            Console.Write("Enter emailId: ");
            customers.CustomerMailId = Console.ReadLine();

            //Reading flatnumber of customer manually
            Console.Write("Enter customer FlatNumber:");
            customers.CustomerFlatNumber = int.Parse(Console.ReadLine());

            //Reading City of Customer manually
            Console.Write("Enter customer City: ");
            customers.CustomerCity = Console.ReadLine();

            //Reading Street of the Customer manually
            Console.Write("Enter customer Street: ");
            customers.CustomerStreet = Console.ReadLine();

            //Reading Customer's State manually
            Console.Write("Enter customer State:");
            customers.CustomerState = Console.ReadLine();

            //Reading Phone number of customer manually
            Console.Write("Enter customer Phone number: ");
            customers.PhoneNumber = Console.ReadLine();

            //Reading Customer's State PinCode manually
            Console.Write("Enter customer State Pincode");
            customers.CustomerPinCode = int.Parse(Console.ReadLine());
           
            //Reading Customer'Country manually
            Console.WriteLine("Enter customer Country:");
            customers.CustomerState = Console.ReadLine()); 




           // CustomerDetailBLL customerPersonaldetailBusinessLogicLayer = new CustomerDetailBLL();
            customerdetailBusinessLogicLayer.AddCustomer(customers); //call BusinessLogicLayer

             Console.WriteLine("Customer details added successfully.\n");
         }
        //View existing Customer details
         static void ViewCustomer()
         {
            // CustomerDetailBLL customerBusinessLogic = new CustomerDetailBLL();//creating object here.
            //creating list
             List<CustomerDetail> cust = customerBusinessLogic.GetCustomers();

            //getting customerdetails 
             foreach (CustomerDetail detail in cust)
             {
                 Console.WriteLine(detail);
             }
         }

        //Updating customer details
         static void UpdateCustomer()
         {
            //Creating object for BusinessLogicLayer
            // CustomerDetailBLL CustomerBusinessLogic = new CustomerDetailBLL();//creating object here.

            //Creating object for the CustomerPersonalDetail class
             CustomerDetail customer = new CustomerDetail();

            //Updating name
             Console.Write("Enter Existing Customer Name: ");
             customer.CustomerName = Console.ReadLine();
             Console.Write("Enter New Customer Name: ");
             customer.CustomerName = Console.ReadLine();

            //Updating Address
             Console.Write("Enter Existing Customer Address: ");
             customer.Address = Console.ReadLine();
             Console.Write("Enter New Customer Address: ");
             customer.Address = Console.ReadLine();

            //Updating Income
             Console.Write("Enter Existing Customer Income: ");
             customer.Income = double.Parse(Console.ReadLine());
             Console.Write("Enter New Customer Income: ");
             customer.Income = double.Parse(Console.ReadLine());

            //Updating AadharcardNumber
            Console.Write("Enter Existing Customer Aadharcardnumber: ");
            customer.AadharCardNumber = Console.ReadLine();
            Console.Write("Enter New Customer Aadharcardnumber: ");
            customer.AadharCardNumber = Console.ReadLine();

            //Updating PanCardNumber
            Console.Write("Enter Existing Customer PancardNumber: ");
            customer.PanCardNumber = Console.ReadLine();
            Console.Write("Enter New Customer Pan card number: ");
            customer.PanCardNumber = Console.ReadLine();

            //Updating Phone number
            Console.Write("Enter Existing Customer Phone number: ");
            customer.PhoneNumber = Console.ReadLine();
            Console.Write("Enter New Customer Phone number: ");
            customer.PhoneNumber = Console.ReadLine();

            //Updating Age
            Console.Write("Enter Existing Customer Age: ");
            customer.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter New Customer date of birth: ");
            customer.Age = int.Parse(Console.ReadLine());

            //Updating Mail id
            Console.Write("Enter Existing Customer Mail Id: ");
            customer.CustomerMailId = Console.ReadLine();
            Console.Write("Enter New Customer mail id: ");
            customer.CustomerMailId = Console.ReadLine();


            CustomerBusinessLogic.UpdateCustomer(customer);
             Console.WriteLine("Customer details Updated.\n");
         }
        

    }
}

