//CREATED BY ARCHANA

//importing systems
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2.Znalytics.GreatOutDoors.RetailProducts.DataAccessLayer;
using Group2.Znalytics.GreatOutDoors.DataAccessLayer;
using Group2.Znalytics.GreatOutDoors.RetailProducts.EntityLayer;
using Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer;

//Created a namespace for businessLayer of RetailProducts 
namespace Group2.Znalytics.GreatOutDoors.RetailProducts.BusinessLogicLayer
{
    /// <summary>
    /// Represensts business logic clas of RetailProducts.It implenments an interface of
    /// </summary>
    public class RetailProductsBusinessLogicLayer : IRetailProductsBusinessLogicLayer
    {
        //Created an object for dataacceslayer and stored it in reference variable
        RetailProductsDataAccessLayer _rpdl;

        public RetailProductsBusinessLogicLayer()
        {
            _rpdl = new RetailProductsDataAccessLayer();
        }
        //RetailProductsDataAccessLayer rpdl = new RetailProductsDataAccessLayer();
        /// <summary>
        /// Method to add products into the list
        /// </summary>
        /// <param name="n">Represents the products object</param>
        public void AddProducts(RProducts n)
        {
            try
            {
                if (n.RetailProducts != null)
                {
                    _rpdl.AddProducts(n);
                }
            }
            catch (RetailstoreException ex)
            {
                throw;
            }
        }
        /// <summary>
        /// Method to get added details
        /// </summary>
        /// <returns>it returns the list products details</returns>
        public List<RProducts> GetRProducts()
        {
            return _rpdl.GetRProducts();
        }
        /// <summary>
        /// Method to remove product based on productID
        /// </summary>
        /// <param name="productID">Represents productID</param>
        public void RemoveProduct(string productID)
        {
            if (productID != null)
            {
                _rpdl.RemoveProduct(productID);
            }
            else
            {
                throw new RetailstoreException();
            }
        }
        /// <summary>
        /// Method to get products by productID
        /// </summary>
        /// <param name="ProductID">Represents the productID</param>
        /// <returns>Returns the productID</returns>
        public RProducts GetProductsByID(string ProductID)
        {
            return _rpdl.GetProductsByID(ProductID);
        }
        public void UpdateProducts(RProducts rProduct)
        {
            if (rProduct.RetailProducts != null)
            {
                _rpdl.UpdateProduct(rProduct);
            }
            else
            {
                throw new RetailstoreException();
            }

        }
        /// <summary>
        /// Add quantity of products into the list
        /// </summary>
        /// <param name="rProducts">Reprsents product object</param>
        public void AddQuantityOfProducts(RProducts rProducts)
        {
            if (rProducts.RetailProducts != null)
            {
                _rpdl.AddQuantityOfProducts(rProducts);
            }
            else
            {
                throw new RetailstoreException();
            }

        }
        /// <summary>
        /// Checking weather product is present in the list and return a bool value
        /// </summary>
        /// <param name="productID">gets the product id from user</param>
        public bool CheckProductID(string productID)
        {
            return _rpdl.CheckProductID(productID);
        }

        public void UpdateProduct(RProducts rProducts)
        {
            throw new NotImplementedException();
        }


    }
}
