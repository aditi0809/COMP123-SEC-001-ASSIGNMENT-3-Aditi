/*
 * Author's name       : Aditi Kapoor
 * Student Id          : 301108498
 * Date last modified  : 24/July/2020
 * Program description : Abstarct Planet program for the Assignment 03
 * Revision History    : 24/July/2020
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_SEC_001_ASSIGNMENT_3_Aditi
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 116460, 568.3, "Gas");
            Console.WriteLine(giantPlanet.ToString());

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mercury", 4879, 328.5, true);
            Console.WriteLine(terrestrialPlanet.ToString());

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

