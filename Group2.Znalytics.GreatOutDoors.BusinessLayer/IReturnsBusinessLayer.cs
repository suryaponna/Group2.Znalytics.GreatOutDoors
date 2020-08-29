using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.IBusinessLayer
{
    public interface IReturnsBusinessLayer
    {
        //Represents an interface for Returns BusinessLogic layer
       
        void AddReturn(Return rm);
        void RemoveReturnByProductName(string name);
        Return RemoveReturnByProductID(int Id);
    }
}
