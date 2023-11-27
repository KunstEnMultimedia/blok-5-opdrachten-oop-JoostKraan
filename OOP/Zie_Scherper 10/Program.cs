namespace Zie_Scherper_10
{
    public class Program
    {
        int getal = 3;
        int getal2 = 10;
        static void Main(string[] args)
        {
            int getal = 5;
            VerhoogParameter(getal);
            Console.WriteLine($"Na methode {getal}");
            Console.ReadLine();
        }

        static void VerhoogParameter(int a)
        {
            a++;
            Console.WriteLine($"In methode {a}");
        }
    }
}