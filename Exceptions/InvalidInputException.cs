using System;

namespace CSharp.LabExercise7.Exceptions
{
    class InvalidInputException : Exception
    {
        public InvalidInputException() : this("Invalid Input. Please try again")
        {

        }
        public InvalidInputException(string message) : base(message)
        {

        }

    }
}
