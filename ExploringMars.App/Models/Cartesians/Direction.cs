namespace ExploringMars.Models.Cartesians
{

	public abstract class Direction
    {
        public abstract Point Current { get; protected set; }
        public abstract Point Left { get; protected set; }
        public abstract Point Right { get; protected set; }

        public abstract bool IsPossibleMove(SpaceProbe spaceProbe, SpaceProbePositioner spaceProbePositioner);

        public abstract Direction ToLeft();

        public abstract Direction ToRight();

        public abstract int Step(SpaceProbe spaceProbe);
    }
}
