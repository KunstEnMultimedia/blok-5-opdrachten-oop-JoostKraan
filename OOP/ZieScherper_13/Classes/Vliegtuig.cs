using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieScherper_13.Classes
{
    public class Vliegtuig
    {
        public virtual void Vlieg()
        {
            Console.WriteLine("Het vliegtuig vliegt rustig door de wolken.");
        }
    }
    class Raket : Vliegtuig
    {
        public virtual void Vlieg()
        {
            Console.WriteLine("Raket zweeft in de lucht");
        }
    }
  


}

