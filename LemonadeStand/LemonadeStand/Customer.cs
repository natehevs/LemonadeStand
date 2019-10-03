using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        // member variables (HAS A)
        public int SugarPref;
        public int LemonPref;
        public int IcePref;
        public int TempPref;
       
        public int money;


        /// <summary>
        /// ///////////////////////////////////////////////////////
        /// </summary>
        private List<string> names;
        public string name;

        // constructor

        public Customer()
        {
            LemonPref = GeneratePreference();
            IcePref = GeneratePreference();
            SugarPref = GeneratePreference();
            TempPref = GenerateTempPreference();
        }

        // member methods (CAN DO)
         
        public bool BuyLemonade(Recipe recipe, Weather weather)
        {
            if (SugarPref == recipe.amountOfSugar)
            {
                return true;
            }
            else if( LemonPref == recipe.amountOfLemons)
            {
                return true;
            }
            else if( IcePref == recipe.amountOfIce)
            {
                return true;
            }
            else if(weather.temperature > TempPref)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int GeneratePreference()
        {
            Random random = new Random();
            return random.Next(1, 6);
        }

        public int GenerateTempPreference()
        {
            Random random = new Random();
            return random.Next(60, 91);
        }
    }
}
