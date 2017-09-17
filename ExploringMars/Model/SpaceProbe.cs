using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Model
{
    public class SpaceProbe
    {
        public CardinalPoints Direction { get; set; }
        
        //public CardinalPoints Left { get; set; }

        //public CardinalPoints Right { get; set; }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        
        public void TurnLeft() {
            if (Direction.Equals(CardinalPoints.North))
            {
                Direction = CardinalPoints.West;

            }
            else if (Direction.Equals(CardinalPoints.South))
            {

                Direction = CardinalPoints.East;
            }
            else if (Direction.Equals(CardinalPoints.East))
            {

                Direction = CardinalPoints.North;
            }
            else if (Direction.Equals(CardinalPoints.West))
            {

                Direction = CardinalPoints.South;
            }
            else
            {
                throw new ArgumentException(string.Format("The direction {0} informed isn't cardinal point valid!", Direction));
            }
        }

        public void TurnRight() {
            if (Direction.Equals(CardinalPoints.North))
            {
                Direction = CardinalPoints.East;

            }
            else if (Direction.Equals(CardinalPoints.South))
            {

                Direction = CardinalPoints.West;
            }
            else if (Direction.Equals(CardinalPoints.East))
            {

                Direction = CardinalPoints.South;
            }
            else if (Direction.Equals(CardinalPoints.West))
            {

                Direction = CardinalPoints.North;
            }
            else
            {
                throw new ArgumentException(string.Format("The direction {0} informed isn't cardinal point valid!", Direction));
            }
        }

        public void Moving() {
            
            if (Direction.Equals(CardinalPoints.East) || (Direction.Equals(CardinalPoints.West)))
            {
                PositionX++;
            }
            else
            {
                PositionY++;
            }
            
        }

    }
}
