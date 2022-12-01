using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using REAFinalTask.Business.Abstract;
using REAFinalTask.DataAccess.EF;
using REAFinalTask.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace REAFinalTask.AdminUI.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        Context adminContext = new Context();

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User model)
        {

            var infos = adminContext.Users.SingleOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);

            if (infos != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, infos.UserName),
                    new Claim(ClaimTypes.Role, infos.UsRole)

                };
                var identity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            _userService.AddUser(user);
            return RedirectToAction("Login");
        }
    }
}
