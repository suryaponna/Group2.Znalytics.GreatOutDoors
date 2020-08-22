﻿using Group2.Znalytics.GreetOutDoors.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Created by K.Prasanna
/// This represents BusinessLogic Layer of Return
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{

    public class ReturnsBusinessLayer : IReturnsBusinessLayer
    {
        private ReturnsDataAccessLayer _rdl;

        public ReturnsBusinessLayer()
        {
            _rdl = new ReturnsDataAccessLayer();
        }

        // creating method for validating ProductID
       
        public void AddProductName(Return rm)
        {
            if (rm.ProductName != null)
            {
                _rdl.AddProductName(rm);
            }
            else
            {
                throw new Exception("Add valid Product Name");
            }
        }
        public List<Return> GetReturns()
        {
            return _rdl.GetReturns();
        }
       


    }

}
