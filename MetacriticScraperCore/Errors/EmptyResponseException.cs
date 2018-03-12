using System;

namespace MetacriticScraperCore.Errors
{
    public class EmptyResponseException : Exception
    {
        public EmptyResponseException() : base()
        {
        }

        public EmptyResponseException(string message) : base(message)
        {
        }
    }
}
