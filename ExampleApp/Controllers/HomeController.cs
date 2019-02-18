using ExampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleApp.Controllers
{
    public class HomeController : Controller
    {
        ProductContext db = new ProductContext();

        public ActionResult Index()
        {
            uint a = 777;

            IEnumerable<Product> products = db.Products;
            ViewBag.Products = products;
            ViewBag.A = a;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public string Buy(Purchase pur)
        {
            pur.Date = DateTime.Now;
            db.Purchases.Add(pur);
            db.SaveChanges();
            return "Товар №" + pur.PurchaseId + " приобретен!";
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
    }
}