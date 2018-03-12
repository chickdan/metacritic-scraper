using System;

namespace MetacriticScraperCore.Errors
{
    public class SystemBusyException : Exception
    {
        public SystemBusyException() : base()
        {
        }

        public SystemBusyException(string message) : base(message)
        {
        }
    }
}
