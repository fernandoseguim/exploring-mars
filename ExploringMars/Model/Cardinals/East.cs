namespace ExploringMars.Model.Cardinals
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
            return spaceProbe.PositionY < spaceProbePositioner.LimitY;
        }

        public override Direction ToLeft()
        {
            return new North();
        }

        public override Direction ToRight()
        {
            return new South();
        }
    }
}