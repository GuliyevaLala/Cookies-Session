using Microsoft.AspNetCore.Mvc;
using Session_Storage.Models;
using Session_Storage.ViewModels;
using System.Text.Json;

namespace Session_Storage.Controllers {
    public class AccountController : Controller {

        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginVM model)
        {
            List<User> dbusers = GetAll();

            var findUserByEmail = dbusers.FirstOrDefault(m=> m.Email == model.Email);

            if (findUserByEmail == null)
            {
                ViewBag.error = "Email or password is incorrect";
                return View();
            }

            if (findUserByEmail.Password != model.Password)
            {
                ViewBag.error = "Email or password is incorrect";
                return View();
            }

            HttpContext.Session.SetString("user", JsonSerializer.Serialize(findUserByEmail));

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }


        private List<User> GetAll()
        {
            User user1 = new()
            {
                Id = 1,
                Username = "lalahepburn",
                Email = "Lalaig@code.edu.az",
                Password = "Lalala"
            };
            User user2 = new()
            {
                Id = 2,
                Username = "gultajjj",
                Email = "gultaj13@gmail.com",
                Password = "gultajjj111"
            };
            User user3 = new()
            {
                Id = 3,
                Username = "Nona",
                Email = "a_novreste@gmail.com",
                Password = "Nona159"
            };
 
            List<User> users = new List<User>() { user1, user2, user3 };

            return users;
        }
    }
}
