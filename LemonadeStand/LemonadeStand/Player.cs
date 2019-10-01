﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;

        // member variables (HAS A)



        // constructor

        public Player()
        {
            recipe = new Recipe();
            inventory = new Inventory();
            wallet = new Wallet();
            pitcher = new Pitcher();
        }

        // member methods (CAN DO)


    }
}
