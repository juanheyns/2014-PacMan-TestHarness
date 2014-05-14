using System;

namespace PacManDuel.Exceptions
{
    class UnreadableMazeException : Exception
    {

        public UnreadableMazeException(string message) 
            : base(message)
        {
            Console.Error.WriteLine(message);
        }

        public UnreadableMazeException(string message, Exception inner)
            : base(message, inner)
        {
            Console.Error.WriteLine(inner.Message);
        }

    }
}
