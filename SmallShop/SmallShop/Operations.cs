using System;
using System.Collections.Generic;
using System.IO;

namespace SmallShop
{
	class Operations
	{
		public List<Item> Item = new List<Item>();
		public List<Stock> StockList = new List<Stock>();

		public void AddNewItem(string itemValues)
		{
			if (string.IsNullOrEmpty(itemValues))
			{
				return;
			}
			//TODO: Parse exception
			string[] valuesSubstring = itemValues.Split(' ');
			int barcode = Convert.ToInt32(valuesSubstring[0]);
			string name = valuesSubstring[1];
			double price = Convert.ToDouble(valuesSubstring[2]);
			CreateItem(barcode, name, price);
			return;
		}
		public void DisplayPriceList()
		{
			foreach (var items in Item)
			{
				Console.WriteLine(items.ToString());
			}
		}

		public void DisplayStock()
		{
			foreach (var items in StockList)
			{
				Console.WriteLine(items.ToString());
			}

		}
		public void DisplayGroupedStock()
		{

			foreach (var items in GroupStockItems(StockList))
			{
				Console.WriteLine(items.ToString());
			}

		}
		private List<Stock> GroupStockItems(List<Stock> list)
		{
			List<Stock> groupedList = new List<Stock>();
			int quantity = 0;
			foreach (var item in list)
			{
				if (item.Item.Barcode == item.Item.Barcode)
				{
					quantity += item.Count;
				}
				groupedList.Add(new Stock(item.Item, quantity, item.Date));
			}
			return groupedList;
		}
		private Item GetItemFromBarcode(int barcode)
		{
			foreach (var items in Item)
			{
				if (items.Barcode == barcode)
					return items;
			}
			return null;
		}

		public void TakeToStock(string stockValues)
		{
			string[] subStockValue = stockValues.Split(' ');
			int barcode = Convert.ToInt32(subStockValue[0]);
			int count = Convert.ToInt32(subStockValue[1]);
			//int oneStockValue = 1;
			//for (int i = 0; i < count; i++)
			//{
			StockList.Add(new Stock(GetItemFromBarcode(barcode), count, DateTime.Now));
			//}
		}
		public void SellFromStock(string stockValues)
		{
			string[] subStockValue = stockValues.Split(' ');
			int barcode = Convert.ToInt32(subStockValue[0]);
			int count = Convert.ToInt32(subStockValue[1]);

			foreach (var item in GroupStockItems(StockList))
			{
				if (item.Item.Barcode == barcode)
				{
					if (count <= item.Count)
					{
						item.Count -= count;
					}
					return;
				}
				return;
			}
		}
		public void RemoveItem(string itemValues)
		{
			int barcode = Convert.ToInt32(itemValues);
			Item.Remove(new Item(barcode));
		}
		private void CreateItem(int barcode, string name, double price)
		{
			Item.Add(new Item(barcode, name, price));
		}
		public void SaveToFile(List<Item> messages)
		{
			using (StreamWriter stream = new StreamWriter(@"pricelist.ms"))
			{
				for (int i = 0; i < Item.Count; i++)
				{
					stream.WriteLine(messages[i].ToString());
				}
			}
		}
	}
}
