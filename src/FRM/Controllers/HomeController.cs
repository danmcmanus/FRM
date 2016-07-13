using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FRM.Contracts;
using FRM.Models;
using FRM.ViewModels;
using FRM.Data;

namespace FRM.Controllers
{
    public class HomeController : Controller
    {
        private IRepositoryBase<Family> _repository;
        private ApplicationDbContext _context;

        public HomeController(IRepositoryBase<Family> repository, ApplicationDbContext context)
        {
            _repository = repository;
            _context = context;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return RedirectToAction("Index", "Family");
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
