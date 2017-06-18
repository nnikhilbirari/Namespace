using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cl = ClassLibrary;



namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            cl.Person pers = new cl.Person();
            cl.StaticMethod.GetInfo(out pers);
            Console.WriteLine("Задание 1\nName: " + pers.Name + "\nSurname: " + pers.Surname + "\nAge: " + pers.Age + "\n\n");

            cl.Constants con = new cl.Constants();
            Console.WriteLine("Задание 2\nName: " + con.Name + "\nSurname: " + con.Surname + "\nAge: " + con.Age + "\nWeight: " + con.Weight + "\n\n");
        }
    }
}
