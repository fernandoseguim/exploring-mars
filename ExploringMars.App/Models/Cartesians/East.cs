namespace ExploringMars.Models.Cartesians
{
    public class East : Direction
    {
        public override Point Current { get; protected set; }
        public override Point Left { get; protected set; }
        public override Point Right { get; protected set; }

        public East()
        {
            Current = Point.East;
            Left = Point.North;
            Right = Point.South;
        }

        public override bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner)
        {
            return spaceProbe.PositionX < spaceProbePositioner.LimitX;
        }

        public override Direction ToLeft()
        {
            return new North();
        }

        public override Direction ToRight()
        {
            return new South();
        }

        public override int Step(SpaceProbe spaceProbe)
        {
            return spaceProbe.PositionX++;
        }
    }
}