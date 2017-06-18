using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        private string name;
        private string surname;
        private int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public Person()
        {
            this.name = "";
            this.surname = "";
            this.age = 0;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
    public class StaticMethod
    {
        public static Person GetInfo(out Person p)
        {
            Person res = new ClassLibrary.Person();
            res.Name = "Kaldr";
            res.Surname = "Merg";
            res.Age = 23;
            p = res;
            return p;
        }
    }
}