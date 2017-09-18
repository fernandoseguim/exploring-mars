using ExploringMars.Models.Cardinals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExploringMars.Models
{
    public interface IRedirectorAgent : IMovimentAgent
    {
        void MoveLeft(SpaceProbe spaceProbe);

        void MoveRight(SpaceProbe spaceProbe);
    }
}
