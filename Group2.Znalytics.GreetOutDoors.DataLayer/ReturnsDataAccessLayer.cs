using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// DataAccess Layer
/// </summary>
namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    public class ReturnsDataAccessLayer
    {

        public ReturnsDataAccessLayer()
        {
            //creating a list 
            List<Return> returns  = new List<Return>();
        }
        public void AddReturnsModule(Return returns)
        {
            Return.Add(returns);//
        }

    }
}
