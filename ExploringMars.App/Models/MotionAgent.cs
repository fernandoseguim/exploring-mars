using ExploringMars.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Models
{
    public class MotionAgent : IMotionAgent
    {
        private SpaceProbePositioner spaceProbePositioner;

        public MotionAgent(SpaceProbePositioner spaceProbePositioner)
        {
            this.spaceProbePositioner = spaceProbePositioner;
        }
        
        public void Move(SpaceProbe spaceProbe)
        {
            if (spaceProbe.Direction.IsPossibleMove(spaceProbe, spaceProbePositioner))
            {
                spaceProbe.Moving();
            }
            else
            {
                throw new SpaceProbePositionOutOfPlateauException(
                    spaceProbe.PositionX,
                    spaceProbe.PositionY,
                    spaceProbePositioner.LimitX,
                    spaceProbePositioner.LimitY
                    );
            }
        }
    }
}
