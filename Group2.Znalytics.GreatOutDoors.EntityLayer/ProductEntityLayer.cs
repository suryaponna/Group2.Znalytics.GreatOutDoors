using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GreatOutdoorsProduct.Entities
{
    public class Product
    {
        
        /// <summary>
        /// creating property for product id
        /// </summary>
        public int _productID
        {
            set
            {
                _productID = value;
            }
            get
            {
                return _productID;
            }

        }
        
        /// <summary>
        /// creating property for productName
        /// </summary>
        public string _productName
        {
            set
            {
              _productName = value;
            }
            get
            {
                return _productName;
            }

        }

        /// <summary>
        /// creating property for categoryid
        /// </summary>
        public int _categoryID
        {

            set
            {
                _categoryID = value;
            }
            get
            {
                return _categoryID;
            }
        }
        
        /// <summary>
        /// creating property for specification id
        /// </summary>
        public int _specificationID
        {

            set
            {
                _specificationID = value;
            }
            get
            {
                return _specificationID;
            }
        }

        
        /// <summary>
        /// creating property for costprice
        /// </summary>
        public double _costPrice
        {

            set
            {
                _costPrice = value;
            }
            get
            {
                return _costPrice;
            }
        }

        
        /// <summary>
        /// creating property for selling price
        /// </summary>
        public double _sellingPrice
        {

            set
            {
                _sellingPrice = value;
            }
            get
            {
                return _sellingPrice;
            }
        }

        
        /// <summary>
        /// creating property for available products
        /// </summary>
        public Boolean _available
        {

            set
            {
                _available = value;
            }
            get
            {
                return _available;
            }
        }



    }
}

