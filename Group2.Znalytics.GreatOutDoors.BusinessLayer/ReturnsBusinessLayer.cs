using Group2.Znalytics.GreatOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreatOutDoors.IBusinessLayer;
/// <summary>
/// Created by K.Prasanna
/// This represents BusinessLogic Layer of Return
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{

    public class ReturnsBusinessLayer : IReturnsBusinessLayer
    {
        ReturnsDataAccessLayer _rd;

        public ReturnsBusinessLayer()
        {

            _rd = new ReturnsDataAccessLayer();
        }

        // creating method for validating ProductID

        public void AddReturn(Return rm)
        {
            if (rm.ProductName != null)
            {
                _rd.AddReturn(rm);
            }
            else
            {
                throw new Exception("Add valid Product Name");
            }
        }
        public void ExchangeProduct(Return rm)
        {
            try
            {
                _rd.ExchangeProduct(rm);
            }
            catch (ReturnException ex)
            {
                throw;
            }

        }
        public List<Return> GetReturns()
        {
            return _rd.GetReturns();
        }
        //Method to display Return  by ProductId
        // public List<Return> GetReturnByProductID() => _rd.GetReturnByProductID();

        public void RemoveReturnByProductName(string name)
        {
            try
            {
                if (name != null)
                {
                    _rd.RemoveReturnByProductName(name);
                }
                
            }
            catch (ReturnException ex)
            {
                throw;
            }
        }
        public void  RemoveReturnByProductID(int Id)
        {

            _rd.RemoveReturnByProductID(Id);

        }
           
      
    }
}


