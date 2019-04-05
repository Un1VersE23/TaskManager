
namespace HappyBirthday.Tools.Exceptions
{
    class WrongDateOfBirthdayException : PersonDataException
    {
        public WrongDateOfBirthdayException()  { }
        public WrongDateOfBirthdayException(string message) : base(message) { }
        public WrongDateOfBirthdayException(string message, System.Exception inner) : base(message, inner) { }
    }
}
