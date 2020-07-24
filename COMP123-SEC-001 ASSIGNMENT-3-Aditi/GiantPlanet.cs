using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_SEC_001_ASSIGNMENT_3_Aditi
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // private instance variables
        private string _type;

        // Constructor
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }

        // public methods
      // HasMoons method returns true if the MoonCount is greater than 0 otherwise returns false.
        public bool HasMoons()
        {
            return (this.MoonCount > 0) ? true : false;
        }

        public bool HasRings()
        {
            // HasRings method returns true if the RingCount is greater than 0 otherwise returns false.
            return (this.RingCount > 0) ? true : false;
        }
    }
}
    

