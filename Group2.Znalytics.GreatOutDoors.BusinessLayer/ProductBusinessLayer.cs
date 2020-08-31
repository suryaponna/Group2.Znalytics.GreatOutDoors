using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoorsProduct.Entities;
using GreatOutdoorsProduct.Exceptions;
using Znalytics.Group2.GreatOutDoors.DataLayer;

namespace GreatOutdoorsProduct.BusinessLayer
{
    public class ProductBusinessLayer : IProductBusinessLayer
    {
        public void AddProducts()
        {
            throw new NotImplementedException();
        }

        public void DeleteProductBl()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct()
        {
            throw new NotImplementedException();
        }

        // private static void Product(Product product);

        /// <summary>
        /// refers tp Product BusinessLogic
        /// </summary>
        public class ProductBusiness
    {

        /// <summary>
        /// adding the products 
        /// </summary>
        /// <param name="n"> gets object of ProductDetails</param>
        public void AddProducts(Product n) 
        {
            if (n.ProductName != null)
            {
                throw ex;
            }
            return Product;

        }





        public static void UpdateProduct(Product updateProduct)
        {
            bool productUpdated = false;
            try
            {
                if (Product.updateProduct)
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

            return _roductUpdated;
        }

        public static void DeleteProductBL(int deleteProductID)
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

    