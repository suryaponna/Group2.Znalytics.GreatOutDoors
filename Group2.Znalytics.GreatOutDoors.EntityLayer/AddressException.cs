using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    /// <summary>
    /// Exception class For Customer Address
    /// </summary>
    public class AddOrderDetails : ApplicationException
    {
        /// <summary>
        /// Exception which calls the Parent Exception 
        /// </summary>
        public AddOrderDetails() : base() {

        }
        /// <summary>
        /// Exception is displayed with user defined message 
        /// </summary>
        /// <param name="message"> message to be displayed</param>
        public AddOrderDetails(string message) : base(message) { 
        }
        /// <summary>
        /// Inner Exception thrown from another place and re throwned to another Place 
        /// </summary>
        /// <param name="message">base Exception message</param>
        /// <param name="innerException">Inner Exception Message</param>
        public AddOrderDetails(string message, Exception innerException) : base(message) { 
            
        }
    }
}
