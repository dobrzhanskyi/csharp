using System.Collections.Generic;

namespace EssentialTools.Models
{
	public class ShoppingCart
	{

		#region Private Fields

		private IValueCalculator _calc;

		#endregion Private Fields


		#region Public Constructors

		public ShoppingCart(IValueCalculator calcParam)
		{
			_calc = calcParam;
		}

		#endregion Public Constructors


		#region Public Properties

		public IEnumerable<Product> Products { get; set; }

		#endregion Public Properties


		#region Public Methods

		public decimal CalculateProductTotal()
		{
			return _calc.ValueProducts(Products);
		}

		#endregion Public Methods
	}
}