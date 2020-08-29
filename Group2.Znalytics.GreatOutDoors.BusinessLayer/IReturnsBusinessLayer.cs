using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.IBusinessLayer
{
    public interface IReturnsBusinessLayer
    {
        //Represents an interface for Returns BusinessLogic layer
       
        void AddReturns(Return rm);
        void RemoveReturnByProductName(string name);
        void RemoveReturnByProductID(string Id);
        void ExchangeProduct(Return rm);
    }
}
