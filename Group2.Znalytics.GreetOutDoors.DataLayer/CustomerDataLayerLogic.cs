using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Group2.Znalytics.GreetOutDoors.DataAccessLayer;

namespace Znalytics.Group2.GreatOutDoor.DAL

{
    /// <summary>
    /// Represents Data Access Layer of  the customer Personal details
    /// </summary>
    public class CustomerDAL : ICustomerDetailDAL
    {
        //private fields
        private static List<Customer> _customers;

        static CustomerDAL()
        {
            _customers = new List<Customer>();
        }

        //Adding Customer Personal Details
        public void AddCustomer(Customer customer)
        {
            //gerneate new customer id
            //customer.CustomerId = ??
            _customers.Add(customer);
        }

        //Getting existing Customer details
        public List<Customer> GetCustomers()
        {
            return _customers;
        }

        //Updation of customer details
        public void UpdateCustomer(Customer customer)
        {
            //Get matching customer based on CustomerId
            Customer cust = _customers.Find(temp => temp.CustomerId == customer.CustomerId);
            if (customer != null)
            {
                customer.CustomerName = customer.CustomerName;
            }
        }

        /// <summary>
        /// Get customer based on specified ID
        /// </summary>
        /// <param name="customerID">CustomerID to search</param>
        /// <returns>Returns matching customer</returns>
        public Customer GetCustomerByID(string customerID)
        {
            Customer cust = _customers.Find(temp => temp.CustomerId == customerID);
            return cust;
        }

        /// <summary>
        /// Returns list of customers based on given customer name
        /// </summary>
        /// <param name="customerName">Customer name to search</param>
        /// <returns>List of matching customers</returns>
        public List<Customer> GetCustomersByName(string customerName)
        {
            List<Customer> cust = _customers.FindAll(temp => temp.CustomerName == customerName);
            return cust;
        }
    }
}

