using System;
using System.Runtime.Serialization;

namespace Group2.Znalytics.GreatOutDoors.EntityLayer
{
    [Serializable]
    internal class OrderProductEXception : Exception
    {
        public OrderProductEXception()
        {
        }

        public OrderProductEXception(string message) : base(message)
        {
        }

        public OrderProductEXception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderProductEXception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}