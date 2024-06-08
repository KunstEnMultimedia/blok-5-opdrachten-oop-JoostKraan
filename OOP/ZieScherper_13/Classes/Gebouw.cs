using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieScherper_13.Classes
{
    class Gebouw
    {
        public int AantalVerdiepingen { get; private set; }
        public Gebouw(int verdiepingenIn)
        {
            AantalVerdiepingen = verdiepingenIn;
        }
    }
    class Huis : Gebouw
    {
        public bool HeeftTuintje { get; private set; }
        public Huis(bool tuintjeIn, int verdiepingenIn) : base(verdiepingenIn)
        {
            HeeftTuintje = tuintjeIn;
        }
    }
    public class Villa : Huis
    {

    }
    public class Appartement : Gebouw
    {

    }
}
