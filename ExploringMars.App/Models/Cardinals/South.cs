namespace ExploringMars.Models.Cardinals
{
    public class South : Direction
    {
        public override Point Current { get; protected set; }
        public override Point Left { get; protected set; }
        public override Point Right { get; protected set; }

        public South()
        {
            Current = Point.South;
            Left = Point.East;
            Right = Point.West;
        }

        public override bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner)
        {
            return spaceProbe.PositionY > 0;
        }

        public override Direction ToLeft()
        {
            return new East();
        }

        public override Direction ToRight()
        {
            return new West();
        }
    }
}