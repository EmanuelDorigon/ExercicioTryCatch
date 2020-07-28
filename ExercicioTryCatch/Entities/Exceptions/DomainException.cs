using System;
using ExercicioTryCatch.Entities.Exceptions;

namespace ExercicioTryCatch.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        { 
        }
    }
}
