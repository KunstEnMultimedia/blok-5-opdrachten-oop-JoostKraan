using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieScherper_13.Classes
{
    public class Gebouw
    {
        public int AantalVerdiepingen { get; private set; }
        public Gebouw(int verdiepingenIn)
        {
            AantalVerdiepingen = verdiepingenIn;
        }
    }
    public class Huis : Gebouw
    {
        public bool HeeftTuintje { get; private set; }
        public Huis(bool tuintjeIn, int verdiepingenIn) : base(verdiepingenIn)
        {
            HeeftTuintje = tuintjeIn;
        }
    }
    public class Villa : Huis
    {
        public Villa(bool tuintjeIn, int verdiepingenIn) : base(tuintjeIn, verdiepingenIn)
        {
        }
    }
    public class Appartement : Gebouw
    {
        public Appartement(int verdiepingenIn) : base(verdiepingenIn)
        {
        }
    }
}
