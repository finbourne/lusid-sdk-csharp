using System;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// An exception thrown when missing config parameters  
    /// </summary>
    public class MissingConfigException : Exception
    {
        /// <inheritdoc />
        public MissingConfigException(string message) : base(message)
        {
        }
    }
}