using BuyerGuide.ApplicationInterfaces;
using BuyerGuide.ApplicationServices;
using BuyerGuide.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BuyerGuide.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOutletService _outletService;

        public HomeController(IOutletService outletService)
        {
            _outletService = outletService;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }

            return View(_outletService.GetAll());
        }

        [HttpPost]
        public IActionResult Index(string searchString, Specialization specialization, TypeOfOwnership typeOfOwnership)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View();
            }

            return View(_outletService.GetAll(searchString, typeOfOwnership, specialization));
        }

        [HttpPost]
        public IActionResult Print(int[] ides)
        {
            var result = new List<Outlet>();
            foreach(var id in ides)
            {
                try
                {
                    result.Add(_outletService.Get(id));
                }
                catch { }
            }

            return View(result);
        }
    }
}
