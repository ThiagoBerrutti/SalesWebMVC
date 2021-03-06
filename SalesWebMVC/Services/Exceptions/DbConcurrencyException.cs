using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException()
        {
        }

        public DbConcurrencyException(string message) : base(message)
        {
        }

        public DbConcurrencyException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
