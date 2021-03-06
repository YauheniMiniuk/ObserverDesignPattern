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
        private IMessageService messageService;
        public HomeController(IMessages msg, IMessageService msgService)
        {
            repository = msg;
            messageService = msgService;
        }
        public ViewResult Index(Message message)
        {
            ViewBag.Messages = repository.Messages;
            return View(message);
        }
        public ViewResult Create() => View();
        [HttpPost]
        public IActionResult Create(Message message)
        {
            messageService.UpdateMessage(message);

            repository.AddMessage(message);
            return RedirectToAction(nameof(Index));
        }
        public Message GetMessages(Message message)
        {
            repository.AddMessage(message);
            return repository.Messages.Last();
        }
    }
}
