using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Jan", "Kowalski", 1990, 1, 2, 12345);
            //student1.MiejsceZamieszkania = "Olsztyn";
            //Console.WriteLine(student1.ObliczWiek());
            //Console.ReadKey();

            //Osoba student2 = new Student("Jan", "Kowalski", 1990, 1, 2, 12345);
            //student2.WypiszInfo();

            Student student3 = new Student("Jan", "Kowalski", 1990, 1, 2, 12345);
            Osoba osoba3 = student3;
            Student student4 = (Student)osoba3;
            student4.WypiszInfo();
            Console.ReadKey();
        }
    }
}
