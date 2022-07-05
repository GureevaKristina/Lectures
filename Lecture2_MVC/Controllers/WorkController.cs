using Lecture2_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture2_MVC.Controllers
{
    public class WorkController : Controller
    {
        private ILogger<WorkController> logger;
        public WorkController(ILogger<WorkController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View( new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public IActionResult View()
        {
            return View( new List<CarModel> { 
                new CarModel { 
                    Color= "Yellow",
                    Year = 2020,
                    Model = "BMW"
            } ,
                  new CarModel {
                    Color= "Blue",
                    Year = 2003,
                    Model = "Tavria"
            },
                    new CarModel {
                    Color= "Баклажан",
                    Year = 1990,
                    Model = "Lada"
            }
            });
        }
    }
}
