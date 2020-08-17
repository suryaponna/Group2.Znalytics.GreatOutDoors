using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public class ReturnsDataAccessLayer
    {
        private List<ReturnsModule> Returns;

        public ReturnsDataAccessLayer()
        {
            Returns = new List<ReturnsModule>();
        }
        public void AddReturnsModule(ReturnsModule r)
        {
            Returns.Add(r);
        }

    }
}
