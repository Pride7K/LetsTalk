using System;

namespace LetsTalk.Errors
{
    public class AlreadyExistsException : Exception
    {
        public AlreadyExistsException(string message) : base(message)
        {
            
        }
    }
}