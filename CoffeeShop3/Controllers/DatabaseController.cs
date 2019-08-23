using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop3.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop3.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly CoffeeShopDbContext _context;

        public DatabaseController(CoffeeShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakeNewUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                _context.User.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Shop");
            }
            return View();
        }

        public IActionResult Shop()
        {
            List<Items> itemList = _context.Items.ToList();
            return View(itemList);
        }
    }
}