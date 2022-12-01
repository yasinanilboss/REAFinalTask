using Microsoft.AspNetCore.Mvc;
using REAFinalTask.Business.Abstract;
using REAFinalTask.Entities;
using System.Collections.Generic;

namespace REAFinalTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : Controller
    {
        IToDoService _todoService;

        public TaskController(IToDoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        [Route("GetAll")]
        public List<ToDo> GetAll()
        {
            return _todoService.ListAllToDo();
        }

        [HttpGet]
        [Route("Get")]
        public ToDo Get(int id)
        {
            return _todoService.GetById(id);
        }

        [HttpPost]
        public int Post([FromBody] ToDo todo)
        {
            return _todoService.AddToDo(todo);
        }

        [HttpPut] 
        public int Put([FromBody] ToDo todo)
        {
            return _todoService.UpdateToDo(todo);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var todo = _todoService.GetById(id);
            _todoService.DeleteToDo(todo);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
