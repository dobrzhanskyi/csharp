using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.Domain.Entities;

namespace SportsStore.UnitTests
{
	[TestClass]
	public class CartTest
	{
		[TestMethod]
		public void Can_Add_New_Lines()
		{
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 1);

			CartLine[] results = target.Lines.ToArray();

			Assert.AreEqual(results.Length, 2);
			Assert.AreEqual(results[0].Product, p1);
			Assert.AreEqual(results[1].Product, p2);
		}

		[TestMethod]
		public void Can_Add_Quantity_For_Existing_Product()
		{
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 1);
			target.AddItem(p1, 10);

			CartLine[] results = target.Lines.OrderBy(c => c.Product.ProductID).ToArray();
			Assert.AreEqual(results.Length, 2);
			Assert.AreEqual(results[0].Quantity, 11);
			Assert.AreEqual(results[1].Quantity, 1);
		}

		[TestMethod]
		public void Can_Remove_Line()
		{
			Product p1 = new Product { ProductID = 1, Name = "P1" };
			Product p2 = new Product { ProductID = 2, Name = "P2" };
			Product p3 = new Product { ProductID = 3, Name = "P3" };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 3);
			target.AddItem(p3, 5);
			target.AddItem(p2, 1);

			target.RemoveLine(p2);

			Assert.AreEqual(target.Lines.Where(c => c.Product == p2).Count(), 0);
			Assert.AreEqual(target.Lines.Count(), 2);
		}

		[TestMethod]
		public void Calculate_Cart_Total()
		{
			Product p1 = new Product { ProductID = 1, Name = "P1", Price = 100M };
			Product p2 = new Product { ProductID = 2, Name = "P2", Price = 50M };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 3);
			target.AddItem(p1, 2);

			decimal result = target.ComputeTotalValue();

			Assert.AreEqual(result, 450M);
		}

		[TestMethod]
		public void Can_Clear_Cart()
		{
			Product p1 = new Product { ProductID = 1, Name = "P1", Price = 100M };
			Product p2 = new Product { ProductID = 2, Name = "P2", Price = 50M };

			Cart target = new Cart();

			target.AddItem(p1, 1);
			target.AddItem(p2, 3);
			target.AddItem(p1, 3);

			target.Clear();

			Assert.AreEqual(target.Lines.Count(), 0);
		}
	}
}