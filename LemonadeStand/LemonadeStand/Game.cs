using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        /*
         * 1. display information
          2. display instructions/ explanations
        3. get name
        4. show current lemons, sugar, and ice which would be 0 at beginning
            a. display weather for today
        5. prompt to shop for ingredients
            a. what price would you like to sell lemonade at?
            b. how many sugar would you like to buy
                HAVE 3 OPTIONS
            c. how many lemons would you like to buy
                HAVE 3 OPTIONS
            d. how much ice would you like to buy
                HAVE 3 OPTIONS
            e. how many cups would you like to buy
                HAVE 3 OPTIONS
        6. ask for recipe
            a. how many lemons, sugar, and ice per cup.
        7. start day
            a. display weather, and have designated prompt saying how well or bad sales are based on the day
        8. Sell until day is over/all designated sales are made based on predetermined weather conditions
            a. if they didnt have enough resources stop day early and display "sold out"
        9. display day results
            a. profit
            b. resources after day
            c. how many cups sold
            d. refreshment %
            e. if ice is left over melt all of it
        10. go back to step 4
        */

        // member variables (HAS A)
        public Player playerOne;
        public Inventory inventory;
        List<Day> days;
        int currentDay;

        // constructor
        public Game()
        {
            playerOne = new Player();
            inventory = new Inventory();
            
        }


        // member methods (CAN DO)
        public void RunGame()
        {
            //setup
            DisplayInstructions();
            CreatePlayer();
            DisplayResources();
            DisplayWeather();
            DisplayShop();
            DisplayRecipe();
            DisplaySelling();
            DisplayDayResults();

            //gameplay loop

            //cleanup = show total profit or loss at the end of week
        }

        public void DisplayInstructions()
        {
            Console.WriteLine("This is a lemonade stand game! you choose a player name and play a 7 day lemonade stand simulation.");
            Console.WriteLine("The objective is to make the biggest profit that you can by the end of the week.");
            Console.WriteLine("The weather along with the resources you have for each day will be displayed before each day. You can buy more resources to help sell more lemonade before each day.");
            Console.WriteLine("Keep in mind that the weather will affect the outcome of sales for each day.");
        }

        public void CreatePlayer()
        {
            Console.WriteLine("What is your name?");
            playerOne.name = Console.ReadLine();
        }

        public void DisplayResources()
        {
            Console.WriteLine("Here's how much of each resource you have!");
            inventory. = Console.ReadLine();
        }

        public void DisplayWeather()
        {

            Console.WriteLine("This is the weather forecast for today.");
        }

        public void DisplayShop()
        {
            Console.WriteLine("This is the Shop. You can purchase items to help with your lemonade stand here.");
            Console.WriteLine("Cups are sold for the following prices. 25 Cups= $2.50, 50 Cups= $5.00, 100 Cups= $10.00");
            Console.WriteLine("Lemons are sold for the following prices. 25 Lemons= $2.50, 50 Lemons= $5.00, 100 Lemons= $10.00");
            Console.WriteLine("Sugar is sold for the following prices. 25 Cubes= $1.00, 50 Cubes= $2.00, 100 Cubes= $4.00");
            Console.WriteLine("Ice is sold for the follwing prices. 100 Cubes= $5.00, 200 Cubes= $10.00, 300 Cubes= $20.00");
            
        }

        public void DisplayRecipe()
        {
            //playerOne.recipe.CreateRecipe();
            Console.WriteLine("");
        }

        public void DisplaySelling()
        {
            Console.ReadLine();
            
                Console.WriteLine("You ran out of items for your recipe.");
        }

        public void DisplayDayResults()
        {
            

            Console.WriteLine("");
        }
    }
}
