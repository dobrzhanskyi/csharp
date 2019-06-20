using System.Web.Mvc;
using EssentialTools.Models;
using Ninject;

namespace EssentialTools.Controllers
{
	public class HomeController : Controller
	{
		#region Private Fields
		private IValueCalculator _calc;
		public HomeController(IValueCalculator calcParam)
		{
			_calc = calcParam;
		}
		private Product[] _products =
		{
			new Product{Name="Kayak",Category="WaterSports",Price=275M},
			new Product{Name="LifeJacket",Category="WaterSports",Price=48.95M},
			new Product{Name="Soccer Ball",Category="Soccer",Price=19.50M},
			new Product{Name="Corner flag",Category="Soccer",Price=34.95M}
		};

		#endregion Private Fields

		#region Public Methods

		public ActionResult Index()
		{		
			ShoppingCart _cart = new ShoppingCart(_calc) { Products = _products };
			decimal _totalValue = _cart.CalculateProductTotal();
			return View(_totalValue);
		}

		#endregion Public Methods
	}
}