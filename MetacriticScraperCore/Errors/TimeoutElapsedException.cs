using System;

namespace MetacriticScraperCore.Errors
{
    public class TimeoutElapsedException : Exception
    {
        public TimeoutElapsedException() : base()
        {
        }

        public TimeoutElapsedException(string message) : base(message)
        {
        }
    }
}
