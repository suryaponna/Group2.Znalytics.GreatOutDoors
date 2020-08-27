using System.Collections.Generic;
using Group2.Znalytics.GreetOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.IBusinessLayer
{
    public interface IReturnsBusinessLayer
    {
        //Represents an interface for Returns BusinessLogic layer
        Return GetReturnsByProductID(int ID);
        void AddReturn(Return rm);
        void RemoveReturnByProductID(int id);
        void RemoveReturnByProductName(string name);
    }
}
