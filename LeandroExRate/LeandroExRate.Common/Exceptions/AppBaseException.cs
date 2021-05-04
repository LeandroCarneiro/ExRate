using System;

namespace LeandroExRate.Common.Exceptions
{
    public class AppBaseException : Exception
    {
        public AppBaseException(string msg) : base(msg) { }
    }
}
