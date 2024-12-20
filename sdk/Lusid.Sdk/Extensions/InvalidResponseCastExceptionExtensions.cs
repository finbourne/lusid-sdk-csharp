using System;

using Lusid.Sdk.Client;


namespace Lusid.Sdk.Extensions
{
    /// <summary>
    /// Exception thrown when a response cannot be cast to the expected type.
    /// </summary>
    public class InvalidResponseCastException: Exception
    {
        /// <summary>
        /// Get method for ExceptionMessage
        /// </summary>
        public string ExceptionMessage { get; private set; }
        /// <summary>
        /// Initializes a new instance of the InvalidResponseCastException class with a specified error message.
        /// </summary>
        /// <param name="exceptionMessage"></param>
        public InvalidResponseCastException(string exceptionMessage) : base(exceptionMessage)
        {
            this.ExceptionMessage = exceptionMessage;
        }
    }
}