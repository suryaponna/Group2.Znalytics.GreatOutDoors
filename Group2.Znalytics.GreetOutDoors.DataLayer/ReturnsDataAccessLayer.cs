using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This class represents DataAccess Layer for Return
/// </summary>
namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public class ReturnsDataAccessLayer
    {
        List<Return> _return;
        /// <summary>
        /// Constructor Return Data Access Logic that initializes collection
        /// </summary>
        public ReturnsDataAccessLayer()
        {
            //creating a list 
            _return  = new List<Return>();
        }
        public void AddProductID(Return rt)
        {
            _return.Add(rt);//
        }

    }
}
