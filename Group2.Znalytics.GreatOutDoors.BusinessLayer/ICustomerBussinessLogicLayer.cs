/////////////////////CREATED BY APOORVA //////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Znalytics.Group2.GreatOutDoor.Entity;

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