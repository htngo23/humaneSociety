using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humane_Society
{
    class DogFood:Food
    {
        public DogFood(string FoodType, int Quantity)
        {
            foodType = FoodType;
            quantity = Quantity;
        }

    }
}
