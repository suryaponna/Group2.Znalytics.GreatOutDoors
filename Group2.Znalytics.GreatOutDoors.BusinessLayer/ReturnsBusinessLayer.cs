using Group2.Znalytics.GreetOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This represents BusinessLogic Layer of Return
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{

    public class ReturnsBusinessLayer
    {
        
       
        // creating method for validating Productdate
        public void AddProductID(Return rm)
        {
            if (rm.ProductID!=null)
            {
                ReturnsDataAccessLayer rdl = new ReturnsDataAccessLayer();
                rdl.AddProductID(rm); 
            }
        }
        // checking condition for ProductQuantity
       /* public void AddProductQuantity(Return rm)
        {
            if (rm.ProductQuantity <= 20)
            {
                ReturnsDataAccessLayer rdl = new ReturnsDataAccessLayer();
                rdl.AddProductQuantity(rm);
            }
        }*/
       
    }
    
}
