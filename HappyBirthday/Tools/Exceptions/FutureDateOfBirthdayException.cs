
namespace HappyBirthday.Tools.Exceptions
{
    class FutureDateOfBirthdayException : WrongDateOfBirthdayException
    {
        public FutureDateOfBirthdayException()  { }
        public FutureDateOfBirthdayException(string message) : base(message) { }
        public FutureDateOfBirthdayException(string message, System.Exception inner) : base(message, inner) { }
    }
}
