using System.Collections.Generic;

namespace ExploringMars.Models
{
	public class Moviments : IMovimentAgent
    {

        private List<IMovimentAgent> _motionAgents;

        public Moviments(List<IMovimentAgent> motionAgents)
        {
			this._motionAgents = motionAgents;
        }

        public void Move(SpaceProbe spaceProbe)
        {
            foreach (var motionAgent in this._motionAgents)
            {
                motionAgent.Move(spaceProbe);
            }
        }
    }
}
