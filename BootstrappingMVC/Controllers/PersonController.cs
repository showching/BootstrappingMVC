using BootstrappingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrappingMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            GenFu.GenFu.Configure<Person>()
                .Fill(p => p.LikesMusic).WithRandom(new List<bool>() { true, true, true, false, false })
                .Fill(p => p.Skills, () => new List<string>() { "Math", "Science", "History" });
            var people = GenFu.A.ListOf<Person>(20);
            return View(people);
        }
    }
}