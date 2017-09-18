using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Models
{
    public interface IMotionAgent
    {
        void Move(SpaceProbe spaceProbe);
    }
}
