using System;
using System.Collections.Generic;
using System.Text;

namespace ExploringMars.Models
{
    public class RigthRedirectorAgent : IMovimentAgent
    {
        public void Move(SpaceProbe spaceProbe)
        {
            spaceProbe.TurnRight();
        }
    }
}
