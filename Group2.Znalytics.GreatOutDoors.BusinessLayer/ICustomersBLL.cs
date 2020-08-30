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
        void AddCustomer(Customer customer);
        List<Customer> GetCustomers();
        Customer GetCustomerByID(string customerID);
        List<Customer> GetCustomersByName(string customerName);

        void UpdateCustomer(Customer customer);
    }

}