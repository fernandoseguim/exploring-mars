using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Exceptions
{
    public class SpaceProbePositionOutOfPlateauException : Exception
    {
        public SpaceProbePositionOutOfPlateauException(int positionX, int positionY, int limitX, int limitY)
        : base(String.Format("The space probe positions (X : {0} Y : {1} ) are out of limits (X : {2} Y : {3}) of plateau.", positionX, positionY, limitX, limitY)) { }
    }
}
