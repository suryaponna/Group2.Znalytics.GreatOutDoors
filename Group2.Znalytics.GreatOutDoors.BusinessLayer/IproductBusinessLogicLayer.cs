using GreatOutdoorsProduct.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    interface IproductBusinessLogicLayer
    {
        void AddProductID(Product rsid);
        List<Product> GetRetailStoreIDs();
        Product GetProductID(int ProductID);
    }
}
