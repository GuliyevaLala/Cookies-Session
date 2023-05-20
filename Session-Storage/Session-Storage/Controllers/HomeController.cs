using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session_Storage.Models;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json;

namespace Session_Storage.Controllers {
    public class HomeController : Controller {

        public IActionResult Index()
        {
            //HttpContext.Session.SetString("name", "Lala");
            //HttpContext.Session.SetInt32("age", 25);

            //Response.Cookies.Append("surname", "Quliyeva");


            //Book book1 = new()
            //{
            //    Id= 1,
            //    Title= "Lilac on the Valley",
            //    Author = "Honore de Balzac"

            //};
            //var serializedObject = JsonSerializer.Serialize(book1);
            //HttpContext.Session.SetString("book", serializedObject);

            if (HttpContext.Session.GetString("user") != null)
            {
                User user = JsonSerializer.Deserialize<User>(HttpContext.Session.GetString("user"));
                ViewBag.username = user.Username;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            //ViewBag.age = HttpContext.Session.GetInt32("age");
            //ViewBag.name = HttpContext.Session.GetString("name");
            //ViewBag.surname = Request.Cookies["surname"];

            //var model = JsonSerializer.Deserialize<Book>(HttpContext.Session.GetString("book"));
            //return View(model);
            return View();

        }


    }
    //class Book
    //{
    //    public int Id { get; set; }
    //    public string? Title { get; set; }
    //    public string? Author { get; set; }
    //}
}