using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Cage
{
    public class Animal
    {
        public string name { get; }

        public string type { get; }

        public Animal(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
    }
}
