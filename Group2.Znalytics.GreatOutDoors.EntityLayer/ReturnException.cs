using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
   public class ReturnException:ApplicationException
    {

        public ReturnException():base()
        {

        }
        public ReturnException(string message):base(message)
        {

        }
        public ReturnException(string message, Exception innerException) : base(message)
        {

        }

    }
}
