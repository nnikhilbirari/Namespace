using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Constants
    {
        private const string name = "Чукча";
        private const string surname = "Джибурджинчиков";
        private const int age = 51;
        private const int weight = 121;

        public string Name
        {
            get { return name; }
        }
        public string Surname
        {
            get { return surname; }
        }
        public int Age
        {
            get { return age; }
        }
        public int Weight
        {
            get { return weight; }
        }

    }
}
