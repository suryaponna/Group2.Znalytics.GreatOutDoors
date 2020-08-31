using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GreatOutdoorsProduct.Entities;
using GreatOutdoorsProduct.Exceptions;
using Newtonsoft.Json;
using System.IO;
/// <summary>
/// data access layer for products
/// </summary>
namespace GreatOutdoorsProduct.DataAccessLayer
{
    public class ProductDataAccessLayer
    {
        //private fields
        private static List<Product> productList = new List<Product>();
        /// <summary>
        /// method to add products into the list
        /// </summary>
        /// <param name="newProduct"></param>
        /// <returns></returns>
        public bool AddProducts(Product newProduct)
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
        private static void SaveIntoFile()
        {
            string s = JsonConvert.SerializeObject(productList);
            //write the data into the file
            StreamWriter streamWriter = new StreamWriter(@"C: \Users\Administrator\Desktop\aa");
            streamWriter.Write(s);
            streamWriter.Close();
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
        ///  Method for Removing Return by ProductID
        /// </summary>
        public void RemoveProductByProductID(int ProductId) //Removing a Product by using Product ID
        {
            productList.RemoveAll(temp => temp.ProductID == ProductId); ;

        }
        /// <summary>
        /// Method for removing Return by product name
        /// </summary>
        public void RemoveProductByProductName(string ProductName)// Removing a Product By using Product Name
        {

            productList.RemoveAll(temp => temp.ProductName == ProductName);
        }
    }
}

