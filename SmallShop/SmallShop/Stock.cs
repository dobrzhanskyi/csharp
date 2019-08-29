using System;

namespace SmallShop
{
	internal class Stock
	{
		public int Count;
		public Item Item;
		readonly public DateTime Date = DateTime.Now;

		public Stock(Item item, int count, DateTime date)
		{
			Item = item;
			Count = count;
			Date = date;
		}

		public override string ToString()
		{
			return $"{Item.Barcode} {Count} {Date}";
		}

		public string FileSavingFormat()
		{
			return $"{Item.Barcode}|{Count}|{Date}";
		}
	}
}