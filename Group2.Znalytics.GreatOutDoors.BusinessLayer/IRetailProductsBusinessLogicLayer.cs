//Importing Statements
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer;
using Group2.Znalytics.GreatOutDoors.RetailProducts.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.RetailProducts.BusinessLogicLayer
{
    internal interface IRetailProductsBusinessLogicLayer
    {
        void AddProducts(RProducts n);

        List<RProducts> GetRProducts();
        void RemoveProduct(string productID);
        void UpdateProducts(RProducts rProducts);
        void AddQuantityOfProducts(RProducts rProducts);



    }
}