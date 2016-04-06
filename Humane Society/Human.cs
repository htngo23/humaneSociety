using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humane_Society
{
    class Human:IAdopt
    {
        public string name;
        public Animal animalOwned;

        public Human(string Name, Animal AnimalOwned)
        {
            name = Name;
            animalOwned = AnimalOwned;
        }
        public void adopt(Animal x)
        {
            animalOwned = x;
            Console.WriteLine("Congrats " + name + " now owns " + animalOwned.name);
        }
         

    }
}
