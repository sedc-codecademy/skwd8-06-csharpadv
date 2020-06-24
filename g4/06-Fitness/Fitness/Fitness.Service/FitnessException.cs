using System;
using System.Runtime.Serialization;

namespace Fitness.Service
{
    [Serializable]
    internal class FitnessException : Exception
    {
        public FitnessException()
        {
        }

        public FitnessException(string message) : base(message)
        {
        }

        public FitnessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FitnessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}