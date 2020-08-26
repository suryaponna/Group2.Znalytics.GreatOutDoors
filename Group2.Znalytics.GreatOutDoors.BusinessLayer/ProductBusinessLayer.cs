using Group2.Znalytics.GreetOutDoors.DataLayer;

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

        public void DisplayProductss(ProductDetails n)
        {
            productDataLayer d = new productDataLayer();
            d.DisplayProducts(n);

        }


    }
}