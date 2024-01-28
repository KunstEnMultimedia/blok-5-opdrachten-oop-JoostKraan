using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Numerics;
using Zie_Scherper_10.classes;
using Zie_Scherper_10.Classes;
using static Zie_Scherper_10.Classes.Mens;

namespace Zie_Scherper_10
{
    public class Program
    {
        int getal = 3;
        int getal2 = 10;
        static void Main(string[] args)
        {


            
        }
        public static void opdracht10_01()
        {
            int getal = 5;
            VerhoogParameter(getal);
            Console.WriteLine($"Na methode {getal}");

            //Student a = new Student("Abba");
            //Student b = new Student("Queen");
            //Console.WriteLine("naam Student a:" + a.naam);
            //Console.WriteLine("naam Student b:" + b.naam);
           // b = a;
            //Console.WriteLine("naam Student a:" + a.naam);
            //Console.WriteLine("naam Student b:" + b.naam);
            Console.ReadLine();
        }
        public static void opdracht10_02()
        {
            Meting m1 = new Meting();
            m1.Temperatuur = 26;
            m1.OpgemetenDoor = "Lieven Scheire";
            Meting m2 = new Meting();
            m2.Temperatuur = 34;
            m2.OpgemetenDoor = "Ann Dooms";
            Console.WriteLine(m2.Temperatuur);
            Meting m3 = new Meting();

            m1.ToonMetingInKleur(ConsoleColor.Red);
            Console.WriteLine(m2.Temperatuur);
            Console.WriteLine(m3.Temperatuur);
            m2.ToonMetingInKleur(ConsoleColor.DarkMagenta);
            m3 = m2.GenereerRandomMeting();
            Console.WriteLine(m3.Temperatuur);
            Console.WriteLine(m2.Temperatuur);

            Mens mens1 = new Mens();
            Mens mens2 = new Mens();
            //mens1.PlantVoort();
            //mens2.PlantVoort();
        }
        public static void opdracht10_03()
        {
            Student[] studentsArray = new Student[]
            {
                //new Student("ValidName1"),
                //new Student("ValidName2"),
            };
            string searchName = "Jan";
            Student result = Student.ZoekStudent(studentsArray, searchName);
            if (result != null)
            {
                Console.WriteLine($"Naam: {result.naam} Karel");
            }
            else
            {
                Console.WriteLine($"Naam niet gevonden Karel");
            }
            Mens mama = new Mens();
            mama.Geslacht = Geslachten.Vrouw;
            mama.MaxLengte = 180;
            Mens papa = new Mens();
            papa.Geslacht = Geslachten.Man;
            papa.MaxLengte = 169;
            Mens baby = mama.PlantVoort(papa);
        }



        static void VerhoogParameter(int a)
        {
            a++;
            Console.WriteLine($"In methode {a}");
        }

        //static void opdracht10_05()
        //{
        //    Console.WriteLine("Geef een getal aub");
        //    int noemer = Convert.ToInt32(Console.ReadLine());
        //    double resultaat = 100 / noemer;
        //    Console.WriteLine($"100/{noemer} is gelijk aan {resultaat}");

        //    try
        //    {
        //        string input = Console.ReadLine();
        //        int converted = Convert.ToInt32(input);
        //    }
        //    catch ()
        //    {
        //        throw new Exception("Wow, dit loopt fout");
        //    }
        //}
    }
}