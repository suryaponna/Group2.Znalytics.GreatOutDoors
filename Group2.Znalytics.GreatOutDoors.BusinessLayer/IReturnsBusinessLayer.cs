using System.Collections.Generic;
using Group2.Znalytics.GreatOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.IBusinessLayer
{
    public interface IReturnsBusinessLayer
    {
        //Represents an interface for Returns BusinessLogic layer
        Return GetReturnsByProductID(int ID);
        void AddReturn(Return rm);
        // Return GetReturnByProductID(string ProductID);

        void RemoveReturnByProductName(string name);
    }
}
