﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Model
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

        public void MoveSpaceProbe(SpaceProbe spaceProbe, IMotionAgent motionAgent)
        {
            motionAgent.Move(spaceProbe);
        }
    }
}
