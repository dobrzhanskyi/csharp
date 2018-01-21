using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
	class Stock
	{
		public int Count { get; set; }

		public Item Item { get; set; }
		readonly public DateTime Date = DateTime.Now;

		public Stock(Item item, int count, DateTime date)
		{
			this.Item = item;
			this.Count = count;
			this.Date = date;
		}
		public override string ToString()
		{
			return $"{Item.Barcode} {Count} {Date}";
		}

	}
}
