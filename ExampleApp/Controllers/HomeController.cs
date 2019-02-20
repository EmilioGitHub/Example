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
        OrderContext db = new OrderContext();
        DateTime dateBegin;

        public ActionResult Index()
        {
           IEnumerable<Item> items = db.Items;
            ViewBag.Items = items;
            return View();
        }  

        public ActionResult Details(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            dateBegin = DateTime.Now;
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public string Buy(Order order)
        {
            order.DateBegin = dateBegin;
            order.DateEnd = DateTime.Now;
            order.Status = OrderStatus.Closed;
            db.Orders.Add(order);
            db.SaveChanges();
            return "Товар №" + order.Id + " приобретен!";
        }

        [HttpGet]
        public ActionResult EditItem(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public string EditItem(Item item)
        {
            db.Items.Remove(item);
            db.SaveChanges();
            return "Товар \"" + item.Name + "\" был отредактирован!";
        }

        public string DeleteItem(Item item)
        {
            db.Items.Remove(item);
            db.SaveChanges();
            return "Товар \"" + item.Name + "\" был удален!";
        }

        [HttpGet]
        public ActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public string AddItem(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return "Товар \"" + item.Name + "\" был успешно добавлен!";
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