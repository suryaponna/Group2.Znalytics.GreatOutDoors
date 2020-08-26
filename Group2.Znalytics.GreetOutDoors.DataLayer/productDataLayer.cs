using System;
using System.Collections;
using System.Collections.Generic;
using Group2.Znalytics.GreetOutDoors.Product.Entities;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    /// <summary>
    /// referes to ProductData in Property class
    /// </summary>
    public class productDataLayer : IEnumerable, IList
    {

        private List<ProductDetails> ProductsList  //creating a reference varibale for List
        {
            set;
            get;
        }

        public bool IsReadOnly => ((IList)ProductsList).IsReadOnly;

        public bool IsFixedSize => ((IList)ProductsList).IsFixedSize;

        public int Count => ((ICollection)ProductsList).Count;

        public object SyncRoot => ((ICollection)ProductsList).SyncRoot;

        public bool IsSynchronized => ((ICollection)ProductsList).IsSynchronized;

        public object this[int index] { get => ((IList)ProductsList)[index]; set => ((IList)ProductsList)[index] = value; }

        public productDataLayer() // creating a list object
        {
            ProductsList = new List<ProductDetails>();
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < ProductsList.Count; i++)
            {
                yield return ProductsList[i];

            }
        }
       public void AddProduct(ProductDetails productDetails)
       {
                ProductsList.Add(productDetails);
       }


            /// <summary>
            /// adding the products in the List
            /// </summary>
            /// <param name="productDetails"></param>


            /// <summary>
            /// displaying the products in the List
            /// </summary>

            public void DisplayProducts(ProductDetails product)
            {
                for (int i = 0; i < ProductsList.Count; i++)
                {
                    ProductDetails n = ProductsList[i];
                    System.Console.WriteLine("Product Name ={0},Product Id ={1},Price= {3}", n.ProductName, n.ProductID, n.Productprice);
                }

            }

        public int Add(object value)
        {
            return ((IList)ProductsList).Add(value);
        }

        public bool Contains(object value)
        {
            return ((IList)ProductsList).Contains(value);
        }

        public void Clear()
        {
            ((IList)ProductsList).Clear();
        }

        public int IndexOf(object value)
        {
            return ((IList)ProductsList).IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            ((IList)ProductsList).Insert(index, value);
        }

        public void Remove(object value)
        {
            ((IList)ProductsList).Remove(value);
        }

        public void RemoveAt(int index)
        {
            ((IList)ProductsList).RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
            ((ICollection)ProductsList).CopyTo(array, index);
        }
    }

    }
}
