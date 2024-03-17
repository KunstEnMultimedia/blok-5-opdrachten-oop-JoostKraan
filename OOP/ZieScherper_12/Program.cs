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
            Student[] klas = new Student[5];
            for (int i = 0; i < klas.Length; i++)
            {
                klas[i] = new Student();
            }

            klas[0].naam = "'Karel";

        }

        public static void Opdracht12_02()
        {
            Student student1 = new Student();
            Student student2 = new Student();
            List<Student> klasList = new List<Student>()
            {
                new Student() {naam = "Karel"},
                new Student() {naam = "Bob"}
            };
            for (int i = 0; i < klasList.Count; i++)
            {
                Console.WriteLine(klasList[i].naam);
            }
        }
    }
}