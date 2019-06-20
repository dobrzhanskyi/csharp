using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
	public class DefaultDiscountHelper : IDiscountHelper
	{
		private decimal _discountSize;
		public DefaultDiscountHelper(decimal discountParam)
		{
			_discountSize = discountParam;
		}
		public decimal ApplyDiscount(decimal totalParam)
		{
			return (totalParam - (_discountSize / 100m * totalParam));
		}
	}
}