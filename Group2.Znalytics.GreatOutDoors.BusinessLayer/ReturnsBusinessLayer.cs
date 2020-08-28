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
        private DateTime Exchangedate;

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
            if (rm.Productdate == Exchangedate)
            {
                return;
            }
            _rd.ExchangeProduct(rm);
        }
        public List<Return> GetReturns()
        {
            return _rd.GetReturns();
        }
        //Method to display Return  by ProductId
        // public List<Return> GetReturnByProductID() => _rd.GetReturnByProductID();

        public void RemoveReturnByProductName(string name)
        {
            if (name != null)
            {
                _rd.RemoveReturnByProductName(name);
            }
        }
        public Return ReturnByProductID(int ProductID)
        {
            return _rd.GetReturnsByProductID(ProductID);
        }

        public Return GetReturnsByProductID(int Id)
        {
            return _rd.GetReturnsByProductID(Id);
        }

    }
}


