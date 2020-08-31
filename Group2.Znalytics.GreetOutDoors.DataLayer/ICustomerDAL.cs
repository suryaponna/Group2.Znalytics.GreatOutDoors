///////Apoorva////////////

using System;
using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    /// <summary>
    /// Represents interface for the customer Personal Detail DataAccessLayer
    /// </summary>
    public interface ICustomerDAL
    {
        void AddCustomer(Customer customer);
        List<Customer> GetCustomers();
        Customer GetCustomerByCustomerID(string customerID);
        List<Customer> GetCustomersByName(string customerName);

        void UpdateCustomer(Customer customers);
        void DeleteCustomer(string customerID);
    }
}


