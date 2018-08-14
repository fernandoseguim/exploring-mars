namespace ExploringMars.Models.Cartesians
{
    public class East : Direction
    {
        public override Point Current { get; protected set; }
        public override Point Left { get; protected set; }
        public override Point Right { get; protected set; }

        public East()
        {
			this.Current = Point.East;
			this.Left = Point.North;
			this.Right = Point.South;
        }

		public override bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner) => 
			spaceProbe.PositionX < spaceProbePositioner.LimitX;

		public override Direction ToLeft() => new North();

		public override Direction ToRight() => new South();

		public override int Step(SpaceProbe spaceProbe) => spaceProbe.PositionX++;
	}
}