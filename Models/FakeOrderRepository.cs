using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartenderApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BartenderApp.Models

{
    public class FakeOrderRepository
    {
        private static List<DrinkOrder> oorders = new List<DrinkOrder>();
        public static IEnumerable<DrinkOrder> Orders
        {
            get
            {
                return oorders;
            }
        }
        public static void AddOrder(DrinkOrder order)
        {
            oorders.Add(order);
        }

        public static void DeleteOrder(DrinkOrder order)
        {
            oorders.Remove(order);
        }


    }
}
