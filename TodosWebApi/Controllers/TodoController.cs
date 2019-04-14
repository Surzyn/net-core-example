using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TodosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        ITodoRepository _todoRepository;

        //Dependency Injection - prosimy o wstrzyknięcie obiektu który implementuje interface ITodoRepository 
        //Obiekt ten jest skonfigurowany w Startup.cs ConfigureServices()
        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet]
        public IActionResult GetAllTodos()
        {
            return Ok(_todoRepository.GetTodos());
        }

    
    }
}
