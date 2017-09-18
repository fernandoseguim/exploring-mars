using System;
using System.Collections.Generic;
using System.Text;

namespace ExploringMars.Exceptions
{
    public class InvalidMovimentException : ArgumentException
    {
        public InvalidMovimentException(string moviment)
        : base(string.Format("The moviment {0} is not valid", moviment)) { }
    }
}
