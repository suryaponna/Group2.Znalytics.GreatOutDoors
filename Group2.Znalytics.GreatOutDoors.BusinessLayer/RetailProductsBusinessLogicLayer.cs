//CREATED BY ARCHANA

//importing systems
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2.Znalytics.GreatOutDoors.RetailProducts.DataAccessLayer;
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
        /// displaying products
        /// </summary>
        /// <returns>gets the products details</returns>
        public List<RProducts> GetRProducts()
        {
            return _rpdl.GetRProducts();
        }
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
