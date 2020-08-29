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
        // Constructor for Returns Business layer 
        public ReturnsBusinessLayer()
        {
            // Creating object for Returns DataAccess Layer
            _rd = new ReturnsDataAccessLayer();
        }

        // creating method for validating ProductID

        public void AddReturns(Return rm)
        {
            if (rm.ProductName != null)
            {
                _rd.AddReturns(rm);
            }
            else
            {
                throw new Exception("Add valid Product Name");
            }
        }
        /// <summary>
        /// Method for Exchanging a product
        /// </summary>
        /// <param name="rm">Represents object of ReturnModule</param>
        public void ExchangeProduct(Return rm)
        {
            try
            {
                
                    DateTime exchangeDate = DateTime.Now;
                    exchangeDate = exchangeDate.AddDays(-30);

                    if (rm.Productdate < exchangeDate)
                    {
                        ExchangeProduct(rm);
                    }
                   
            }
            catch (ReturnException ex)
            {
                throw;
            }

        }
        /// <summary>
        /// Represents GetReturns through list
        /// </summary>
        /// <returns></returns>
        public List<Return> GetReturns()
        {
            return _rd.GetReturns();
        }
        
        /// <summary>
        /// Method for Removing Return by productname
        /// </summary>
        /// <param name="name">Represents name of the product</param>
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
        /// <summary>
        /// Method for Removing Return by ProductID
        /// </summary>
        /// <param name="Id">Its ProductID</param>
        public void  RemoveReturnByProductID(string Id)
        {

            _rd.RemoveReturnByProductID(Id);

        }
           
      
    }
}


