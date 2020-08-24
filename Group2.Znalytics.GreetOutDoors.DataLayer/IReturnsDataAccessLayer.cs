using Group2.Znalytics.GreetOutDoors.EntityLayer;
using System.Collections.Generic;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public interface IReturnsDataAccessLayer
    {
        
        void AddReturn(Return rm);
        List<Return> GetReturnByProductID(Return rm);

    }
}
