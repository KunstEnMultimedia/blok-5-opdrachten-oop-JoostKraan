using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieScherper_13.Classes
{
    class Restaurant
    {
        protected int kosten = 0;
        public virtual void PoetsAlles()
        {
         
            kosten += 1000;
            
        }
    }
    class Frituur : Restaurant
    {
        public override void PoetsAlles()
        {
            base.PoetsAlles(); 
            kosten += 500; 
        }
    }
}
