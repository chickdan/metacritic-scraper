using System;

namespace MetacriticScraperCore.Errors
{
    class SystemBusyException : Exception
    {
        public SystemBusyException() : base()
        {
        }

        public SystemBusyException(string message) : base(message)
        {
        }
    }
}
