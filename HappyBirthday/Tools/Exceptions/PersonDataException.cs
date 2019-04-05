using System;

namespace HappyBirthday.Tools.Exceptions
{
    class PersonDataException : Exception
    {
        public PersonDataException()  { }
        public PersonDataException(string message) : base(message) { }
        public PersonDataException(string message, System.Exception inner) : base(message, inner) { }
    }
}
