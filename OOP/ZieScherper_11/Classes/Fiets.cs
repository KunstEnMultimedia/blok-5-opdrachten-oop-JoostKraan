using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieScherper_11.Classes
{
    class Fiets
    {
        private static int aantalFietsen = 0;
        public Fiets()
        {
            aantalFietsen++;
            Debug.WriteLine($"Er zijn nu {aantalFietsen} gemaakt");
        }
        public static void VerminderFiets()
        {
            aantalFietsen--;
            Debug.WriteLine($"STATIC: Er zijn {aantalFietsen} fietsen");
        }
    }
}
