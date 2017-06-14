using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        private string name { get; set; }
        private string surname { get; set; }
        private int age { get; set; }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
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

        public void GetInformation()
        {
            Console.WriteLine("Name: " + this.Name + "\nSurname: " + this.Surname + "\nAge: " + this.Age);
        }
    }
    public class Collection
    {
        public Person ListCollection(Person p)
        {
            return 
        }
    }
}