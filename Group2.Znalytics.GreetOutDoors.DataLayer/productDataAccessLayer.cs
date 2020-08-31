using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GreatOutdoorsProduct.Entities;
using GreatOutdoorsProduct.Exceptions;
/// <summary>
/// data access layer for products
/// </summary>
namespace GreatOutdoorsProduct.DataAccessLayer
{
    public class ProductDataAccessLayer
    {   
        //private fields
        public static List<Product> productList = new List<Product>();
       
        /// <summary>
        /// adding products
        /// </summary>
        /// <param name="newProduct"></param>
        /// <returns></returns>
        public bool AddProductDataAccessLayer(Product newProduct)
        {
            bool productAdded = false;
            try
            {
                productList.Add(newProduct);
                productAdded = true;
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);
            }
            return productAdded;

        }


        //getting productdetails
        public List<Product> GetAllProductsDataAccessLayer()
        {
            return productList;
        }
        /// <summary>
        /// searching products
        /// </summary>
        /// <param name="searchProductID"></param>
        /// <returns></returns>
        public Product SearchProductDataAccessLayer(int searchProductID)
        {
            Product searchProduct = null;
            try
            {
                foreach (Product item in productList)
                {
                    if (item.ProductID == searchProductID)
                    {
                        searchProduct = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);
            }
            return searchProduct;
        }
        /// <summary>
        /// this method is for getting products by name
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public List<Product> GetProductsByNameDataAccessLayer(string productName)
        {
            List<Product> searchProduct = new List<Product>();
            try
            {
                foreach (Product item in productList)
                {
                    if (item.ProductName == productName)
                    {
                        searchProduct.Add(item);
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);
            }
            return searchProduct;
        }
        /// <summary>
        /// this method is for getting product categories
        /// </summary>
        /// <param name="categoryID"></param>
        /// <returns></returns>
        public List<Product> GetProductsByCategoryDataAccessLayer(int categoryID)
        {
            List<Product> searchProduct = new List<Product>();
            try
            {
                foreach (Product item in productList)
                {
                    if (item.CategoryID == categoryID)
                    {
                        searchProduct.Add(item);
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);
            }
            return searchProduct;
        }
        /// <summary>
        /// this method is for updating the products
        /// </summary>
        /// <param name="updateProduct"></param>
        /// <returns></returns>
        public bool UpdateProductDataAccessLayer(Product updateProduct)
        {
            bool productUpdated = false;
            try
            {
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].ProductID == updateProduct.ProductID)
                    {
                        updateProduct.ProductName = productList[i].ProductName;
                        updateProduct.CategoryID = productList[i].CategoryID;
                        updateProduct.SpecificationID = productList[i].SpecificationID;
                        updateProduct.CostPrice = productList[i].CostPrice;
                        updateProduct.SellingPrice = productList[i].SellingPrice;
                        updateProduct.Available = productList[i].Available;
                        productUpdated = true;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);
            }
            return productUpdated;

        }
        /// <summary>
        /// this method is for deleting the products
        /// </summary>
        /// <param name="deleteProductID"></param>
        /// <returns></returns>
        public bool DeleteProductDataAccessLayer(int deleteProductID)
        {
            bool productDeleted = false;
            try
            {
                Product deleteProduct = null;
                foreach (Product item in productList)
                {
                    if (item.ProductID == deleteProductID)
                    {
                        deleteProduct = item;
                    }
                }

                if (deleteProduct != null)
                {
                    productList.Remove(deleteProduct);
                    productDeleted = true;
                }
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);
            }
            return productDeleted;

        }

    }
}
