using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeopleCars.Data;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new PeopleCarsRepository(Properties.Settings.Default.ConStr);
            return View(repo.GetPeople());
        }

        public ActionResult AddCar(int personId)
        {
            var repo = new PeopleCarsRepository(Properties.Settings.Default.ConStr);
            var person = repo.GetById(personId);
            if (person == null)
            {
                return RedirectToAction("Index");
            }
            return View(person);
        }

        [HttpPost]
        public ActionResult AddCar(Car car)
        {
            var repo = new PeopleCarsRepository(Properties.Settings.Default.ConStr);
            repo.AddCar(car);
            return RedirectToAction("Index");
        }
    }
}