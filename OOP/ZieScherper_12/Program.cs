using Zie_Scherper_10;
using Zie_Scherper_10.classes;
namespace ZieScherper_12
{
    public class Program
    {
        static void Main(string[] args)
        {

            Stack<string> stapel = new Stack<string>();
            stapel.Push("Ik was eerste hier.");
            stapel.Push("Ik tweede.");
            stapel.Push("Ik als laatste.");

            Console.WriteLine(stapel.Pop());
            Console.WriteLine(stapel.Pop());
            stapel.Peek();
            stapel.Peek();
            Console.WriteLine(stapel.Count());
            Console.WriteLine(stapel);

            Dictionary<int, string> klanten = new Dictionary<int, string>();
            klanten.Add(123, "Tim Dams");
            klanten.Add(6463, "James Bond");
            klanten.Add(666, "The beast");
            klanten.Add(700, "James Bond");

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
        public static void Opdracht12_03()
        {
            Stack<string> stapel = new Stack<string>();
            stapel.Push("Ik was eerste hier.");
            stapel.Push("Ik tweede.");
            stapel.Push("Ik als laatste.");

            Console.WriteLine(stapel.Pop());
            Console.WriteLine(stapel.Pop());
            stapel.Peek();
            stapel.Peek();
            Console.WriteLine(stapel.Count());
            Console.WriteLine(stapel);

            Dictionary<int, string> klanten = new Dictionary<int, string>();
            klanten.Add(123, "Tim Dams");
            klanten.Add(6463, "James Bond");
            klanten.Add(666, "The beast");
            klanten.Add(700, "James Bond");
        }
    }
}