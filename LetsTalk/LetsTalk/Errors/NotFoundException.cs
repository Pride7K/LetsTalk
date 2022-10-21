using System;

namespace LetsTalk.Errors
{
    public class NotFoundException: Exception
    {
        public NotFoundException(string message) : base(message)
        {
            
        }
    }
}