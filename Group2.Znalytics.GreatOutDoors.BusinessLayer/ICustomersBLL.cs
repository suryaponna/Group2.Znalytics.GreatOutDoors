/////////////////////CREATED BY APOORVA //////////////////////

using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System.Collections.Generic;

namespace Group2.Znalytics.GreatOutDoors.BusinessLogicLayer
{
    /// <summary>
    /// Represents interface for Customer Personal Detail Businesslogiclayer
    /// </summary>
    public interface ICustomersBLL
    {
        /// <summary>
        /// method for adding customer
        /// </summary>
        /// <param name="customer"></param>
        void AddCustomer(Customer customer);


        /// <summary>
        /// method for getting customers
        /// </summary>
        /// <returns>Customer</returns>
        List<Customer> GetCustomers();


        /// <summary>
        /// returns customer based on customerId
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>Customer</returns>
        Customer GetCustomerByID(int customerID);


        /// <summary>
        /// returns customer based on customerName
        /// </summary>
        /// <param name="customerName"></param>
        /// <returns>Customer</returns>
        List<Customer> GetCustomersByName(string customerName);


        /// <summary>
        /// method to view the customer
        /// </summary>
        /// <param name="customer"></param>
        void ViewCustomer(Customer customer);


        /// <summary>
        /// method for updating the customer 
        /// </summary>
        /// <param name="customer"></param>
        void UpdateCustomer(Customer customer);


        /// <summary>
        /// method for deleting the customer
        /// </summary>
        /// <param name="customer"></param>
        void DeleteCustomer(Customer customer);
    }

}