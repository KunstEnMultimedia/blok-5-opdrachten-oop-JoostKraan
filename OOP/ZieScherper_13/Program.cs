using System;
using ZieScherper_13.Classes;


namespace ZieScherper_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
        }

        static void Opdracht_01()
        {
            Dier aDier = new Dier();
            Paard bPaard = new Paard();
            aDier.Eet();
            bPaard.Eet();
            bPaard.KanHinnikken = false;
            
           

        }

        static void Opdracht_02()
        {
            Huis eenHuis = new Huis(true,1);
            Villa groteVilla = new Villa(false,2);
            Soldaat sukkel1 = new Soldaat(true);
            VeldArts sukkel2 = new VeldArts();
            Soldaat sukkel3 = new Soldaat(false);
            VeldArts sukkel4 = new VeldArts(false);
        }

        static void Opdracht_03()
        {

        }
    }
}
