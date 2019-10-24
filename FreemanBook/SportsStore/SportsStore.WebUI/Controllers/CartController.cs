using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
	public class CartController : Controller
	{
		private IProductRepository _repository;

		public CartController(IProductRepository repo)
		{
			_repository = repo;
		}

		public ViewResult Index(string returnUrl)
		{
			return View(new CartIndexViewModel
			{
				Cart = getCart(),
				ReturnUrl = returnUrl
			});
		}

		public RedirectToRouteResult AddToCart(int productId, string returnUrl)
		{
			Product product = _repository.Products
				.FirstOrDefault(p => p.ProductID == productId);
			if (product != null)
			{
				getCart().AddItem(product, 1);
			}
			return RedirectToAction("Index", new { returnUrl });
		}

		public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
		{
			Product product = _repository.Products
				.FirstOrDefault(p => p.ProductID == productId);
			if (product != null)
			{
				getCart().RemoveLine(product);
			}
			return RedirectToAction("Index", new { returnUrl });
		}

		private Cart getCart()
		{
			Cart cart = (Cart)Session["Cart"];
			if (cart == null)
			{
				cart = new Cart();
				Session["Cart"] = cart;
			}
			return cart;
		}
	}
}