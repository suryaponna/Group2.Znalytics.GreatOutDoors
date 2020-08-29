using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.IBusinessLayer
{
    public interface IReturnsBusinessLayer
    {
        //Represents an interface for Returns BusinessLogic layer
       
        void AddReturns(Return rm);
        Return RemoveReturnByProductName(string name);
        Return RemoveReturnByProductID(string Id);
        void ExchangeProduct(Return rm);
    }
}
