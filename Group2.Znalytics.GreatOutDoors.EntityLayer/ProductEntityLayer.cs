using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GreatOutdoorsProduct.Entities
{
    public class Product 
    {
        private int _productId;
        private string _productName;
        private int _categoryName;
        private int _specificationId;
        private int _costPrice;
        private double _sellingPrice;
        private bool _available;
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
        /// <summary>
        /// creating property for productName
        /// </summary>
        public string ProductName
        {
            set
            {
                ProductName = value;
            }
            get
            {
                return productName;
            }

        }

        
        /// <summary>
        /// creating property for categoryid
        /// </summary>
        public int CategoryID
        {

            set
            {
                categoryID = value;
            }
            get
            {
                return categoryID;
            }
        }
       
        /// <summary>
        /// creating property for specification id
        /// </summary>
        public int SpecificationID
        {

            set
            {
                specificationID = value;
            }
            get
            {
                return specificationID;
            }
        }

    
        /// <summary>
        /// creating property for costprice
        /// </summary>
        public double CostPrice
        {

            set
            {
                CostPrice = value;
            }
            get
            {
                return CostPrice;
            }
        }

     
        /// <summary>
        /// creating property for selling price
        /// </summary>
        public double SellingPrice
        {

            set
            {
                SellingPrice = value;
            }
            get
            {
                return SellingPrice;
            }
        }

    
        /// <summary>
        /// creating property for available products
        /// </summary>
        public bool Available
        {

            set
            {
                Available = value;
            }
            get
            {
                return Available;
            }
        }


    }
}

