using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    public class RetailstoreException : ApplicationException

    {
      /// <summary>
      /// Exception which calls the parent exception
      /// </summary>

        public RetailstoreException():base()
        {

        }
        /// <summary>
        /// Exception is diaplayed
        /// </summary>
        /// <param name="message">Message to be displayed</param>
        public RetailstoreException(string message):base(message)
        {

        }
        



    }


}
