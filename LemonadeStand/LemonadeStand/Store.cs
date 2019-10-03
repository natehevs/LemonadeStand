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

        public void BuyProduct()
        {
            
        }

        public int DisplayPrice()
        {
            
        }

        public void TakeMoneyFromWallet()
        {

        }
    }
}
