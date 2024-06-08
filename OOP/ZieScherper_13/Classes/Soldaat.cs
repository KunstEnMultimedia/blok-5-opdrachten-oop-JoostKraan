using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZieScherper_13.Classes
{
    class Soldaat
    {
        public Soldaat(bool kanSchieten)
        {
            //Doe soldaten dingen
        }
    }
    class VeldArts : Soldaat
    {

        public VeldArts(bool kanSchieten) : base(kanSchieten) 
        { }
        public VeldArts() : base(true)
        {
            Debug.WriteLine("Veldarts is aangemaakt.");
        }
    }
}

