using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humane_Society
{
    class Dogs:Animal
    {
        public Dogs(string Name, bool Vaccinate, bool Owned, string FoodPreference, string Species, int Hunger)
        {
            name = Name;
            vaccinate = Vaccinate;
            owned = Owned;
            foodPreference = FoodPreference;
            species = Species;
            hunger = Hunger;
            
        }
        public override void eat(Food x)
        {
            Console.WriteLine(name + " Just ate everything all up!!!");
            Console.WriteLine("Bark Bark, delicious");
            hunger = 100;
            x.quantity -= 10;
        }

    }
}
