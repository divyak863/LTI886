using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingProject
{
    class AgeException : ApplicationException
    {
        string myMessage;
        public AgeException()
        {
            myMessage = "Student has to be min 13 years old";
        }
        public override string Message => myMessage;
    }
}
