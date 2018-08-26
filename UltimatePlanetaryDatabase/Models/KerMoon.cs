using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimatePlanetaryDatabase.Models
{
    public class KerMoon : KerPlanet
    {
        public int Id { get; set; }
        public string ParentBody { get; set; }



    }
}
