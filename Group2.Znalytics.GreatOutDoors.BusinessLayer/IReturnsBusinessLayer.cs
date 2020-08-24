using System.Collections.Generic;
using Group2.Znalytics.GreetOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public interface IReturnsBusinessLayer
    {

        List<Return> GetReturnByProductID(Return rm);
        void AddReturn(Return rm);
    }
}
