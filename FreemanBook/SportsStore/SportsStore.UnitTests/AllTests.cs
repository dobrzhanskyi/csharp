using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Controllers;
using SportsStore.WebUI.Models;

namespace SportsStore.UnitTests
{
	[TestClass]
	public class AllTests
	{
		[TestMethod]
		public void Can_Paginate()
		{
			//Arrange
			Mock<IProductRepository> mock = new Mock<IProductRepository>();
			mock.Setup(m => m.Products).Returns(new Product[]
			{
			new Product { ProductID = 1, Name = "P1" },
			new Product { ProductID = 2, Name = "P2" },
			new Product { ProductID = 3, Name = "P3" },
			new Product { ProductID = 4, Name = "P4" },
			new Product { ProductID = 5, Name = "P5" }
			}.AsQueryable());

			ProductController controller = new ProductController(mock.Object);

			controller.PageSize = 3;

			//Act
			ProductListViewModel result = (ProductListViewModel)controller.List(null, 2).Model;

			//Assert
			Product[] prodArray = result.Products.ToArray();
			Assert.IsTrue(prodArray.Length == 2);
			Assert.AreEqual(prodArray[0].Name, "P4");
			Assert.AreEqual(prodArray[1].Name, "P5");
		}

		[TestMethod]
		public void Can_Filter_Products()
		{
			Mock<IProductRepository> mock = new Mock<IProductRepository>();
			mock.Setup(m => m.Products).Returns(new Product[]
			{
			new Product { ProductID = 1, Name = "P1", Category = "Cat1" },
			new Product { ProductID = 2, Name = "P2", Category = "Cat2" },
			new Product { ProductID = 3, Name = "P3", Category = "Cat1" },
			new Product { ProductID = 4, Name = "P4", Category = "Cat2" },
			new Product { ProductID = 5, Name = "P5", Category = "Cat3" }
			}.AsQueryable());

			ProductController controller = new ProductController(mock.Object);
			controller.PageSize = 3;

			Product[] result = ((ProductListViewModel)controller
			.List("Cat2", 1).Model)
			.Products.ToArray();

			Assert.AreEqual(result.Length, 2);
			Assert.IsTrue(result[0].Name == "P2" && result[0].Category == "Cat2");
			Assert.IsTrue(result[1].Name == "P4" && result[1].Category == "Cat2");
		}
	}
}