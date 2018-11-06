using PizzaAflevering.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaAflevering.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult PizzaOrderList()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            var dd = (from p in dbContext.Pizzas select p).ToList();

            return View(dd);
        }
        public ActionResult PizzaCreator()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult PizzaCreator(Pizza pizza)
        {
            ViewBag.Message = "Your contact page.";
            using(var context = new DataClasses1DataContext())
            {
                context.Pizzas.InsertOnSubmit(pizza);
                context.SubmitChanges();
            }
            return RedirectToAction("Index","Home");
        }
        public ActionResult PizzaDeleter()
        {
            return View();
        }

        [HttpDelete]
        public ActionResult PizzaDeleter(int id)
        {
            using (var context = new DataClasses1DataContext())
            {
                var thePizza = (from p in context.Pizzas where p.Id == id select p).First();
                context.Pizzas.DeleteOnSubmit(thePizza);
                context.SubmitChanges();
            }
            return RedirectToAction("PizzaOrderList", "Home");
        }
    }
}