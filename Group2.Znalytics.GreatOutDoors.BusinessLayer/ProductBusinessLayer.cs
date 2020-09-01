using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoorsProduct.DataAccessLayer;
using GreatOutdoorsProduct.Entities;
using GreatOutdoorsProduct.Exceptions;
using Group2.Znalytics.GreatOutDoors.DataLayer;

/// <summary>
/// BUSINESSACCESSLAYER FOR PRODUCTS
/// </summary>
namespace GreatOutdoorsProduct.BusinessLayer
{
    /// <summary>
    /// refers to Product BusinessLogic
    /// </summary>
    public class ProductBusinessLayer : IProductBusinessLayer
    {
        //creating object for businesslayer
        ProductBusinessLayer _pb = new ProductBusinessLayer();
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

            /// <summary>
            ///methods for adding the products 
            /// </summary>
            /// <param name="n"> gets object of ProductDetails</param>
            public void AddProducts(Product p)
            {
                //product name should not be null
                //if the product name not equal to null then add product name
                if (p.ProductName != null)
                {
                 _pb.AddProducts(p);
                }
                else
                {
                   //if it is equal to null then throws an excpetion
                    throw new Exception("Add valid Product Name");
                }


            }

            /// <summary>
            /// method for updating te products
            /// </summary>
            /// <param name="updateProduct"></param>
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

              
            }
            /// <summary>
            /// Removing the products
            /// </summary>
            /// <param name="deleteProductID"></param>
            /// <returns></returns>
            public void RemoveProductByProductID(int ProductId)
            {

                try
                {   //product id should not be null
                    if (ProductId != 0)
                    {

                        _pb.RemoveProductByProductID(ProductId);
                    }
                    else
                    {
                        //if null raises an excpetion
                        throw new ProductException("Product id doesn't exists");
                    }


                }
                catch
                {
                    throw;
                }
            }
            /// <summary>
            /// Method for Removing Return by ProductID
            /// </summary>
            public void RemoveProductByProductName(string ProductName)
            {
                //product name should not be null
                if (ProductName != null)
                {
                    _pb.RemoveProductByProductName(ProductName);
                }
                else
                {
                   //if null then raises an excpetion
                    throw new ProductException("Product id doesn't exists");
                }

            }

        }
}

    