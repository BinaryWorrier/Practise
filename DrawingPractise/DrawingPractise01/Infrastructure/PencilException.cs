using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingPractice01.Infrastructure
{

    [Serializable]
    public class PencilException : Exception
    {
        public PencilException() { }
        public PencilException(string message) : base(message) { }
        public PencilException(string message, Exception inner) : base(message, inner) { }
        protected PencilException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
