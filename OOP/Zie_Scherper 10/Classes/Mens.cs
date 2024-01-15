using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zie_Scherper_10.Classes
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

        public enum Geslachten { Man, Vrouw }
        public Geslachten Geslacht { get; set; }
        public int MaxLengte { get; set; }
        public Mens PlantVoort(Mens dePapa)
        {
            if (Geslacht == Geslachten.Vrouw && dePapa.Geslacht == Geslachten.Man)
            {
                Mens baby = new Mens();
                baby.MaxLengte = MaxLengte;
                if (dePapa.MaxLengte >= MaxLengte)
                    baby.MaxLengte = dePapa.MaxLengte;
                return baby;
            }
            return null;
        }
    }
}
