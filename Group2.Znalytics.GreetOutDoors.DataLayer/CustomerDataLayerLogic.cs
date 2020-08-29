using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
namespace Znalytics.Group2.GreatOutDoor.Entity

{
    /// <summary>
    /// Represents Data Access Layer of  the customer Personal details
    /// </summary>
    public class CustomerDetailDAL : ICustomerDetailDAL
    {
        //private fields
        //private static List<CustomerPersonalDetail> _customers;

        List<CustomerDetail> customerdetail = new List<CustomerDetail>();

        //Adding Customer Personal Details
        public void AddCustomer(CustomerDetail customer)
        {
            customerdetail.Add(customer);
        }

        //Getting existing Customer details
        public void ViewCustomer(CustomerDetail customer)
        {
            List<CustomerDetail> GetCustomers()
            {
                return customerdetail;
            }
        }

        //Updation of customer details
        public void UpdateCustomer(CustomerDetail customer)
        {
            //Get matching customer based on CustomerId
            CustomerDetail cust = customerdetail.Find(temp => temp.CustomerId == customer.CustomerId);
            if (customer != null)
            {
                customer.CustomerName = customer.CustomerName;
            }
        }
    }
}

}