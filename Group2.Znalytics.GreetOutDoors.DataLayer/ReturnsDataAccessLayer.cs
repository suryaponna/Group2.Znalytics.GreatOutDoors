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
            List<string> Data = new List<string>();
        }
        public void AddReturnsModule(string ReturnsModule)
        {
            Data.Add(ReturnsModule);
        }

    }
}
