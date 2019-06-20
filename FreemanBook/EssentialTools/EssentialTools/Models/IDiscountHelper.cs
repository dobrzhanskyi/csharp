using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTools.Models
{
	public interface IDiscountHelper
	{
		 decimal ApplyDiscount(decimal totalParam);
	}
}
