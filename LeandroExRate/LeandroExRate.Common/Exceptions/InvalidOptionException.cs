
namespace LeandroExRate.Common.Exceptions
{
    public class InvalidOptionException : AppBaseException
    {
        public InvalidOptionException() : base("The system could not process your reques. Try again please!") { }

        public InvalidOptionException(string msg) : base(msg) { }
    }
}
