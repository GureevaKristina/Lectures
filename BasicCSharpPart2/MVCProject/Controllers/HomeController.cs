using DataLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public class HomeController : Controller
    {
        private List<UserModel> UserModels { get; set; }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            UserModels = new List<UserModel>
            {
                new UserModel { Age = 23, FirstName="Ann", LastName="Test "},
                new UserModel { Age = 32, FirstName="Ann 2", LastName="Test 2"},
                new UserModel { Age = 54, FirstName="Ann 3", LastName="Test 3"},
            };
        }

        public IActionResult Index()
        {
            //using (ApplicationContext db = new ApplicationContext())
            //{
            //    // создаем два объекта Guest
            //    Guest user1 = new Guest { Name = "Tom",Sex = "man" };
            //    Guest user2 = new Guest { Name = "Alice",Sex = "woman"};

            //    // добавляем их в бд
            //    db.Guests.Add(user1);
            //    db.Guests.Add(user2);
            //    db.SaveChanges();
            //    Console.WriteLine("Объекты успешно сохранены");

            //    // получаем объекты из бд и выводим на консоль
            //    var users = db.Guests.ToList();
            //    Console.WriteLine("Список объектов:");
            //    foreach (Guest u in users)
            //    {
            //        Console.WriteLine($"{u.Id}.{u.Name} - {u.Sex}");
            //    }
            //}
            return View();
        }
        [Route("users")]
        [ResponseCache(Location =ResponseCacheLocation.None, NoStore =true)]
        public ActionResult Users()
        {
            return Json(UserModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
