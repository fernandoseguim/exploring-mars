using System;

namespace ExploringMars.Exceptions
{
	public class InvalidMovimentException : ArgumentException
    {
        public InvalidMovimentException(char moviment)
        : base(string.Format("The moviment {0} is not valid", moviment)) { }
    }
}
