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
                // checks condition that Purchased date should be less than exchange date to exchange the product
                if (rm.Productdate < rm.ExchangeDate)
                {
                    ExchangeProduct(rm);
                }
                else
                {
                    throw new ReturnException("Exchange should be within one month of purchased date");
                }
            }
            catch
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
        /// Method represents Get details of Returns using ProductID
        /// </summary>
        /// <param name="Id">It is Product ID</param>
        /// <returns></returns>
        public Return GetReturnByProductID(Return rm)
        {

            //ProductId should not be null
            if (rm.ProductID!= null)
            {
                return _rd.GetReturnByProductID(rm);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// This Method represents Get details of returns by Product name
        /// </summary>
        /// <returns></returns>
        public Return GetReturnByProductName(Return rm)
        {

            //ProductId should not be null
            if (rm.ProductName != null)
            {
                return _rd.GetReturnByProductName(rm);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// This method represents to update returns
        /// </summary>
        /// <param name="rm">Reference variable of return in presentation layer</param>
        public void UpdateReturns(Return rm)
        {

            //ProductId should not be null
            if (rm.ProductID!= null)
            {
                 _rd.UpdateReturns(rm);
            }
        }

        /// <summary>
        /// Method for Removing Return by productname
        /// </summary>
        public void RemoveReturnByProductName(Return rm)
        {
            try
            {
                if (rm.ProductName != null)
                {

                    _rd.RemoveReturnByProductID(rm);
                }
                else
                {
                    throw new ReturnException("Product id doesn't exists");
                }


            }
            catch 
            {
                throw;
            }
        }
        /// <summary>
        /// Method for Removing Return by ProductID
        /// </summary>
        public void  RemoveReturnByProductID(Return rm)
        {

            if (rm.ProductID != null)
            {
                _rd.RemoveReturnByProductID(rm);
            }
            else
            {
                throw new ReturnException("Product id doesn't exists");
            }


        }


    }
}


