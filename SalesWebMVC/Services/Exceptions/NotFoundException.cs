using System;

namespace SalesWebMVC.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string message) : base(message)
        {            
        }

        public NotFoundException(string message, Exception exception) : base(message, exception)
        {            
        }
    }
}
