using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tenant_turner.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace tenant_turner.Controllers
{
    public class HomeController : Controller
    {
        public User loggedUser
        {
            get
            {
                return dbContext.Users
                .Include(u => u.Managed_Rentals)
                .FirstOrDefault(u => u.Userid == HttpContext.Session.GetInt32("Userid"));

            }
        }
        private MyContext dbContext;
 
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        //////////MAIN HOMEPAGE ROUTE /////////////
        public IActionResult Index()
        {
            ViewBag.Homepage = true;
            ViewBag.User = loggedUser;
            return View();
        }
        //////////LIST OF RENTALS PAGE /////////////
        [HttpGet("Rentals")]
        public IActionResult Rentals()
        {
            List<Rental> AllRentals = dbContext.Rentals
            .Include(r => r.Pictures)
            .ToList();
            ViewBag.User = loggedUser;
            return View(AllRentals);
        }
        //////////ABOUT US PAGE /////////////
        [HttpGet("About")]
        public IActionResult About()
        {
            List<User> AllAdmins = dbContext.Users.Where(u => u.Admin_Lvl == 1).ToList();
            ViewBag.User = loggedUser;
            return View(AllAdmins);
        }
        //////////BENEFITS PAGE (INCOMPLETE) /////////////
        [HttpGet("benefits")]
        public IActionResult Benefits()
        {
            ViewBag.User = loggedUser;
            return View();
        }
        //////////HOW IT WORKS PAGE (INCOMPLETE) /////////////
        [HttpGet("how-it-works")]
        public IActionResult HowItWorks()
        {
            ViewBag.User = loggedUser;
            return View();
        }
        //////////PRICING PAGE (INCOMPLETE) /////////////
        [HttpGet("pricing")]
        public IActionResult Pricing()
        {
            ViewBag.User = loggedUser;
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.User = loggedUser;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.User = loggedUser;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
