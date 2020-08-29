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
        //Adding customer details
        void AddCustomer(CustomerDetail customer);
        //Viewing details
        // void ViewCustomer(CustomerPersonalDetail customer);
        // Updating details of customer
        public List<CustomerDetail> GetCustomers()
        {
            // return cdal.GetCustomers();
        }

        void UpdateCustomer(CustomerDetail customer);

    }
}



