using Group2.Znalytics.GreetOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// BusinessLogic Layer
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{

    public class ReturnsBusinessLayer
    {
        
       
        // creating method for validating Productdate
        public void AddProductName(Return rm)
        {
            if (rm.ProductName!=null)
            {
                ReturnsDataAccessLayer rdl = new ReturnsDataAccessLayer();
                rdl.AddProductName(rm); 
            }
        }
        // checking condition for ProductQuantity
        public void AddProductQuantity(Return rm)
        {
            if (rm.ProductQuantity <= 20)
            {
                ReturnsDataAccessLayer rdl = new ReturnsDataAccessLayer();
                rdl.AddProductQuantity(rm);
            }
        }
       
    }
    
}
