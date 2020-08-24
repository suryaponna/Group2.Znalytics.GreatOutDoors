using System.Collections.Generic;
//Created by K.Prasanna
/// <summary>
/// This class represents DataAccess Layer for Return
/// </summary>
using Group2.Znalytics.GreetOutDoors.EntityLayer;
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
        
        public void AddReturn(Return rm)
        {
            _return.AddReturn(rm);
        }
        public List<Return> GetReturnByProductID()
        {
            return _return;
        }
        public List<Return> GetReturns()
        {
           return  _return;

        }
       


    }
    
}
