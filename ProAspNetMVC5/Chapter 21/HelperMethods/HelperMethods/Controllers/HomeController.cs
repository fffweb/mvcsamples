using System.Web.Mvc;
using HelperMethods.Models;

namespace HelperMethods.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {

            ViewBag.Fruits = new string[] { "Apple", "Orange", "Pear" };
            ViewBag.Cities = new string[] { "New York", "London", "Paris" };

            string message = "This is an HTML element: <input>";

            return View((object)message);
        }

        public ActionResult IndexInline()
        {

            ViewBag.Fruits = new string[] { "Apple", "Orange", "Pear" };
            ViewBag.Cities = new string[] { "New York", "London", "Paris" };

            string message = "This is an HTML element: <input>";

            return View((object)message);   
        }

        public ActionResult IndexExternal()
        {

            ViewBag.Fruits = new string[] { "Apple", "Orange", "Pear" };
            ViewBag.Cities = new string[] { "New York", "London", "Paris" };

            string message = "This is an HTML element: <input>";

            return View((object)message);
        }

        public ActionResult CreatePerson() {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePerson(Person person) {
            return View(person);
        }

        public ActionResult CreatePersonM()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePersonM(Person person)
        {
            return View(person);

        }

        public ActionResult CreatePersonH()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePersonH(Person person)
        {
            return View(person);

        }
    }
}
