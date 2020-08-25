using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;
//Created by K.Prasanna
/// <summary>
/// This class represents DataAccess Layer for Return
/// </summary>
using Group2.Znalytics.GreetOutDoors.EntityLayer;
using Group2.Znalytics.GreetOutDoors.IDataLayer;
namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public class ReturnsDataAccessLayer : IReturnsDataAccessLayer
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
        

        public Return GetReturnByProductID(int Id)
        {
            foreach (var i in _return)
            {
                if (i.ProductID == Id) {
                    yield return i;
                }
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




    }

}
