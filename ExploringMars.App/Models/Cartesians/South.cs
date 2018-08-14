namespace ExploringMars.Models.Cartesians
{
    public class South : Direction
    {
        public override Point Current { get; protected set; }
        public override Point Left { get; protected set; }
        public override Point Right { get; protected set; }

        public South()
        {
			this.Current = Point.South;
			this.Left = Point.East;
			this.Right = Point.West;
        }

		public override bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner) => 
			spaceProbe.PositionY > 0;

		public override Direction ToLeft() => new East();

		public override Direction ToRight() => new West();

		public override int Step(SpaceProbe spaceProbe) => spaceProbe.PositionY--;

	}
}