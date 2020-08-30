using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoorsProduct.Entities;
using GreatOutdoorsProduct.Exceptions;
using GreatOutdoorsProduct.DataAccessLayer;

namespace GreatOutdoorsProduct.BusinessLayer
{
    public class ProductBusinessLayer : IProductBusinessLayer
    {
        private static bool Product(Product product)

    /// <summary>
    /// refers tp Product BusinessLogic
    /// </summary>
    public class ProductBusiness
    {

        /// <summary>
        /// adding the products 
        /// </summary>
        /// <param name="n"> gets object of ProductDetails</param>
        public void AddProducts(ProductDetails n)
        {
            if (n.ProductName != null)
            {
                throw ex;
            }
            return searchProduct;

        }



        public static bool UpdateProductBL(Product updateProduct)
        {
            bool productUpdated = false;
            try
            {
                if (ValidateProduct(updateProduct))
                {
                    ProductDataAccessLayer productDataAccessLayer = new ProductDataAccessLayer();
                    productUpdated = productDataAccessLayer.UpdateProductDataAccessLayer(updateProduct);
                }
            }
            catch (ProductException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productUpdated;
        }

        public static bool DeleteProductBL(int deleteProductID)
        {
            bool productDeleted = false;
            try
            {
                if (deleteProductID > 0)
                {
                    ProductDataAccessLayer productDataAccessLayer = new ProductDataAccessLayer();
                    productDeleted = productDataAccessLayer.DeleteProductDataAccessLayer(deleteProductID);
                }
                else
                {
                    throw new ProductException("Invalid Product ID");
                }
            }
            catch (ProductException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return productDeleted;
        }

    }

}
