using System;

namespace Business.Commands.ChangeInvoiceDuedate
{
    [Serializable]
    public class InvalidDueDateException : Exception
    {
        public InvalidDueDateException() { }
        public InvalidDueDateException(string message) : base(message) { }
        public InvalidDueDateException(string message, Exception inner) : base(message, inner) { }
        protected InvalidDueDateException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
