using System;
namespace ExceptionExmaple
{
    public class NullPathException : EmptyPathException
    {
        public NullPathException(string message) : base(message)
        {
        }
    }
}
