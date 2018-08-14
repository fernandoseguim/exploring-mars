using ExploringMars.Models.Cartesians;
using System;

namespace ExploringMars.Helpers
{
	public class InputParams
    {
        public static int Position(string msg)
        {
            Console.WriteLine(msg);
            if (!int.TryParse(Console.ReadLine(), out var limitX))
            {
                throw new ArithmeticException("The value informed is not a number");
            }
            return limitX;
        }

        public static Direction Direction(string msg)
        {
            Console.WriteLine(msg);

            var directionString = Console.ReadLine().ToUpper().Trim();
            
            switch (directionString)
            {
                case "N":
                    return new North();
                    
                case "S":
                    return new South();
                    
                case "E":
                    return new East();
                    
                case "W":
                    return new West();
                    
                default:
                    throw new ArgumentException("Direction invalid");
            }
            
        }

        public static string Moviments(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
    }
}
