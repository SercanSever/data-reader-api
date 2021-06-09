using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Service.CustomExceptions
{
    public class InvalidSourceTypeException : Exception
    {
        public InvalidSourceTypeException() : base()
        {
        }
        public InvalidSourceTypeException(string message) : base(message)
        {
        }
    }
}
