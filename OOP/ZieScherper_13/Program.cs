using System;
using ZieScherper_13.Classes;


namespace ZieScherper_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dier aDier = new Dier();
            Paard bPaard = new Paard();
            aDier.Eet();
            bPaard.Eet();
            bPaard.KanHinnikken = false;
            // aDier.KanHinnikken = false; //!!! zal niet werken!
            // 'Dier' does not contain a definition for 'KanHinnikken' and no accessible extension method 'KanHinnikken' a
            Huis eenHuis = new Huis();
            Villa groteVilla = new Villa();
            //aDier.geboortejaar = 2;


        }
    }
}
