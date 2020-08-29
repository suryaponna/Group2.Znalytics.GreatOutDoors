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
    public class ProductBusinessLayer : IproductBusinessLogicLayer
    {
        private static bool Product(Product product)

        {
            StringBuilder sb = new StringBuilder();
            bool validProduct = true;
            if (product.ProductID <= 0)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Invalid Product ID");

            }
            if (product.ProductName == string.Empty)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Product Name Required");

            }
            if (product.CategoryID <= 0)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Invalid Category ID");

            }

            if (product.SpecificationID <= 0)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Invalid Specification ID");

            }

            if (product.CostPrice <= 0)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Invalid Cost Price");

            }

            if (product.SellingPrice <= 0)
            {
                validProduct = false;
                sb.Append(Environment.NewLine + "Invalid Selling Price");

            }

            if (validProduct == false)
                throw new ProductException(sb.ToString());
            return validProduct;
        }

        public static bool AddProductBusinessLayer(Product newProduct)
        {
            bool productAdded = false;
            try
            {
                if (Product(newProduct))
                {
                    ProductDataAccessLayer ProductDataAccessLayer = new ProductDataAccessLayer();
                    productAdded = ProductDataAccessLayer.AddProductDataAccessLayer(newProduct);
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

            return productAdded;
        }

        public static List<Product> GetAllProductsBusinessLogicLayer()
        {
            List<Product> productList = null;
            try
            {
                ProductDataAccessLayer ProductDataAccessLayer = new ProductDataAccessLayer();
                productList = ProductDataAccessLayer.GetAllProductsDataAccessLayer();
            }
            catch (ProductException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productList;
        }

        public static List<Product> GetProductsByNameBusinessLogicLayer(string productName)
        {
            List<Product> productList = null;
            try
            {
                ProductDataAccessLayer ProductDataAccessLayer = new ProductDataAccessLayer();
                productList = ProductDataAccessLayer.GetProductsByNameDataAccessLayer(productName);
                // ProductDataAccessLayer ProductDataAccessLayer = new ProductDataAccessLayer();
                //productList = ProductDataAccessLayer.AddProductDataAccessLayer(ProductName);
            }
            catch (ProductException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productList;
        }

        public static List<Product> GetProductsByCategoryBusinessLogicLayer(int categoryID)
        {
            List<Product> productList = null;
            try
            {
                ProductDataAccessLayer productDataAccessLayer = new ProductDataAccessLayer();
                productList = productDataAccessLayer.GetProductsByCategoryDataAccessLayer(categoryID);
            }
            catch (ProductException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productList;
        }
        public static Product SearchProductBL(int searchProductID)
        {
            Product searchProduct = null;
            try
            {
                ProductDataAccessLayer productDataAccessLayer = new ProductDataAccessLayer();
                searchProduct = productDataAccessLayer.SearchProductDataAccessLayer(searchProductID);
            }
            catch (ProductException ex)
            {
                throw ex;
            }
            catch (Exception ex)
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
