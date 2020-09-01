
using GreatOutdoorsProduct.Entities;
using System.Collections.Generic;

namespace GreatOutdoorsProduct.BusinessLayer
{
    public interface IProductBusinessLayer
    {
        void AddProducts();       
        void UpdateProduct();
        void DeleteProductBl();
        List<Product> DisplayProducts();
        Product GetProductByProductID(string productID);
    }
}