using Group2.Znalytics.GreetOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreetOutDoors.EntityLayer;
using Group2.Znalytics.GreatOutDoors.IBusinessLayer;
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
       
        public void AddReturn(Return rm)
        {
            if (rm.ProductName != null)
            {
                _rdl.AddReturn(rm);
            }
            else
            {
                throw new Exception("Add valid Product Name");
            }
        }
        public void ExchangeProduct(Return rm)
        {
            if (rm.ProductID == null)
            {
                return;
            }
            _rdl.ExchangeProduct(rm);
        }
        public List<Return> GetReturns()
        {
            return _rdl.GetReturns();
        }
        //Method to display Return  by ProductId
        //public List<Return> GetReturnByProductID() => _rdl.GetReturnByProductID();
        
        public void RemoveReturnByProductName(string name)
        {
            if (name != null)
            {
                _rdl.RemoveReturnByProductName(name);
            }
        }
        public void RemoveReturnByProductID(int Id) { 
            
        }

        public Return GetReturnByProductID(int Id)
        {
            return _rdl.GetReturnByProductID(Id);
        }
    }

}
