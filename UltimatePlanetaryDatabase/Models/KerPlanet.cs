using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimatePlanetaryDatabase.Models
{
    public class KerPlanet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string PlanetComp { get; set; }
        public string SemiMajorAxis { get; set; }
        public string Apoapsis { get; set; }
        public string Periapsis { get; set; }
        public string OrbEcc { get; set; }
        public string OrbInc { get; set; }
        public string ArgOfPeri { get; set; }
        public string LongOfAscendNode { get; set; }
        public string MeanAnomoaly { get; set; }
        public string EquatRad { get; set; }
        public string EquatCirc { get; set; }
        public string SurfaceArea { get; set; }
        public string Mass { get; set; }
        public string SGP { get; set; }
        public string Density { get; set; }
        public string SurfaceGrav { get; set; }
        public string EscVel { get; set; }
        public string RotPer { get; set; }
        public string SyncOrbit { get; set; }
        public string SoI { get; set; }
        public bool HasAtm { get; set; }
        public string AtmPress { get; set; }
        public string ScaleHeight { get; set; }
        public string AtmHeight { get; set; }
        public string MinTemp { get; set; }
        public string MaxTemp { get; set; }
        public bool HasOxygen { get; set; }
        public bool HasWater { get; set; }
        public bool HasMoon { get; set; }
        public bool CanSupportLife { get; set; }

    }
}
