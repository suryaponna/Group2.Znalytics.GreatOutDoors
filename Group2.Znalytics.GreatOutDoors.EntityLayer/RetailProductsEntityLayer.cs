using Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.RetailProducts.EntityLayer
{
    public class RProducts
    {
        List<string> _products;
        private string _productID;
        private double _cost;
        private int _quantityofProducts;
        private string _suppliers;
        private string _damagedProducts;
        /// <summary>
        /// AutoImplemented property for 
        /// </summary>
        public RProducts()
        {
        }
        public RProducts(List<string> RetailProducts, string ProductID, int QuantityOfProducts, double Cost, string Suppliers, string DamagedProducts)
        {
            _products = RetailProducts;
            _productID = ProductID;
            _cost = Cost;
            _suppliers = Suppliers;
            _damagedProducts = DamagedProducts;
        }
        /// <summary>
        /// property for RetailProducts
        /// </summary>
        public List<string> RetailProducts
        {
            set
            {
                if (value != null)
                {
                    _products = value;
                }
                else
                {
                    throw new RetailstoreException("Select products");
                }
            }

            get
            {
                return _products;
            }
        }
        public string ProductID
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    bool spaceFound = value.Contains(" ");
                    bool atFound = value.Contains("@");
                    bool commaFound = value.Contains(",");
                    bool dotFound = value.Contains(".");
                    if (!spaceFound && !atFound && !commaFound && !dotFound && value.StartsWith("ZRS") && value.Length <= 8)
                    {
                        _productID = value;
                    }

                }
                else
                {
                    throw new RetailstoreException("Product ID not be null");
                }
            }

            get
            {
                return _productID;
            }
        }


        /// <summary>
        ///property for QuantityofProducts measn we have to add how much products we want
        /// </summary>
        public int QuantityOfProducts
        {
            set
            {
                _quantityofProducts = value;
            }
            get
            {
                return _quantityofProducts;
            }
        }
        /// <summary>
        ///property for Cost of the products
        /// </summary>
        public double Cost
        {
            set
            {
                _cost = value;
            }
            get
            {
                return _cost;
            }
        }

        /// <summary>
        /// property for Suppliers 
        /// </summary>

        public string Suppliers
        {
            set
            {
                _suppliers = value;
            }
            get
            {
                return _suppliers;
            }
        }
        /// <summary>
        ///property for Damaged Products
        /// </summary>
        public string DamagedProducts
        {
            set
            {
                _damagedProducts = value;
            }
            get
            {
                return _damagedProducts;
            }
        }

        public void RemoveProduct(string productID)
        {
            throw new NotImplementedException();
        }
    }
}
