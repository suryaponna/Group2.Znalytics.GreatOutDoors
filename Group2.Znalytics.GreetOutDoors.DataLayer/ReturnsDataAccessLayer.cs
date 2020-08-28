using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;
//Created by K.Prasanna
/// <summary>
/// This class represents DataAccess Layer for Return
/// </summary>
using Group2.Znalytics.GreatOutDoors.EntityLayer;
//using Group2.Znalytics.GreatOutDoors.IDataLayer;
using System.Collections;

namespace Group2.Znalytics.GreatOutDoors.DataLayer
{
    public class ReturnsDataAccessLayer : IEnumerable
    {
        private static List<Return> _return;
        /// <summary>
        /// Constructor Return Data Access Logic that initializes collection
        /// </summary>
        static ReturnsDataAccessLayer()
        {
            //creating a list 
            _return = new List<Return>();
            
        }
        
        public void AddReturn(Return rm)// 
        {
            _return.Add(rm);
        }
        /// <summary>
        ///  To Exchange a product
        /// </summary>
        /// <param name="rm"></param>
        public void ExchangeProduct(Return rm)
        {
            
              _return.ExchangeProduct(rm);
            throw new ReturnException("Product can be exchanged within 1 month of purchased date");

            
        }


        public IEnumerator GetEnumerator()
        {
            for(int i=0;i<_return.Count;i++)
            {
                yield return _return[i];
            }
        }

        public List<Return> GetReturns()
        {
           return  _return;

        }
        public void RemoveReturnByProductID(int id) //Removing a Product by using Product ID
        {
            //_return.RemoveAll();

        }

        public void RemoveReturnByProductName(string name)// Removing a Product By using Product Name
        {
           
            
            if(_return.RemoveAll(p => p.ProductName == name))
            {
                 _return.RemoveAll(p => p.ProductName == name);
            }
            else
            {
                throw new ReturnException("Product name can't be null");
            }
            
        }
       


    }

}
