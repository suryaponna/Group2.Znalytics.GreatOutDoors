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
    /// <summary>
    /// Reprsents an interface of businesslogiclayer
    /// </summary>
    internal interface IRetailProductsBusinessLogicLayer
    {
        /// <summary>
        /// Method to addproducts
        /// </summary>
        /// <param name="n">Reprsensts the object of products</param>
        void AddProducts(RProducts n);
        /// <summary>
        /// Method to get the list of products
        /// </summary>
        List<RProducts> GetRProducts();
        /// <summary>
        /// Method to remove products based on id
        /// </summary>
        /// <param name="productID">which represents productID
        ///</param>
        void RemoveProduct(string productID);
        /// <summary>
        /// method to update the products
        /// </summary>
        /// 
        void UpdateProducts(RProducts rProducts);
        /// <summary>
        /// Method to add productquantity
        /// </summary>
        /// <param name="rProducts">products objects</param>
        void AddQuantityOfProducts(RProducts rProducts);



    }
}