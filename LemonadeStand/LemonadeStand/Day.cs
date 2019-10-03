using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // member variables (HAS A)

        
        public double dailyProfit;
        public Weather weather;
        public List<Customer> customers;

        // constructor

        public Day()
        {
            
            weather = new Weather();
            customers = new List<Customer>();
        }

        // member methods (CAN DO)

        public void CreateCustomers()
        {
            int numberOfCustomers;
            if(weather.condition == "rainy")
            {
                numberOfCustomers = 50;
            }
            else if(weather.condition == "cloudy")
            {
                numberOfCustomers = 100;
            }
            else if(weather.condition == "sunny")
            {
                numberOfCustomers = 150;
            }
            else
            {
                numberOfCustomers = 0;
            }
            

            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }

        public void DisplayDailyProfit()
        {

        }
        
        public void SellLemonade()
        {
            for (int i = 0; i < customers.Count; i++)
            {

            }
        }

        public void ViewInventory()
        {

        }

        public void ViewWeather()
        {

        }

        public void CreateRecipe()
        {

        }

        public void GoToStore()
        {

        }
    }
}
