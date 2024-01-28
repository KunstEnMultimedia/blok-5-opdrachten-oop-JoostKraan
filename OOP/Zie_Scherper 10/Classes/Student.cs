using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zie_Scherper_10.classes
{
    public class Student
    {
        public bool isStudentWerk { get; set; }
        
        public string naam { get; set; } 

        public Student(string naam, bool isStudentWerk)
        {

            this.naam = naam;
            this.isStudentWerk = isStudentWerk;
        }
        static public Student ZoekStudent(Student[] array, string naam)
        {
            Student gevonden = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].naam == naam)
                    gevonden = array[i];
            }

            return gevonden;
        }

    }
}
