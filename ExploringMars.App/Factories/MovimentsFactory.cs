using ExploringMars.Exceptions;
using ExploringMars.Models;
using System.Collections.Generic;

namespace ExploringMars.Factories
{
	public class MovimentsFactory
    {
        public static IMovimentAgent SetMoviments(string moviments, SpaceProbePositioner spaceProbePositioner)
        {
            var _moviments = moviments.ToCharArray();
            var movimentsList = new List<IMovimentAgent>();

            foreach(var moviment in _moviments)
            {
                switch (moviment)
                {
                    case 'L':
                        movimentsList.Add(new LeftRedirectorAgent());
                        break;

                    case 'R':
                        movimentsList.Add(new RigthRedirectorAgent());
                        break;

                    case 'M':
                        movimentsList.Add(new MovimentAgent(spaceProbePositioner));
                        break;
                    default:
                        throw new InvalidMovimentException(moviment);
                }
            }
            
            return new Moviments(movimentsList);
        } 
    }
}
