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
using Newtonsoft.Json;
using System.IO;
using System.CodeDom.Compiler;

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
        /// <summary>
        /// Declared a method for ListOfReturn
        /// </summary>
        public void ListOfReturn()
        {
            List<Return> _return = new List<Return>();
            //convert data into Json
            string s = JsonConvert.SerializeObject(_return);

            //write data into file
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Administrator\Desktop\Project.txt");
            streamWriter.Write(s);
            streamWriter.Close();


        }

        public void AddReturns(Return rm)// 
        {
            _return.Add(rm);
            ListOfReturn();


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
            for (int i = 0; i < _return.Count; i++)
            {
                yield return _return[i];
            }
        }

        public List<Return> GetReturns()
        {
            return _return;
            ListOfReturn();

        }
        public void RemoveReturnByProductID(string Id) //Removing a Product by using Product ID
        {
             _return.RemoveAll(temp => temp.ProductID == Id);

        }

        public void RemoveReturnByProductName(string name)// Removing a Product By using Product Name
        {




            if (_return.RemoveAll(p => p.ProductName == name))
            {
                _return.RemoveAll(p => p.ProductName == name);
            }
            else
            {
                throw new ReturnException("Product ID doesn't exists");
            }

            ListOfReturn();

        }   
    }
       

}
