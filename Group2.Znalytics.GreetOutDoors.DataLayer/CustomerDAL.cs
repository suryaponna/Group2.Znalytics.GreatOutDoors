using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Group2.Znalytics.GreetOutDoors.DataLayer;

namespace Group2.Znalytics.GreatOutDoors.DataLayer

{
    /// <summary>
    /// Represents Data Access Layer of  the customer details
    /// </summary>
    public class CustomerDAL : ICustomerDAL
    {
        //private fields
        private static List<Customer> _customers;
        //static field of DataccessLayer
        static CustomerDAL()
        {
            _customers = new List<Customer>();

            //code for loading data from file into _customers
        }

        //Adding Customer Personal Details
        public void AddCustomer(Customer customer)
        {
            //generate new customer id
            if (_customers.Count == 0)
            {
                customer.CustomerId = 1;
            }
            else
            {
                customer.CustomerId = _customers.Max(temp => temp.CustomerId) + 1;//using LINQ
            }

            //add customer object to the collection
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
            if (cust != null)
            {
                cust.CustomerName = customer.CustomerName;
            }
        }

        /// <summary>
        /// Get customer based on specified ID
        /// </summary>
        /// <param name="customerID">CustomerID to search</param>
        /// <returns>Returns matching customer</returns>
        public Customer GetCustomerByCustomerID(int CustomerId)
        {
            Customer cust = _customers.Find(temp => temp.CustomerId == CustomerId);
            return cust;

        }
        //JSON is used for converting object to text format
        public void ListOfCustomers()
        {
            List<Customer> _return = new List<Customer>();
            //convert data into Json
            string s = JsonConvert.SerializeObject(_customers);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C: \Users\Administrator\Desktop");
            streamWriter.Write(s);
            streamWriter.Close();


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

        public void DeleteCustomer(int customerID)
        {
            _customers.RemoveAll(temp => temp.CustomerId == customerID);
        }

        public Customer GetCustomerByCustomerId(int customerID)
        {
            throw new System.NotImplementedException();
        }
    }
}




