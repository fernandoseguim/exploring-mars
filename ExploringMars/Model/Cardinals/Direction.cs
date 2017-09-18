﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Model.Cardinals
{
    //public interface IDirection
    //{
    //    bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner);
    //}

    public abstract class Direction
    {
        public abstract Point Current { get; protected set; }
        public abstract Point Left { get; protected set; }
        public abstract Point Right { get; protected set; }

        public abstract bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner);

        public abstract Direction ToLeft();

        public abstract Direction ToRight();        
    }
}
