namespace ExploringMars.Models.Cartesians
{
    public class North : Direction
    {
        
        public override Point Current { get; protected set; }
        public override Point Left { get; protected set; }
        public override Point Right { get; protected set; }

        public North()
        {
			this.Current = Point.North;
			this.Left = Point.West;
			this.Right = Point.East;
        }

		public override bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner) => 
			spaceProbe.PositionY < spaceProbePositioner.LimitY;

		public override Direction ToLeft() => new West();

		public override Direction ToRight() => new East();

		public override int Step(SpaceProbe spaceProbe) => spaceProbe.PositionY++;

	}
}
