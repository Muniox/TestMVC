using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test.Application.TodoList;
using Test.Application.TodoList.Dto;
using Test.Web.Models;

namespace Test.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITodoTaskService _todoTaskService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ITodoTaskService todoTaskService)
        {
            _logger = logger;
            _todoTaskService = todoTaskService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var TodoTasks = await _todoTaskService.GetAllTodoTasks();

            _logger.LogDebug("Wyswietlono TodoTasks");
            return View(TodoTasks);
        }

        [HttpGet]
        public async Task<IActionResult> CreateTodoTask()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodoTask(CreateTodoTaskServiceDto dto)
        {
            await _todoTaskService.CreateTodoTask(dto);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
