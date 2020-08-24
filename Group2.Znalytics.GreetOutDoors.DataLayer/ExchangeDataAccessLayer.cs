using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Group2.Znalytics.GreatOutDoors.DataLayer
{
    public class ExchangeDataAccessLayer
    {
        private List<ExchangeEntityLayer> _exchange;

        static ExchangeDataAccessLayer()
        {
            _exchange = new List<Exchange>();
        }

    }
}


