using System;
using System.Runtime.Serialization;

namespace Seq
{
    [Serializable]
    internal class SeqException : Exception
    {
        public SeqException()
        {
        }

        public SeqException(string message) : base(message)
        {
        }

        public SeqException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SeqException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}