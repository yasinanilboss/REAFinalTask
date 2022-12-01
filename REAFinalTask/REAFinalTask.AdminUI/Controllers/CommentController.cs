using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using REAFinalTask.Business.Abstract;
using REAFinalTask.Entities;

namespace REAFinalTask.AdminUI.Controllers
{
    public class CommentController : Controller
    {
        ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var _values = _commentService.ListAllComment();
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
        public IActionResult Add(Comment comment)
        {
            _commentService.AddComment(comment);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id)
        {
            Comment _single = _commentService.GetById(id);
            return View(_single);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(Comment comment)
        {
            _commentService.UpdateComment(comment);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            Comment _single = _commentService.GetById(id);
            _commentService.DeleteComment(_single);
            return RedirectToAction("Index");
        }
    }
}
