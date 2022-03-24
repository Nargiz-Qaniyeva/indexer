using System;

namespace Utilities
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException(string message):base(message)
        {

        }
    }
}
