using System.Net.Http.Headers;
using Zie_Scherper_10.Classes;

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

            Student a = new Student("Abba");
            Student b = new Student("Queen");
            Console.WriteLine("naam Student a:" + a.naam);
            Console.WriteLine("naam Student b:" + b.naam);
            b = a;
            Console.WriteLine("naam Student a:" + a.naam);
            Console.WriteLine("naam Student b:" + b.naam);
            Console.ReadLine();
        }
        
       

        static void VerhoogParameter(int a)
        {
            a++;
            Console.WriteLine($"In methode {a}");
        }
    }
}