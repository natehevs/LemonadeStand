using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // member variables (HAS A)
        public int SugarPrice;
        public int LemonPrice;
        public int IcePrice;
        public int CupPrice;
        
        public int money;
        Player player;
        private string lemons;

        // constructor

        public Store()
        {
            IcePrice = DisplayPrice();
            SugarPrice = DisplayPrice();
            LemonPrice = DisplayPrice();
            CupPrice = DisplayPrice();
            
        }

        // member methods (CAN DO)

        public void StoreMenu()
        {
            // write a menu method that I can choose what i want to buy
            // based on what i choose to buy go to that method (i.e SellLemons or SellIce)
            Console.WriteLine("What would you like to purchase? Type either 'lemons', 'ice', 'cups', 'sugar', or 'done' if you are finished shopping.");
            string item = Console.ReadLine();
            switch (item)
            {
                case "lemons":
                    SellLemons();
                    break;
                case "ice":
                    SellIce();
                    break;
                case "cups":
                    SellCups();
                    break;
                case "sugar":
                    SellSugar();
                    break;
                case "done":
                    break;
            }
        }

        public void SellLemons()
        {
            //well how much do you want?
            //check if they have enough money
            //if you do have enough money
                    // that add item to their inventory
                    // take money from them
            //if they do not have enough money then let them know and send them back to the menu

            // no matter if they buy or do not buy send them back to the menu
        }

        public void SellIce()
        {

        }

        public void SellSugar()
        {

        }

        public void SellCups()
        {

        }

        //public void BuyProduct()
        //{
        //    //Add all products up together and if I have enough money buy it and subtract from wallet
        //    if (money > costOfGoods)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public int DisplayPrice()
        //{
        //   /* SugarPrice per 50 = $5, 100 = $10, 150 = $15
        //    CupPrice per 100 = $5, 200 = $10, 300 = $15
        //    LemonPrice per 25 = $5, 50 = $10, 75 = $15
        //    IcePrice per 50 = $5, 100 = $10, 150 = $15
        //    */
        //}
    }
}
