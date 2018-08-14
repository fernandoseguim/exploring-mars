namespace ExploringMars.Models.Cartesians
{
    public class West : Direction
    {
        public override Point Current { get; protected set; }
        public override Point Left { get; protected set; }
        public override Point Right { get; protected set; }

        public West()
        {
			this.Current = Point.West;
			this.Left = Point.South;
			this.Right = Point.North;
        }

		public override bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner) => 
			spaceProbe.PositionX > 0;

		public override Direction ToLeft() => new South();

		public override Direction ToRight() => new North();

		public override int Step(SpaceProbe spaceProbe) => spaceProbe.PositionX--;
	}
}
