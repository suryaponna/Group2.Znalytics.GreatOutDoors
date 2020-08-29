using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GreatOutdoorsProduct.Entities
{
    public class Product
    {
        private int productID;
        /// <summary>
        /// creating property for product id
        /// </summary>
        public int ProductID
        {
            set
            {
                productID = value;
            }
            get
            {
                return productID;
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

        private int categoryID;
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
        private int specificationID;
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

        private double costPrice;
        /// <summary>
        /// creating property for costprice
        /// </summary>
        public double CostPrice
        {

            set
            {
                costPrice = value;
            }
            get
            {
                return costPrice;
            }
        }

        private double sellingPrice;
        /// <summary>
        /// creating property for selling price
        /// </summary>
        public double SellingPrice
        {

            set
            {
                sellingPrice = value;
            }
            get
            {
                return sellingPrice;
            }
        }

        private Boolean available;
        /// <summary>
        /// creating property for available products
        /// </summary>
        public Boolean Available
        {

            set
            {
                available = value;
            }
            get
            {
                return available;
            }
        }



    }
}

