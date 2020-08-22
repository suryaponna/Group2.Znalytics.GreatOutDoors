using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Created by K.Prasanna
/// <summary>
/// This class represents DataAccess Layer for Return
/// </summary>
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
        
        public void AddProductName(Return rm)
        {
            _return.AddProductName(rm);
        }
        public List<Return> GetReturns()
        {
           return  _return;

        }
       


    }
    
}
