using System;
using EssentialTools.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTools.Test
{
	[TestClass]
	public class UnitTest1
	{
		private IDiscountHelper getTestObject()
		{
			return new MinimumDiscountHelper();
		}

		[TestMethod]
		public void Discount_Above_100()
		{
			IDiscountHelper target = getTestObject();
			decimal total = 200;

			var discountedTotal = target.ApplyDiscount(total);

			Assert.AreEqual(total * 0.9M, discountedTotal);
		}

		[TestMethod]
		public void Discount_Beetween_10_And_100()
		{
			IDiscountHelper target = getTestObject();

			decimal tenDollarDiscount = target.ApplyDiscount(10);
			decimal hundredDollarDiscount = target.ApplyDiscount(100);
			decimal fiftyDollarDiscount = target.ApplyDiscount(50);

			Assert.AreEqual(5, tenDollarDiscount, "10 dollar discount is wrong");
			Assert.AreEqual(45, fiftyDollarDiscount, "50 dollar discount is wrong");
			Assert.AreEqual(95, hundredDollarDiscount, "100 dollar discount is wrong");
		}

		[TestMethod]
		public void Discount_Less_Than_10()
		{
			IDiscountHelper target = getTestObject();

			decimal discount5 = target.ApplyDiscount(5);
			decimal discount0 = target.ApplyDiscount(0);

			Assert.AreEqual(5, discount5);
			Assert.AreEqual(0, discount0);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Discount_Negative()
		{
			IDiscountHelper target = getTestObject();
			target.ApplyDiscount(-1);
		}
	}
}