using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables (HAS A)

        public List<Lemon> lemons;
        public List<SugarCube> sugar;
        public List<IceCube> ice;
        public List<Cup> cups;

        // constructor

        public Inventory()
        {
            lemons = new List<Lemon>();
            sugar = new List<SugarCube>();
            ice = new List<IceCube>();
            cups = new List<Cup>();           
        }

        // member methods (CAN DO)

        public void DisplayResources()
        {

        }

    }
}
