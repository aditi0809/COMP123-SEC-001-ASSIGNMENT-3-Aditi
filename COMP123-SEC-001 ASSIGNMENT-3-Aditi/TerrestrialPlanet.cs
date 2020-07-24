using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_SEC_001_ASSIGNMENT_3_Aditi
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // private instance variables 
        private bool _oxygen;


        // constructor
       // It assigns bool oxygen to the private field.
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // public methods

        /// HasMoons() method returns true when the MoonCount is greater than 0 otherwise returns false.
        public bool HasMoons()
        {
            return (this.MoonCount < 0) ? true : false;
        }

        /// Habitable method checks if there is oxygen on the planet and returns its value.
         public bool Habitable()
        {
            return (this._oxygen == true) ? true : false;
        }
    }
}

    