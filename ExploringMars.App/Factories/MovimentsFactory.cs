using ExploringMars.Exceptions;
using ExploringMars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExploringMars.Factories
{
    public class MovimentsFactory
    {
        public static IMovimentAgent SetMoviments(String moviments, SpaceProbePositioner spaceProbePositioner)
        {
            string[] _moviments = moviments.Split(" ");
            List<IMovimentAgent> movimentsList = new List<IMovimentAgent>();

            foreach(string moviment in _moviments)
            {
                switch (moviment)
                {
                    case "L":
                        movimentsList.Add(new LeftRedirectorAgent());
                        break;

                    case "R":
                        movimentsList.Add(new RigthRedirectorAgent());
                        break;

                    case "M":
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
