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
    public class ReturnsDataAccessLayer 
    {
        private static List<Return> _return;
        /// <summary>
        /// Constructor Return Data Access Logic that initializes collection
        /// </summary>
        static ReturnsDataAccessLayer()
        {
            //creating a list 
            _return = new List<Return>()
            {
                new Return{ProductID="12345",ProductName="DELL Laptop",ProductQuantity=1,Producttype="Electronical Devices"}
            };
            _return = LoadDetailsToList();
        }
        
        /// <summary>
        /// Declared a method for ListOfReturn which contains serialization part
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
        /// <summary>
        /// Deserialization method to load details into list
        /// </summary>
        /// <returns></returns>
        public static List<Return> LoadDetailsToList()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\Project.txt");
            string s2 = streamReader.ReadToEnd();
            List<Return> _return = JsonConvert.DeserializeObject<List<Return>>(s2);
            streamReader.Close();
            return _return;

        }
        /// <summary>
        /// Method to AddReturns
        /// </summary>
        /// <param name="rm">Object of Returns in presentation layer</param>

        public void AddReturn(Return rm)// 
        {
            _return.Add(rm);
            ListOfReturn();
        }
       public void ExchangeProduct(Return rm)
        {
            _return.Add(rm);
        }
        public Return GetReturnByProductID(Return rm)
        {
            //Condition to check whether the ProductId finds or not
            Return asm = _return.Find(temp => temp.ProductID == rm.ProductID);
            {
                return asm;

            }

        }

        public Return GetReturnByProductName(Return rm)
        {
            //Condition to check whether the Productname finds or not
            Return rmd = _return.Find(temp => temp.ProductName == rm.ProductName);
            {
                return rmd;

            }
        }

        public void UpdateReturn(Return rm)
        {
            //Condition to check whether the Productname and ID exists or not
            Return rma = _return.Find(n => n.ProductName == rm.ProductName && n.ProductID==rm.ProductID);
            if (rma != null)
            {
                rma.ProductName = rm.ProductName;
                ListOfReturn();
            }
            else
            {
                throw new Exception("Product name doesn't exist");
            }
        }
        /// <summary>
        /// List for storing Returns
        /// </summary>
        /// <returns></returns>
        public List<Return> GetReturns()
        {
            return _return;
            
        }
       
        

        /// <summary>
        ///  Method for Removing Return by ProductID
        /// </summary>
        public void RemoveReturnByProductID(string ProductId) //Removing a Product by using Product ID
        {
             _return.RemoveAll(temp=>temp.ProductID==ProductId);
            ListOfReturn();
        }
        /// <summary>
        /// Method for removing Return by product name
        /// </summary>
        public void RemoveReturnByProductName(string ProductName)// Removing a Product By using Product Name
        {

            _return.RemoveAll(temp=>temp.ProductName==ProductName);
        }   
    }
       

}
