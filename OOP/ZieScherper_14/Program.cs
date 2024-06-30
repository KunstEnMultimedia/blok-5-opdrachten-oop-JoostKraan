using Zie_Scherper_10;
using System;
using Zie_Scherper_10.classes;

namespace ZieScherper_14
    
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            Student stud2 = new Student();
            Console.WriteLine(stud1.GetType().Name);
            Console.WriteLine(stud1.ToString());
            Console.WriteLine(stud1.Equals(stud2));
            Console.ReadLine();
        }
    }
}
