using System;
namespace ExceptionExmaple
{
    public class InvalidPathExecption : Exception
    {
        public InvalidPathExecption(string message) : base(message)
        {
        }
    }
}
