using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Group2.Znalytics.GreetOutDoors.EntityLayer;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public interface IReturnsBusinessLayer
    {

        List<Return> GetReturnByProductID(Return rm);
        void AddReturn(Return rm);
    }
}
