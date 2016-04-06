using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humane_Society
{
   abstract class Animal:animalFunctions
    {
        
        public string name;
        public bool vaccinate;
        public bool owned;
        public string foodPreference;
        public double adoptionPrice;
        public string species;
        public int hunger;

        public virtual void eat(Food x)
        {
            

        }
            
  
    }
}
