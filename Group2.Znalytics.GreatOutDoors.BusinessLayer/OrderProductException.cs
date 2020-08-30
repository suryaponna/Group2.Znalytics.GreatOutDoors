using System;
using System.Runtime.Serialization;

namespace Group2.Znalytics.GreatOutDoors.BusinessLayer
{
    [Serializable]
    internal class OrderProductException : Exception
    {
        public OrderProductException()
        {
        }

        public OrderProductException(string message) : base(message)
        {
        }

        public OrderProductException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderProductException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}