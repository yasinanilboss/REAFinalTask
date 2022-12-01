using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using REAFinalTask.Business.Abstract;
using REAFinalTask.Entities;
using System.Data;

namespace REAFinalTask.AdminUI.Controllers
{
    public class ToDoController : Controller
    {
        IToDoService _todoService;

        public ToDoController(IToDoService todoService)
        {
            _todoService = todoService;
        }

        public IActionResult Index()
        {
            var _values = _todoService.ListAllToDo();
            return View(_values);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Add(ToDo todo)
        {
            _todoService.AddToDo(todo);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id)
        {
            ToDo _single = _todoService.GetById(id);
            return View(_single);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(ToDo todo)
        {
            _todoService.UpdateToDo(todo);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            ToDo _single = _todoService.GetById(id);
            _todoService.DeleteToDo(_single);
            return RedirectToAction("Index");
        }
    }
}
