using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Models.Cardinals
{
    public class West : Direction
    {
        public override Point Current { get; protected set; }
        public override Point Left { get; protected set; }
        public override Point Right { get; protected set; }

        public West()
        {
            Current = Point.West;
            Left = Point.South;
            Right = Point.North;
        }

        public override bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner)
        {
            return spaceProbe.PositionX > 0;
        }

        public override Direction ToLeft()
        {
            return new South();
        }

        public override Direction ToRight()
        {
            return new North();
        }
    }
}
