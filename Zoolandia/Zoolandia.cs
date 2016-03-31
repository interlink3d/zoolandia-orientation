using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
    class Animal
    {
        private string _name = "";

        public string species { get; set; }

        public string name {
            get
            {
                return _name;
            }
        }

        public Animal(string name)
        {
            _name = name;
        }
    }

    class Zoolandia
    {
        static void Main(string[] args)
        {
            Animal firstAnimal = new Animal(args[0]);
            firstAnimal.species = "Ostrich";

            Console.WriteLine("{0} the {1}", firstAnimal.name, firstAnimal.species);
        }
    }
}
