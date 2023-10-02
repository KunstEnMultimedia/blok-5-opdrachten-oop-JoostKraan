using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIeScherper_09.Classes
{
    class Mens
    {
        private int geboorteJaar = 1970;
        private string lief = "niemand";

        public void VeranderLief(string nieuwLief)
        {
            lief = nieuwLief;
        }
        public void Praat()
        {
            Console.WriteLine("Ik ben een mens!");
            VertelGeheim();
        }

        private void VertelGeheim()
        {
            if (lief != "niemand")
                Console.WriteLine($"Ik ben verliefd op {lief}");
            else
                Console.WriteLine("Ik ben op niemand verliefd.");
        }
        public void StartVerjongingskuur()
        {
            Console.WriteLine("Jeuj. Ik word jonger!");
            geboorteJaar++;
        }
    }
}
