///////Apoorva////////////
/**
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    /// <summary>
    /// Represents interface for the customer Personal Detail DataAccessLayer
    /// </summary>
    public interface ICustomerDAL
    {/// <summary>
    ///method for adding customer
    /// </summary>
    /// <param name="customer"></param>
        void AddCustomer(Customer customer);
        List<Customer> GetCustomers();
        /// <summary>
        /// getting details of customer by using customerId
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        
        List<Customer> GetCustomersByName(string customerName);
        /// <summary>
        /// updating detail of customer by using customerid 
        /// </summary>
        /// <param name="customers"></param>
        void UpdateCustomer(Customer customers);

        /// <summary>
        /// deleting detail of customer by using customerid
        /// </summary>
        /// <param name="customerID"></param>
        void DeleteCustomer(int customerID);
    }
}
*/

