﻿using Group2.Znalytics.GreetOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public class ReturnsBusinessLayer
    {
        ReturnsDataAccessLayer rdl = new ReturnsDataAccessLayer();
        public void AddReturnsModule(ReturnsModule rm)
        {
            if(rm.ProductName.Length<=30)
            {
                rdl.AddReturnsModule(rm);
            }
            if(rm.Productdate!=null)
            {
                rdl.AddReturnsModule(rm);
            }
            if(rm.ProductQuantity<=20)
            {
                rdl.AddReturnsModule(rm);
            }
        }
    }
}
