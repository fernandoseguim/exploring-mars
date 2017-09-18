using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Models
{
    public class SpaceProbePositioner
    {
        public int LimitX { get; private set; }
        public int LimitY { get; private set; }

        public SpaceProbePositioner(int limitX, int limitY)
        {
            this.LimitX = limitX;
            this.LimitY = limitY;
        }

        public void MoveSpaceProbe(SpaceProbe spaceProbe, IMovimentAgent motionAgent)
        {
            motionAgent.Move(spaceProbe);
        }
    }
}
