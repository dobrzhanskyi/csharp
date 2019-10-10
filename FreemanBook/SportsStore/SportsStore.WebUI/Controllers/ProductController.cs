using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private IProductRepository _repository;
		public int PageSize = 4;

		public ProductController(IProductRepository productRepository)
		{
			_repository = productRepository;
		}

		public ViewResult List(string category, int page = 1)
		{
			ProductListViewModel model = new ProductListViewModel
			{
				Products = _repository.Products
				.Where(p => category == null || p.Category == category)
				.OrderBy(p => p.ProductID)
				.Skip((page - 1) * PageSize)
				.Take(PageSize),

				PagingInfo = new PagingInfo
				{
					CurrentPage = page,
					ItemsPerPage = PageSize,
					TotalItems = category == null ?
					_repository.Products.Count() :
					_repository.Products.Where(e=>e.Category==category).Count()
				},

				CurrentCategory = category
			};
			return View(model);
		}
	}
}