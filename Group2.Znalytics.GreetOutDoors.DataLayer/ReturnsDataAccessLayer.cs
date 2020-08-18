using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public class ReturnsDataAccessLayer
    {

        public ReturnsDataAccessLayer()
        {
            List<ReturnsModule> returnsModules  = new List<ReturnsModule>();
        }
        public void AddReturnsModule(ReturnsModule returnsModule)
        {
            returnsModule.Add(returnsModule);
        }

    }
}
