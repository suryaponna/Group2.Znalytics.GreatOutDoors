using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    interface IOrderBusinessLayer
    {
        //Get Order Details
        List<OrderProduct> GetOrderProducts();
        //Get orderDetails by productId
        List<OrderProduct> GetOrderDetailsByProductID(string value);
        //get OrderDetails by AddressID
        List<OrderProduct> GetOrderDetailsByAddressID(string Value);
        //Get OrderDetailsByEmployeeID
        List<OrderProduct> GetOrderDetailsByEMployeeID(int value);
    }
}
