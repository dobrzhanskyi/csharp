using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
	public interface IValueCalculator
	{
		decimal ValueProducts(IEnumerable<Product> products);
	}
}