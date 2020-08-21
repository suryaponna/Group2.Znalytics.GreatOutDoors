using Group2.Znalytics.GreetOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Created by K.Prasanna
/// This represents BusinessLogic Layer of Return
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{

    public class ReturnsBusinessLayer : IReturnsBusinessLayer
    {
        private ReturnsDataAccessLayer _rdl;

        public ReturnsBusinessLayer()
        {
            _rdl = new ReturnsDataAccessLayer();
        }

        // creating method for validating ProductID
        public void Add(Return rm)
        {
            if (rm.ProductID != null)
            {
                _rdl.Add(rm);
            }
            else
            {
                throw new Exception("ProductID can't be null");
            }
        }

        // checking condition for ProductQuantity
        public void UpdateProductQuantity(Return rm)
        {
            
                _rdl.UpdateProductQuantity(rm);
            
        }

    }

}
