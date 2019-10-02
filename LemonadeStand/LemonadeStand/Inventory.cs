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

        public void DisplayResources(string itemName, int qty)
        {
            switch (itemName)
                {
                    case "Cups":
                        AddCups(qty);
                        break;
                    case "Lemons":
                        AddLemons(qty);
                        break;
                    case "Sugar":
                        AddSugar(qty);
                        break;
                    case "Ice":
                        AddIce(qty);
                        break;
                    default:
                        break;
                }
        }

        private void AddIce(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                ice.Add(new IceCube());
            }
        }

        private void AddSugar(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                sugar.Add(new SugarCube());
            }
        }

        private void AddLemons(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                lemons.Add(new Lemon());
            }
        }

        private void AddCups(int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                cups.Add(new Cup());
            }
        }
    }
}
