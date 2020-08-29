/////////////////////CREATED BY APOORVA //////////////////////

using System;
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
    public interface ICustomerDetailBLL
    {
        //Adding details
        void AddCustomer(CustomerDetail customer);

        //Viewing existing details
        void ViewCustomer(CustomerDetail customer);

        //customer GetCustomerByCustomerId(string CustomerID);

        //Updating customer details
        void UpdateCustomer(CustomerDetail customer);
    }

}