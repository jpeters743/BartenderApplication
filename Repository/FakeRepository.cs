using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartenderApp.Models;

namespace BartenderApp.Repository
{
    public class FakeRepository
    {
        public List<Drink> Drinks;

        public FakeRepository()
        {
            Drinks = new List<Drink>();
            Drinks.Add(new Drink()
            {
                DrinkId = Guid.NewGuid().ToString(), 
                DrinkName = "Drink 1",
                DrinkDescription = "This drink has...",
                DrinkPrice = 5.00
            }) ;
            Drinks.Add(new Drink()
            {
                DrinkId = Guid.NewGuid().ToString(),
                DrinkName = "Drink 2",
                DrinkDescription = "This drink has...",
                DrinkPrice = 6.99
            });
            Drinks.Add(new Drink()
            {
                DrinkId = Guid.NewGuid().ToString(),
                DrinkName = "Drink 3",
                DrinkDescription = "This drink has...",
                DrinkPrice = 4.99
            });
            Drinks.Add(new Drink()
            {
                DrinkId = Guid.NewGuid().ToString(),
                DrinkName = "Drink 4",
                DrinkDescription = "This drink has...",
                DrinkPrice = 5.00
            });
        }
    }
}
