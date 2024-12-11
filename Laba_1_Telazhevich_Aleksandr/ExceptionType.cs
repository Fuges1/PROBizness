using System;
using System.Runtime.Serialization;

namespace PROBizness
{
    [Serializable]
    internal class ExceptionType : Exception
    {
        public ExceptionType()
        {
        }

        public ExceptionType(string message) : base(message)
        {
        }

        public ExceptionType(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionType(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}