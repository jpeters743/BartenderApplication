﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Controllers
{
    public class QueueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
