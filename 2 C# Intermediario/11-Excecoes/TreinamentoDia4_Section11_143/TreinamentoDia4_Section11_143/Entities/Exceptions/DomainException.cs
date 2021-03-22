using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDia4_Section11_143.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
