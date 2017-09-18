using ExploringMars.Models.Cardinals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Models
{
    public class SpaceProbe
    {

        public Direction Direction { get; set; }
        
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        
        public void TurnLeft()
        {
            Direction = Direction.ToLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.ToRight();
        }

        public void Moving() {

            Direction.Step(this);

        }

    }
}
