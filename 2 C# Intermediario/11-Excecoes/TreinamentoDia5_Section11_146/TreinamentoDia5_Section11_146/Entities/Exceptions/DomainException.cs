using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDia5_Section11_146.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
