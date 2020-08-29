using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Znalytics.Group2.GreatOutDoor.Entity;


namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public class OrderDataLayer
    {
        /// <summary>
        /// Creating List Collection for OrderProduct
        /// </summary>
        private static List<OrderProduct> orderProducts=new List<OrderProduct>();
        public bool AddOrder(OrderProduct order)
        {
            bool orderAdded = false;
            try
            {
                orderProducts.Add(item: OrderProduct);
                orderAdded = true;
            }
            catch (Exception ex)
            {
                throw new OrderException(ex.Message);
            }
            return orderAdded;

        }

        public void SearchOrder(string SearchOrderID)
        {
            OrderProduct searchOrder = null;
            try
            {
                foreach (OrderProduct item in orderProducts)
                {
                    if (item.OrderID == SearchOrderID)
                    {
                        searchOrder = item;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new OrderProductException(ex.Message);
            }

            
        }
        public void 


               
            }

        }

   

    AddressDataLayer ad= new AddressDataLayer();  
    }

        
    }
}
 
}

