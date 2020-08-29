///////Apoorva////////////

using System;
using System.Collections.Generic;
using Znalytics.Group2.GreatOutDoor.Entity;

namespace Group2.Znalytics.GreetOutDoors.DataAccessLayer
{
    /// <summary>
    /// Represents interface for the customer Personal Detail DataAccessLayer
    /// </summary>
    public interface ICustomerDetailDAL
    {
        void AddCustomer(Customer customer);
        List<Customer> GetCustomers();
        Customer GetCustomerByID(string customerID);
        List<Customer> GetCustomersByName(string customerName);

        void UpdateCustomer(Customer customer);

    }
}


