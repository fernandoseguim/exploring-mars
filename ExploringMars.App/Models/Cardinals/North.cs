using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Models.Cardinals
{
    public class North : Direction
    {
        public override Point Current { get; protected set; }
        public override Point Left { get; protected set; }
        public override Point Right { get; protected set; }

        public North()
        {
            Current = Point.North;
            Left = Point.West;
            Right = Point.East;
        }

        public override bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner)
        {
            return spaceProbe.PositionY < spaceProbePositioner.LimitY;
        }

        public override Direction ToLeft()
        {
            return new West();
        }

        public override Direction ToRight()
        {
            return new East();
        }
    }
}
