using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        // member variables (HAS A)

        public int amountOfLemons;
        public int amountOfSugar;
        public int amountOfIce;
        public double pricePerCup;

        // constructor

        public Recipe()
        {
            amountOfIce = 0;
            amountOfLemons = 0;
            amountOfSugar = 0;
            pricePerCup = .25;
        }

        // member methods (CAN DO)

        public void CreateRecipe()
        {

        }
    }
}
