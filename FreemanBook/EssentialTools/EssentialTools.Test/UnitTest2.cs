using System.Linq;
using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EssentialTools.Test
{
	[TestClass]
	public class UnitTest2
	{
		private Product[] _products =
		{
			new Product{Name="Kayak",Category="WaterSports",Price=275M},
			new Product{Name="LifeJacket",Category="WaterSports",Price=48.95M},
			new Product{Name="Soccer Ball",Category="Soccer",Price=19.50M},
			new Product{Name="Corner flag",Category="Soccer",Price=34.95M}
		};

		[TestMethod]
		public void Sum_Products_Correctly()
		{
			//arrange
			Mock<IDiscountHelper> mock = new Mock<IDiscountHelper>();
			mock.Setup(m => m.ApplyDiscount(It.IsAny<decimal>())).Returns<decimal>(total => total);
			
			var target = new LinqValueCalculator(mock.Object);
			var goalTotal = _products.Sum(p => p.Price);
			//act
			var result = target.ValueProducts(_products);

			Assert.AreEqual(goalTotal, result);
		}
	}
}