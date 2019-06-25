using System;
using System.Web.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers
{
	public class HomeController : Controller
	{
		BookContext db = new BookContext();
		public ActionResult Index()
		{
			var books = db.Books;
			ViewBag.Books = books;
			return View();
		}
		[HttpGet]
		public ActionResult Buy(int id)
		{
			ViewBag.BookId = id;
			return View();
		}
		[HttpPost]
		public string Buy(Purchase purchase)
		{
			purchase.Date = DateTime.Now;
			db.Purchases.Add(purchase);
			db.SaveChanges();
			return "Thank you, " + purchase.Person + ",for your order";
		}
	}
}