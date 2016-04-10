using BootstrappingMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrappingMVC.Controllers
{
    public class PersonController : BaseController
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
                Success(string.Format("<b>{0}</b> was successfully added to the database.", person.FirstName), true);
                return RedirectToAction("Index");
            }
            Danger("Looks like something went wrong. Please check your form.");
            return View(person);
        }
    }
}