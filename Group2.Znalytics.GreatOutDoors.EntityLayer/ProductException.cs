using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatOutdoorsProduct.Exceptions
{
    /// <summary>
    /// Exception class for Retailstore
    /// </summary>
    public class ProductException : ApplicationException
    {

        /// <summary>
        /// Exception calls the parent exception
        /// </summary>
        public ProductException()
            : base()
        {
        }
        /// <summary>
        /// Exception displayed with user message
        /// </summary>
        /// <param name="message">Message is displayed</param>
        public ProductException(string message)
            : base(message)
        {
        }
        /// <summary>
        /// Inner exception is throws from 
        /// </summary>
        /// <param name="message">Base exception</param>
        /// <param name="innerException">Inner exception message</param>
        public ProductException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
