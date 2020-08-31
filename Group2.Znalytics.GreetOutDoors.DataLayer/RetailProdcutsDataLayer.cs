using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Group2.Znalytics.GreatOutDoors.RetailProducts.EntityLayer;
using Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer;

//Created namespace for products in data access layer
namespace Group2.Znalytics.GreatOutDoors.RetailProducts.DataAccessLayer
{
    public class RetailProductsDataAccessLayer
    {
        /// <summary>
        /// creating a private list of product class
        /// </summary>
        private static List<RProducts> _productList
        {
            set;
            get;
        }
        /// <summary>
        /// static constructor to initialize
        /// </summary>
        static RetailProductsDataAccessLayer()
        {
            _productList = new List<RProducts>()
            {
                new RProducts(){ProductID="ZRSPID10"}
            };
            if (_productList.Count == 0)
            {
                _productList = GetFiledata();
            }

        }
        /// <summary>
        /// Adding products into the list
        /// </summary>
        /// <param name="rProducts">object of product class</param>
        public void AddProducts(RProducts rProducts)
        {
            _productList.Add(rProducts);
            SaveIntoFile();
        }
        /// <summary>
        /// Displaying the products in the list
        /// </summary>
        public List<RProducts> GetRProducts() => _productList;
        public void RemoveProduct(string id) => _productList.RemoveAll(r => r.ProductID == id);
        public RProducts GetProductsByID(string productID)
        {
            RProducts p;
            p = _productList.Find(r => r.ProductID == productID);
            return p;
        }
        /// <summary>
        /// Checking the product exists or not in the list
        /// </summary>
        /// <param name="productID"></param>
        /// <returns>returns the product id</returns>
        public bool CheckProductID(string productID)
        {
            return _productList.Exists(r => r.ProductID == productID);
        }
        /// <summary>
        /// Saving the data into the Json file
        /// </summary>
        public void SaveIntoFile()
        {
            string s = JsonConvert.SerializeObject(_productList);
            //write data into the file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\source\repos\RetailStoreData.txt");
            streamWriter.Write(s);
            streamWriter.Close();
        }
        public static List<RProducts> GetFiledata()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\source\repos\RetailStoreData.txt");
            string s2 = streamReader.ReadToEnd();
            List<RProducts> rProducts = JsonConvert.DeserializeObject<List<RProducts>>(s2);
            streamReader.Close();
            return rProducts;
        }
        public void UpdateProduct(RProducts rProducts)
        {
            RProducts p = _productList.Find(r => r.ProductID == rProducts.ProductID);
            if (p != null)
            {
                p.RetailProducts = rProducts.RetailProducts;
                SaveIntoFile();
            }
        }
        public void AddQuantityOfProducts(RProducts retailProducts)
        {
            _productList.Add(retailProducts);
            SaveIntoFile();
        }
    }
}
