using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Model
{
    public enum CardinalPoints
    {
        [Display(Name = "N")]
        North,

        [Display(Name = "S")]
        South,

        [Display(Name = "E")]
        East,

        [Display(Name = "W")]
        West
    }
    
}
