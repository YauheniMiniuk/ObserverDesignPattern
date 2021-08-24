using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObserverDesignPattern.Models;

namespace ObserverDesignPattern.Controllers
{
    public class HomeController : Controller
    {
        private IMessages repository;
        public HomeController(IMessages msg)
        {
            repository = msg;
        }
        public ViewResult Index()
        {
            Console.WriteLine("Hello");
            return View(repository.Messages);
        }
        public ViewResult Create() => View();
        [HttpPost]
        public IActionResult Create(Message message)
        {
            repository.AddMessage(message);
            return RedirectToAction(nameof(Index));
        }
    }
}
