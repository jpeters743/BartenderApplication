using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BartenderApp.Models;
using Microsoft.AspNetCore.Http;
using BartenderApp.Repository;

namespace BartenderApp.Controllers
{
    public class OrderController : Controller
    {
        private FakeRepository _fakeRepository;
       

        public OrderController(FakeRepository fakeRepository, FakeOrderRepository fakeOrderRepository)
        {
            _fakeRepository = fakeRepository;

        }


        public IActionResult Index()
        {

            IEnumerable<Drink> drinks = _fakeRepository.Drinks;

             Console.WriteLine("Showing drinks");
             drinks = drinks.OrderBy(x => x.DrinkId);
             
            return View(drinks.ToList());
        }
        [HttpGet]
        public IActionResult OrderForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OrderForm(DrinkOrder drinkOrder)
        {
            FakeOrderRepository.AddOrder(drinkOrder);
            return View("Thanks", drinkOrder);
        }
        [HttpGet]
        //CompletedOrders refers to completed order forms not orders made**
        public IActionResult CompletedOrders()
        {
            return View(FakeOrderRepository.Orders);
        }
        [HttpPost]
        public IActionResult FinishedPrep(DrinkOrder drinkOrder)
        {
            FakeOrderRepository.DeleteOrder(drinkOrder);
            return View("~/Views/Order/CompletedOrders.cshtml");
        }

    }
}
