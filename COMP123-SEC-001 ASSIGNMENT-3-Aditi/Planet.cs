using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_SEC_001_ASSIGNMENT_3_Aditi
{
    abstract class Planet
    {

        // private instance variables
        private double _Diameter;
        private double _Mass;
        private int _MoonCount;
        private string _Name;
        private double _OrbitalPeriod;
        private int _RingCount;
        private int _RotationPeriod;

        // Constructor
        /// This constructor pass on the  parameters to the derived classes .
        /// Assings its parameters to private fields
        public Planet(string name, double diameter, double mass)
        {
            this._Name = name;
            this._Diameter = diameter;
            this._Mass = mass;
        }

        // Field Properties
        public double Diameter
        {
            get
            {
                return this._Diameter;      // Read-Only
            }
        }

        public double Mass
        {
            get
            {
                return this._Mass;          // Read-Only
            }
        }

        public int MoonCount
        {
            get
            {
                return this._MoonCount;
            }
            set
            {
                this._MoonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._Name;         // Read-Only
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return this._OrbitalPeriod;
            }
            set
            {
                this._OrbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._RingCount;
            }
            set
            {
                this._RingCount = value;
            }
        }

        public int RotationPeriod
        {
            get
            {
                return this._RotationPeriod;
            }
            set
            {
                this._RotationPeriod = value;
            }
        }

        // Public Method
        public override string ToString()
        {
  /// ToString method overrides and displays the output.This is basically the way how the output will look like.
     /// It displays Name , Diameter and Mass of the Planet.
            string _dia = this._Diameter.ToString();
            string _mass = this._Mass.ToString();

            return this._Name + "\n" + "Diameter : " + _dia + "\nMass : " + _mass + "\n";
        }
    }
}
    

