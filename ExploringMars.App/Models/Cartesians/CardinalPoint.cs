using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringMars.Models.Cartesians
{
    public enum Point
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
