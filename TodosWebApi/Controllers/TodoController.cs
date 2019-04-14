using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TodosWebApi.Controllers
{
    //Do rozwiązania zadań użyj LINQ
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

        [HttpGet("find/{id}")]
        public IActionResult GetTask(int id)
        {
            //TODO: zwróć wszystkie informacje o zadaniu z danym id
            throw new NotImplementedException();
        }

        [HttpGet("notdone")]
        public IActionResult NotDone()
        {
            //TODO: zwróć wszystkie rzeczy które nie są zrobione
            throw new NotImplementedException();
        }

        [HttpGet("done")]
        public IActionResult GetDone()
        {
            //TODO: zwróć wszystkie rzeczy które są zrobione
            throw new NotImplementedException();
        }

        [HttpGet("sortByDate")]
        public IActionResult GetByDate()
        {
            //TODO: zwróć wszystkie rzeczy posortowane po dacie dotania
            throw new NotImplementedException();
        }

        [HttpGet("incomings")]
        public IActionResult GetIncomings()
        {
            //TODO: zwróć wszystkie zadania które są jeszcze nie skończone ale data zakończenia jest po obecnej dacie
            throw new NotImplementedException();
        }

        [HttpGet("tasks")]
        public IActionResult GetNames()
        {
            //TODO: zwróc wszystkie zadania - dane endpoint powinien zwracać tylko nazwę zadania i jego id
            throw new NotImplementedException();
        }

        [HttpGet("group")]
        public IActionResult GetGroups()
        {
            //TODO: zlicz ile zadań w każdym z typie i zwróc ta informację
            throw new NotImplementedException();
        }

        [HttpGet("threshold")]
        public IActionResult GetByThreshold(DateTime startDate, DateTime endDate)
        {
            //TODO: zwróć wszystkie zadania które są do zrobienia w danym okresie czasu
            throw new NotImplementedException();
        }

        [HttpGet("byType")]
        public IActionResult GetByType(TodoType type)
        {
            //TODO: zwróć wszystkie zadania z danego typu
            throw new NotImplementedException();
        }

        [HttpGet("find")]
        public IActionResult GetTaskByName(string name)
        {
            //TODO: zwróć wszystkie informacje o zadaniu o podanej nazwie
            throw new NotImplementedException();
        }

        //*TODO: napisz brakujące endpointy
        //1. Zwraca wszystkie zadania które zostały wykonane po terminie
        //2. Zwraca wszystkie zadania które nie zostały wykonane, a ich termin minął
        //3. Zwraca informacje jak długo zadanie było realizowane (by id)
        //4. Zwraca wszystkie zadania które są do wykonania w podanej nadchodzącej liczbie dni
    }
}
