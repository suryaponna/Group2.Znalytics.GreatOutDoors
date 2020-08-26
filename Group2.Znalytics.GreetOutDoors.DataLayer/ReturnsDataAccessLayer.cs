using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;
//Created by K.Prasanna
/// <summary>
/// This class represents DataAccess Layer for Return
/// </summary>
using Group2.Znalytics.GreetOutDoors.EntityLayer;
//using Group2.Znalytics.GreetOutDoors.IDataLayer;
using System.Collections;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
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
        public void ExchangeProduct(Return rm)// To Exchange a product
        {
            //_return.ExchangeProduct(rm);
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
            _return .RemoveAll(p => p.ProductName == name);
        }
        public Return GetReturnByProductID(int ID)
        {
            return _return.Find(temp => temp.ProductID == ID);

        }





    }

}
