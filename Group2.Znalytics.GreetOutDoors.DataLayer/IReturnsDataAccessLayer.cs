using Group2.Znalytics.GreetOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public interface IReturnsDataAccessLayer
    {
        
        void AddReturn(Return rm);
        List<Return> GetReturnByProductID(Return rm);

    }
}
