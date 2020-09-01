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
using System.CodeDom;
/// <summary>
/// data access layer for products
/// </summary>
namespace GreatOutdoorsProduct.DataAccessLayer
{
    public class ProductDataAccessLayer
    {

        private static List<Product> _Product;
        private static List<Product> productList = new List<Product>();

        /// <summary>
        /// Constructor Return Data Access Logic that initializes collection
        /// </summary>
        static ProductDataAccessLayer() =>
            //creating a list 
            _Product = new List<Product>()
            {
                new Product{ProductID=123 ,ProductName="shoes" ,Available=true },
                new Product{ProductID=2345 ,ProductName="hats" ,Available=true },
                new Product{ProductID=5637 ,ProductName="books" ,Available=false}
            };// _return = LoadDetailsToList();


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
                ///<summary>
                ///adding new products into the list
                ///</summary>
                productList.Add(newProduct);
                productAdded = true;//if added it would show as true
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);//thrown an expection when it doesnot add a product
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
                    ///<summary>
                    ///if the product id is eual to searching product then returns the item
                    ///</summary>
                    if (item.ProductID == searchProductID)
                    {
                        searchProduct = item;
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);//Throws an Exception Statement  when condition is false
            }
            return searchProduct;//returning the item which is found
        }
        private static void SaveIntoFile()
        {
            //convert data into Json
            string s = JsonConvert.SerializeObject(productList);
            //write the data into the file
            StreamWriter streamWriter = new StreamWriter(@"C: \Users\Administrator\Desktop\aa");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        /// <summary>
        /// Reading the data from json file and return data in the file in the form List format
        /// </summary>
        /// <returns>returns list of details present in Product </returns>
        public static List<Product> GetFileData()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\source\repos\RetailStoreData");
            string s1 = streamReader.ReadToEnd();
            List<Product> p = JsonConvert.DeserializeObject<List<Product>>(s1);
            streamReader.Close();
            return p;
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
                ///<summary>
                ///checks for the condition
                ///</summary>
                foreach (Product item in productList)
                {
                    if (item.ProductName == productName)//if given product name matches with the product name then returns the item
                    {
                        searchProduct.Add(item);//adding an item
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);//if not found throwns an exception
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
                //checks for the condition
                foreach (Product item in productList)
                {
                    if (item.CategoryID == categoryID) //if given category id matches with the category id then returns the item
                    {
                        searchProduct.Add(item);//adding an item
                    }
                }
            }
            catch (SystemException ex)
            {
                throw new ProductException(ex.Message);//when it is fale throws and expection
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
                ///<summary>
                ///checks for the condition 
                ///</summary>
                for (int i = 0; i < productList.Count; i++)
                {
                    if (productList[i].ProductID == updateProduct.ProductID)
                        ///<summary>
                        ///if the five if contation satisfies then it will update the products
                        ///</summary>
                    {
                        updateProduct.ProductName = productList[i].ProductName;//updating the product name
                        updateProduct.CategoryID = productList[i].CategoryID;//updation product category
                        updateProduct.SpecificationID = productList[i].SpecificationID;//updating specification id
                        updateProduct.CostPrice = productList[i].CostPrice;//updating costprice
                        updateProduct.SellingPrice = productList[i].SellingPrice;//updating selling price
                        updateProduct.Available = productList[i].Available;//updating the products whether they are available or not
                        productUpdated = true;//finally all products are updated then it shows true if not false
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
            productList.RemoveAll(temp => temp.ProductID == ProductId); //inline lambda expression

        }
        /// <summary>
        /// Method for removing Return by product name
        /// </summary>
        public void RemoveProductByProductName(string ProductName)// Removing a Product By using Product Name
        {

            productList.RemoveAll(temp => temp.ProductName == ProductName);//inline lamba expression
        }
    }
}


