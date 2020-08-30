using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.IBusinessLayer
{
    /// <summary>
    /// Represents an interface for Returns BusinessLogic layer
    /// </summary>
    public interface IReturnsBusinessLayer
    {
        /// <summary>
        ///Method to add details of return
        /// </summary>
        /// <param name="rm">Object for Return</param>
        void AddReturns(Return rm);
        /// <summary>
        /// Method for removing Return by using productID
        /// </summary>
        /// <param name="name">Represents name of product</param>
        void RemoveReturnByProductName(Return rm);
        void RemoveReturnByProductID(Return rm);
        /// <summary>
        /// Method for exchange product
        /// </summary>
        /// <param name="rm"></param>
        void ExchangeProduct(Return rm);
        /// <summary>
        /// Method to get return details by using productname
        /// </summary>
        /// <param name="name">Represents product name</param>
        /// <returns></returns>
        Return GetReturnByProductName(Return rm);
        Return GetReturnByProductID(Return rm);
    }
}
