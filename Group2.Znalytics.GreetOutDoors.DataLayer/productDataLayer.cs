using System.Collections.Generic;
using System.ComponentModel;
using Group2.Znalytics.GreetOutDoors.Product.Entities;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    /// <summary>
    /// referes to ProductData in Property class
    /// </summary>
    public class productDataLayer 
    {

        private List<ProductDetails> ProductsList  //creating a reference varibale for List
        {
            set;
            get;
        }

        public productDataLayer() // creating a list object
        {
            ProductsList = new List<ProductDetails>();
        }

        /// <summary>
        /// adding the products in the List
        /// </summary>
        /// <param name="productDetails"></param>
        public void AddProduct(ProductDetails productDetails)
        {
            ProductsList.Add(productDetails);
        }

        /// <summary>
        /// displaying the products in the List
        /// </summary>

        public void DisplayProducts(ProductDetails product)
        {
            for (int i = 0; i < ProductsList.Count; i++)
            {
                ProductDetails n = ProductsList[i];
                System.Console.WriteLine("Product Name ={0},Product Id ={1},Price= {3}", n.ProductName, n.ProductID, n.Productprice);
            }

        }
        
        }

    }
