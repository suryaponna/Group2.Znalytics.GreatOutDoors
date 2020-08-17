using Group2.Znalytics.GreetOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public class ReturnsBusinessLayer
    {
        public void AddReturnsModule(ReturnsModule r)
        {
            if(r.ProductName!=null)
            {
                ReturnsDataAccessLayer rdl = new ReturnsDataAccessLayer();
                rdl.AddReturnsModule(r);
            }
        }
    }
}
