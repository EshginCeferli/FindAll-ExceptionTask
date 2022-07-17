using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionTask
{
    public class DivideExceptions :Exception
    {
        public DivideExceptions(string message):base(message)
        {

        }
    }
}
