using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Microsoft.Win32;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    public class OrderBusinessLayer
    {
        OrderDataLayer _od;
        private int searchOrderBusinessLayer;



        /// <summary>
        /// Constructor for Order Business Layer
        /// </summary>
        public OrderBusinessLayer()
        {
            //Creating Object for DataLayer
            _od = new OrderDataLayer();
        }
        /// <summary>
        /// Method For Adding the Product
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(OrderProduct order)
        {
            bool orderadded = false;
            try
            {
                if (validorder(order) == null)
                {
                    AddOrder(order);
                }
            }
            catch (OrderProductException)
            {
                throw;
            }

        

        }
        public static SearchOrderBusinessLayer( int searchOrderID)
        {
            searchOrderID = null;
            try
            {
                searchOrderBusinessLayer = searchOrderID;
            }
            catch (OrderException ex)
            {
                throw ex;
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            return searchOrderBusinessLayer;

        }

    }

    
    }
}
      


DateTime eligibleDate = DateTime.Now;