using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zie_Scherper_10.Classes
{
    public class Meting
    {
        public int Temperatuur { get; set; }
        public string OpgemetenDoor { get; set; }

        public void ToonMetingInKleur(ConsoleColor kleur)
        {
            Console.ForegroundColor = kleur;
            Console.WriteLine($"{Temperatuur}°C gemeten door: {OpgemetenDoor}");
            Console.ResetColor();
        }
        public void VoegMetingToeEnVerwijder(Meting inMeting)
        {
            Temperatuur += inMeting.Temperatuur;
            inMeting.Temperatuur = 0;
            inMeting.OpgemetenDoor = "";
        }
        public Meting GenereerRandomMeting()
        {
            Meting result = new Meting();
            result.Temperatuur = Temperatuur * 2;
            result.OpgemetenDoor = OpgemetenDoor + "Junior";
            return result;
        }

    }
}
