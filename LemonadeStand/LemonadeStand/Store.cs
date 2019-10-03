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

        // constructor

        public Store()
        {
            IcePrice = DisplayPrice();
            SugarPrice = DisplayPrice();
            LemonPrice = DisplayPrice();
            CupPrice = DisplayPrice();
        }

        // member methods (CAN DO)

        public void SellLemons()
        {

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
