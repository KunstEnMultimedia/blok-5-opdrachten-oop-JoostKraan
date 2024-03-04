

using Zie_Scherper_10.classes;

namespace ZieScherper_11
{
    public class Program
    {
        static void Main(string[] args)
        {

            Opdracht11_3();
            //Opdracht11_1
            //Opdracht11_2();
        }
        private static void Opdracht11_1()
        {
            Student a = new Student("Karel",false);
            
            Console.WriteLine($"Student : {a.naam} is {a.isStudentWerk}");

            
            Student b = new Student("Theo",true);
            Console.WriteLine($"Student : {b.naam} is {b.isStudentWerk}");
            Console.ReadLine();
        }

        private static void Opdracht11_2()
        {
            Microfoon wit = new Microfoon(false);
            Microfoon grijs = new Microfoon(true);
            Console.WriteLine($"Microfoon wit is niet verkocht : {wit.IsUitverkocht}");
            Console.WriteLine($"Microfoon grijs is wel verkocht : {grijs.IsUitverkocht}");
        }
        private static void Opdracht11_3()
        {
            Microfoon microfoon1 = new Microfoon(true);
            Microfoon microfoon2 = new Microfoon(false);
            //Console.WriteLine(microfoon1);
            Console.ReadLine() ;
        }
    }
}