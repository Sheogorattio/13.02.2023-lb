using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    abstract public class Animal
    {
        private protected string genus;
        public string Genus { get { return genus; } }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public Animal()
        {
            Age = 0;
            Name = "no data";
            Description = "no data";
            genus = "no data"; 
        }

        public void Print()
        {
            Console.WriteLine("Genus: {0}\nName: {1}\nDescription: {2}\nAge:{3}",Genus,Description,Name, Age);
        }
    }

    public class Tiger : Animal
    {
        public Tiger()
        {
            genus = "Panthera";
        }
    }

    public class Crocodile : Animal
    {
        public Crocodile()
        {
            genus = "Crocodylus";
        }
    }
}
