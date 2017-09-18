using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Models
{
    public interface IMovimentAgent
    {
        void Move(SpaceProbe spaceProbe);
    }
}
