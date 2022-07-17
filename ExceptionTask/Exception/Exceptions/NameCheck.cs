using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask.Exceptions
{
    public class CheckNames : Exception
    {
        public CheckNames(string message) : base(message)
        {

        }
    }
}
