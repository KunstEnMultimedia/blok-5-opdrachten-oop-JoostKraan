using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieScherper_13.Classes
{
    public class Dier
    {
        protected int geboortejaar;
        public void Eet()
        {

        }
        
    }
    class Paard : Dier
    {
        public bool KanHinnikken { get; set; }
        public void MaakOuder()
        {
            geboortejaar++; // !!! dit zal error geven!
        }
    }
}
