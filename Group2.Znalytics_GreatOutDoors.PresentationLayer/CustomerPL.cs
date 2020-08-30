using System;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreatOutDoors.BusinessLayer;


/// <summary>
/// Represents Login information of the customer
/// </summary>
class CustomerPL
{
    //Execution starts from main method
    static void Main()
    {
        CustomerPresentation();
        Console.ReadKey();//reads from keyboard
    }

    //Displaying Customers menu
    //static method is nothing but all instances of class share the same copy of the methoad and its data.
    static void CustomerPresentation()
    {
        int choice = 0;
        //do while loop is known as exit controlled loop,it verifies the condition after execution of statements inside the loop
        do
        {
            Console.WriteLine("Customer Personal Details");
            Console.WriteLine("1. Add Customer");//if you choose an option '1' it shows to Add Customer
            Console.WriteLine("2. View Customer");
            Console.WriteLine("3. Update Customer");
            Console.WriteLine("4.Delete Customer");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            //switch statement is a selection control mechanism which executes one case after the another till break statement appears.
            switch (choice)
            {
                case 1: AddCustomer(); break;//for adding customer
                case 2: ViewCustomer(); break;//for viewing customer
                case 3: UpdateCustomer(); break;//for updating customer
                case 4:DeleteCustomer();break;//for deleting customer
            }
        } while (choice != 5);//if neither of the above three methods
    }

    CustomerBLL customerBusinessLogicLayer = new CustomerBLL();
    //Add customer method
    public static void AddCustomer()
    {
        //Creating object for CustomerPersonalDetail class 
        Customer customers = new Customer();

        //Reading customer name manually
        Console.Write("Enter customer name: ");
        customers.CustomerName = Console.ReadLine();

        //Reading customer Id manually
        Console.Write("Enter customer Id: ");
        customers.CustomerId = Console.ReadLine();

        //Reading customer password manually
        Console.Write("Enter your password: ");
        customers.Password = Console.ReadLine();

        //Reading mailId of customer manually
        Console.Write("Enter emailId: ");
        customers.CustomerMailId = Console.ReadLine();

        //Reading customer gender manually
        Console.Write("Enter your gender: ");
        customers.Gender = Console.ReadLine();

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
        customers.CustomerPhoneNumber = Console.ReadLine();

        //Reading Customer's State PinCode manually
        Console.Write("Enter customer State Pincode");
        customers.CustomerPinCode = int.Parse(Console.ReadLine());

        //Reading Customer'Country manually
        Console.WriteLine("Enter customer Country");
        customers.CustomerCountry = Console.ReadLine();




        // CustomerDetailBLL customerPersonaldetailBusinessLogicLayer = new CustomerDetailBLL();
        customerBLL.AddCustomer(customers); //call BusinessLogicLayer

        Console.WriteLine("Customer details added successfully.\n");
    }
    //View existing Customer details
    static void ViewCustomer()
    {
        CustomerBLL customerBusinessLogic = new CustomerBLL();//creating bussiness layer object here.
        //creating list
        List<Customer> cust = customerBusinessLogic.ViewCustomer();//It goes to bussinesslayer and then datalayer where list is present.

        //getting customerdetails 
        foreach (Customer Item in cust)//foreach loop is to retrieve data 
        {
            Console.WriteLine(cust);//printing cust object.
        }
    }

    //Updating customer details
    static void UpdateCustomer()
    {
        //Creating object for BusinessLogicLayer
         CustomerBLL CustomerBusinessLogic = new CustomerBLL();//creating object here.

        //Creating objectfor the Customer class
        Customer customers = new Customer();

        //Updating name
        Console.Write("Enter Existing Customer Name: ");
        customers.CustomerName = Console.ReadLine();
        Console.Write("Enter New Customer Name: ");
        customers.CustomerName = Console.ReadLine();

       

      
        //Updating AadharcardNumber
        Console.Write("Enter Existing Customer Aadharcardnumber: ");
        customers.AadharCardNumber = Console.ReadLine();
        Console.Write("Enter New Customer Aadharcardnumber: ");
        customers.AadharCardNumber = Console.ReadLine();

        //Updating Phone number
        Console.Write("Enter Existing Customer Phone number: ");
        customers.PhoneNumber = Console.ReadLine();
        Console.Write("Enter New Customer Phone number: ");
        customers.PhoneNumber = Console.ReadLine();

        //Updating Age
        Console.Write("Enter Existing Customer Age: ");
        customers.Age = int.Parse(Console.ReadLine());
        Console.Write("Enter New Customer date of birth: ");
        customers.Age = int.Parse(Console.ReadLine());

        //Updating Mail id
        Console.Write("Enter Existing Customer Mail Id: ");
        customers.CustomerMailId = Console.ReadLine();
        Console.Write("Enter New Customer mail id: ");
        customers.CustomerMailId = Console.ReadLine();


        CustomerBusinessLogic.UpdateCustomer(customers);
        Console.WriteLine("Customer details Updated.\n");
    }
    static void DeleteCustomer()
{
    Console.WriteLine("Entered Customer name to be deleted");
    Console.WriteLine("Entered Customer ID to be deleted");




}
}