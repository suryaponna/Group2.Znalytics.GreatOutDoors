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
        public void Add(Return rm)
        {

            _return.Add(rm);//
        }
        // Method for updating ProductQuantity
        public void UpdateProductQuantity(Return rm)
        {
            Return ret = _return.Find(temp => temp.ProductQuantity == rm.ProductQuantity);
            if (ret != null)
            {
                ret.ProductQuantity = rm.ProductQuantity;
            }
        }
        // List to Get Returns
        public List<Return> GetReturns()
        {
            return _return;
        }
    }
}
