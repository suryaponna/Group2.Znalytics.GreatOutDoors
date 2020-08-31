using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GreatOutdoorsProduct.Entities
{
    /// <summary>
    /// this class represents entity layer for product
    /// </summary>
    
    public class Product 
    {   
        /// <summary>
        /// creating private fields
        /// </summary>
        private int _productId;
        private string _productName;
        private string _categoryName;
        private int _specificationId;
        private int _costPrice;
        private double _sellingPrice;
        private bool _available;

        /// <summary>
        /// auto implemented property
        /// </summary>
      
        public Product()
        {
        }
        /// <summary>
        /// Constructor that initializes details of Product
        /// </summary>
        /// <param name="ProductID">Represents Product identity using an ID</param>
        /// <param name="ProductName">Represents the name of the product</param>
        /// <param name="categoryName">Represents the category by using name</param>
        /// <param name="SpecificationId">Represents the specification id</param>
        /// <param name="SellingPrice">Represensts the selling price of the product</param>
        /// <param name="Costprice">Represents the costprice of thr product</param>
        /// <param name="avalialble">Represents whether the product is available or not</param>

        public Product(int ProductID, string ProductName, string categoryName, double SellingPrice, int SpecificationId, string Costprice ,bool avalialble)
        {
            _productId = ProductID;
            _productName = ProductName;
            _categoryName = categoryName;
            _specificationId = SpecificationId;
            _costPrice = (int)CostPrice;
            _sellingPrice = SellingPrice;
            _available = Available;
        }
        /// <summary>
        /// creating property for product id
        /// </summary>
        public int ProductID
        {
            set
            {
                ProductID = value;
            }
            get
            {
                return ProductID;
            }

        }
        private string productName;
        public static bool updateProduct;

        /// <summary>
        /// creating property for productName
        /// </summary>
        public string ProductName
        {
            set => ProductID = value;

            get => productName;

        }


        /// <summary>
        /// creating property for categoryid
        /// </summary>
        public int CategoryID
        {

            set => CategoryID = value;
            get => CategoryID;
        }

        /// <summary>
        /// creating property for specification id
        /// </summary>
        public int SpecificationID
        {

            set => SpecificationID = value;
            get => SpecificationID;
        }


        /// <summary>
        /// creating property for costprice
        /// </summary>
        public double CostPrice
        {

            set => CostPrice = value;
            get => CostPrice;
        }


        /// <summary>
        /// creating property for selling price
        /// </summary>
        public double SellingPrice
        {

            set => SellingPrice = value;
            get => SellingPrice;
        }


        /// <summary>
        /// creating property for available products
        /// </summary>
        public bool Available
        {

            set => Available = value;
            get => Available;
        }

        private string product;

        public string GetProduct()
        {
            return product;
        }

        public void SetProduct(string value)
        {
            product = value;
        }
    }
}

