

namespace HappyBirthday.Tools.Exceptions
{
    class PastDateOfBirthdayException : WrongDateOfBirthdayException
    {
        public PastDateOfBirthdayException() { }
        public PastDateOfBirthdayException(string message) : base(message) { }
        public PastDateOfBirthdayException(string message, System.Exception inner) : base(message, inner) { }
    }
}
