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
        /// refers to Product BusinessLogic
        /// </summary>
        public class ProductBusiness
        {
            private object _pb;

            /// <summary>
            /// adding the products 
            /// </summary>
            /// <param name="n"> gets object of ProductDetails</param>
            public void AddProducts(Product n)
            {
                if (n.ProductName != null)
                {
                 _pb.AddProducts(n);
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
            /// deleting the products
            /// </summary>
            /// <param name="deleteProductID"></param>
            /// <returns></returns>
            public static void DeleteProduct(int deleteProductID)
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

            }

        }

    }
}

    