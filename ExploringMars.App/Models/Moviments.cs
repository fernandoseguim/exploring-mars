using ExploringMars.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExploringMars.Models
{
    public class Moviments : IMovimentAgent
    {

        private List<IMovimentAgent> _motionAgents;

        public Moviments(List<IMovimentAgent> motionAgents)
        {
            _motionAgents = motionAgents;
        }

        public void Move(SpaceProbe spaceProbe)
        {
            foreach (IMovimentAgent motionAgent in _motionAgents)
            {
                motionAgent.Move(spaceProbe);
            }
        }
    }
}
