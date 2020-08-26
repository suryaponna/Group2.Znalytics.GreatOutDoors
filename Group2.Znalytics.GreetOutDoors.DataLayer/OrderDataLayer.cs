using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    class OrderDataLayer
    {
        //automatic property (or) auto-implemented property
        public string customerName { set; get; }
        public string productID { get; set; }
        public string address { get; set; }
        public string addToCart { get; set; }
        public string paymentProcess { get; set; }
    }
}
