using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    interface IOrderDataLayer
    {
        void AddOrder(OrderProduct order);
        List<OrderProduct> GetFileData();
    }
}
