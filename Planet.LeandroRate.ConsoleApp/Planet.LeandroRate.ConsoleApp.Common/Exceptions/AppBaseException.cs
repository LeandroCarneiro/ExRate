using System;

namespace Planet.LeandroRate.ConsoleApp.Common.Exceptions
{
    public class AppBaseException : Exception
    {
        public AppBaseException(string msg) : base(msg) { }
    }
}
