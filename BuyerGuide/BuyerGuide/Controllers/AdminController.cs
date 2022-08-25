using BuyerGuide.ApplicationInterfaces;
using BuyerGuide.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuyerGuide.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        private readonly IOutletService _outletService;
        public AdminController(IOutletService outletService)
        {
            _outletService = outletService;
        }

        public IActionResult AddOutlet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOutlet(Outlet outlet)
        {
            if (ModelState.IsValid)
            {
                _outletService.Add(outlet);
                return Redirect("../Home/Index");
            }

            return View(outlet);
        }

        public IActionResult Update(int id)
        {
            return View(_outletService.Get(id));
        }


        [HttpPost]
        public IActionResult Update(Outlet outlet)
        {
            if (ModelState.IsValid)
            {
                _outletService.Update(outlet);
                return RedirectToAction("Index", "Home");
            }

            return View(outlet);
        }

        public IActionResult Remove(int id)
        {
            _outletService.Remove(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
