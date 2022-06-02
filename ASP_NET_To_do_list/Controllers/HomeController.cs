using ASP_NET_To_do_list.Models;
using ASP_NET_To_do_list.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_To_do_list.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IToDoListService _toDoListService;

        //public HomeController(ILogger<HomeController> logger)
        public HomeController(IToDoListService service)
        {
            //_logger = logger;
            _toDoListService = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ToDoList()
        {
            return View(_toDoListService.Get());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult AddTask(TaskViewModel taskViewModel)
        {
            _toDoListService.Add(taskViewModel.Task);
            return View("ToDoList", _toDoListService.Get());
        }

        public IActionResult RemoveTask(TaskViewModel taskViewModel)
        {
            _toDoListService.Remove(taskViewModel.Id);
            return View("ToDoList", _toDoListService.Get());
        }

    }
}
