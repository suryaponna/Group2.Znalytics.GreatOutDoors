using Group2.Znalytics.GreetOutDoors.EntityLayer;
using System.Collections.Generic;

namespace Group2.Znalytics.GreetOutDoors.IDataLayer
{
     interface IReturnsDataAccessLayer
    {
        
        void AddReturn(Return rm);
        Return GetReturnByProductID(int Id);

    }
}
