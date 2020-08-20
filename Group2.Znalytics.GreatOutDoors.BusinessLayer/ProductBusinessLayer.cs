using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Group2.Znalytics.GreetOutDoors.Product.Entities;

namespace Group2.Znalytics.GreetOutDoors.Product.Entities
{

    /// <summary>
    /// refers tp Product BusinessLogic
    /// </summary>
    public class ProductBusiness
    {

        /// <summary>
        /// adding the products 
        /// </summary>
        /// <param name="n"> gets object of ProductDetails</param>
        public void AddProducts(ProductDetails n)
        {
            if (n.ProductName != null)
            {
                productDataLayer d = new productDataLayer();
                d.AddProduct(n);
            }
        }
        /// <summary>
        /// displaying the products
        /// </summary>
        /// <param name="n">gets object of ProductDeatils</param>

        public void DisplayProducts(ProductDetails n)
        {
            Productdata d = new Productdata();
            d.DisplayProducts(n);

        }


    }
}