using System;
using System.Collections.Generic;

namespace BLL.Exceptions
{
    public class ValidationAppException : Exception
    {
        public IEnumerable<string> Errors { get; set; }

        public ValidationAppException(string message, IEnumerable<string> errors) : base(message)
        {
            Errors = errors;
        }
    }
}