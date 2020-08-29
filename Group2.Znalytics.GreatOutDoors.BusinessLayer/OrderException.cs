﻿using System;
using System.Runtime.Serialization;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    [Serializable]
    internal class OrderException : Exception
    {
        public OrderException()
        {
        }

        public OrderException(string message) : base(message)
        {
        }

        public OrderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}