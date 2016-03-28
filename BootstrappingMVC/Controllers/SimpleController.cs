using BootstrappingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrappingMVC.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            var person = new Person
            {
                FirstName = "Billy Jo",
                LastName = "McGuffery",
                BirthDate = new DateTime(1990, 6, 1),
                LikesMusic = true,
                Skills = new List<string>() { "Math", "Science", "History" }
            };

            return View(person);
        }
    }
}