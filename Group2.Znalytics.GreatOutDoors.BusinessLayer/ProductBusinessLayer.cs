using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatOutdoorsProduct.DataAccessLayer;
using GreatOutdoorsProduct.Entities;
using GreatOutdoorsProduct.Exceptions;
using Group2.Znalytics.GreatOutDoors.DataLayer;


namespace GreatOutdoorsProduct.BusinessLayer
{
    public class ProductBusinessLayer : IProductBusinessLayer
    {

        ProductDataAccessLayer _pdl;
        public ProductBusinessLayer()
        {
            _pdl = new ProductDataAccessLayer();
        }

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
        /// refers to Product BusinessLogic
        /// </summary>
        

            /// <summary>
            /// adding the products 
            /// </summary>
            /// <param name="n"> gets object of ProductDetails</param>
            public void AddProducts(Product p)
            {
                if (p.ProductName != null)
                {
                 _pdl.AddProducts(p);
                }
                else
                {
                    throw new Exception("Add valid Product Name");
                }


            }

            /// <summary>
            /// updating the products
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
                {
                    if (ProductId != 0)
                    {

                        _pdl.RemoveProductByProductID(ProductId);
                    }
                    else
                    {
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

                if (ProductName != null)
                {
                    _pdl.RemoveProductByProductName(ProductName);
                }
                else
                {
                    throw new ProductException("Product id doesn't exists");
                }


            }

        }
}

    