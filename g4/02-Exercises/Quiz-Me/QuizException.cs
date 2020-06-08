using System;
using System.Runtime.Serialization;

namespace QuizMe
{
    [Serializable]
    internal class QuizException : ApplicationException
    {
        public QuizException()
        {
        }

        public QuizException(string? message) : base(message)
        {
        }

        public QuizException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected QuizException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}