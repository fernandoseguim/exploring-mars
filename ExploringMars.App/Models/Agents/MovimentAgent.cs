using ExploringMars.Exceptions;

namespace ExploringMars.Models
{
	public class MovimentAgent : IMovimentAgent
    {
        private SpaceProbePositioner spaceProbePositioner;

        public MovimentAgent(SpaceProbePositioner spaceProbePositioner)
        {
            this.spaceProbePositioner = spaceProbePositioner;
        }
        
        public void Move(SpaceProbe spaceProbe)
        {
            if (spaceProbe.Direction.IsPossibleMove(spaceProbe, this.spaceProbePositioner))
            {
                spaceProbe.Moving();
            }
            else
            {
                throw new SpaceProbePositionOutOfPlateauException(
                    spaceProbe.PositionX,
                    spaceProbe.PositionY,
					this.spaceProbePositioner.LimitX,
					this.spaceProbePositioner.LimitY
					);
            }
        }
    }
}
