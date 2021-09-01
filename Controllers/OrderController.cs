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

        public OrderController(FakeRepository fakeRepository)
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
        public IActionResult Order()
        {
            return View();
        }
    }
}
