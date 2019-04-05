using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyBirthday.Tools.Exceptions
{
    class WrongNameException : PersonDataException
    {
        public WrongNameException()  { }
        public WrongNameException(string message) : base(message) { }
        public WrongNameException(string message, System.Exception inner) : base(message, inner) { }
    }
}
