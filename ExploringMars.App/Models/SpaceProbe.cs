using ExploringMars.Models.Cartesians;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
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

        public override string ToString()
        {
            
            return string.Format(
                "\n{0} {1} {2}",
                PositionX,
                PositionY,
                Direction.Current.ToString().Substring(0,1)
                );
        }
    }
}
