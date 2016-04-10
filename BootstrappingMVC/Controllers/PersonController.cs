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
        private static List<Person> _people;

        static PersonController()
        {
            GenFu.GenFu.Configure<Person>()
                .Fill(p => p.LikesMusic).WithRandom(new List<bool>() { true, true, true, false, false })
                .Fill(p => p.Skills, () => new List<string>() { "Math", "Science", "History" });
            _people = GenFu.A.ListOf<Person>(20);
        }

        // GET: Person
        public ActionResult Index()
        {
            return View(_people);
        }

        public ActionResult SearchPeople(string searchText)
        {
            var term = searchText.ToLower();
            var result = _people
                .Where(p =>
                    p.FirstName.ToLower().Contains(term) ||
                    p.LastName.ToLower().Contains(term)
                );

            return PartialView("_SearchPeople", result);
        }

        // GET
        public ActionResult Create()
        {
            var person = new Person();
            return View(person);
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                _people.Add(person);
                return RedirectToAction("Index");
            }

            return View(person);
        }
    }
}