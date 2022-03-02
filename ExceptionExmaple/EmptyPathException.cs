using System;
namespace ExceptionExmaple
{
    public class EmptyPathException : Exception
    {
        public EmptyPathException(string message) : base($" Customize [{message}]")
        {
        }

        public override string Message => $" --- {base.Message} --- ";
    }
}
