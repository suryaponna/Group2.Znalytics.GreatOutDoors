//---------Archana
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.RetailDetailsException.EntityLayer
{
    /// <summary>
    /// Exception class for Retailstore
    /// </summary>
    public class RetailstoreException : ApplicationException
    {
        /// <summary>
        /// Exception calls the parent exception
        /// </summary>
        public RetailstoreException() : base()
        {
        }
        /// <summary>
        /// Exception displayed with user message
        /// </summary>
        /// <param name="message">Message is displayed</param>
        public RetailstoreException(string message) : base(message)
        {
        }
        /// <summary>
        /// Inner exception is throws from 
        /// </summary>
        /// <param name="message">Base exception</param>
        /// <param name="innerException">Inner exception message</param>
        public RetailstoreException(string message, System.Exception innerException) : base(message)
        {
        }


    }
}