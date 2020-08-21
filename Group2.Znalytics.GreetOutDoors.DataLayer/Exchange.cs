using System;
using System.Collections.Generic;


namespace Group2.Znalytics.GreetOutDoors.DataLayer
{
    class Exchange
    { 
        //private Fields
        private static List<Exchange> _exchange;
    }
    //Constructor
    static void Exchange()
    {
        _exchange= new List<Exchange>()
        {
            new Exchange() { UserName= "Anitha", Password=12345 }

        }
    }
 

}
