using Zie_Scherper_10;
using Zie_Scherper_10.classes;
namespace ZieScherper_12
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }
        public static void Opdracht12_01()
        {
            Student[] klas45 = { new Student(), new Student() };
            Student[] klas = new Student[5];
            for (int i = 0; i < klas.Length; i++)
            {
                klas[i] = new Student();
            }

            klas[0].naam = "'Karel";

        }
    }
}