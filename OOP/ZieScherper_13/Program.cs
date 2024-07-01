using System;
using ZieScherper_13.Classes;
using ZIeScherper_09;


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
            Soldaat guy1 = new Soldaat(true);
            VeldArts guy2 = new VeldArts();
            Soldaat guy3 = new Soldaat(false);
            VeldArts guy4 = new VeldArts(false);
        }

        static void Opdracht_03()
        {
            Vliegtuig topGun = new Vliegtuig();
            Raket spaceX1 = new Raket();
            topGun.Vlieg();
            spaceX1.Vlieg();
        }
        static void Opdracht_04()
        {
            Frituur frituur1 = new Frituur();
            Restaurant restaurant = new Restaurant();
            frituur1.PoetsAlles();
            restaurant.PoetsAlles();
            Console.ReadLine();
        }
    }
}
