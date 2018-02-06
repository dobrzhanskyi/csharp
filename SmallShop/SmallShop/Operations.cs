using System;
using System.Collections.Generic;
using System.IO;

namespace SmallShop
{
	class Operations
	{
		public List<Item> ItemList = new List<Item>();
		public List<Stock> StockList = new List<Stock>();
		public void ShowError()
		{
			Console.WriteLine("Bad Input");
		}
		public void ShowHelp()
		{
			Console.WriteLine("Availiable commands:");
			Console.WriteLine("add: Add item to pricelist");
			Console.WriteLine("take: Take item to stock");
			Console.WriteLine("sell: Sell item from stock");
			Console.WriteLine("remove: Remove item from pricelist");
			Console.WriteLine("display: Show pricelist");
			Console.WriteLine("displays: Show stock");
			Console.WriteLine("close: Exit and save");
			Console.WriteLine("exit: Exit without saving");
		}
		public void AddNewItem(string itemValues)
		{
			if (string.IsNullOrEmpty(itemValues))
			{
				return;
			}
			try
			{
				string[] valuesSubstring = itemValues.Split(' ');
				int barcode = Convert.ToInt32(valuesSubstring[0]);
				string name = valuesSubstring[1];
				double price = Convert.ToDouble(valuesSubstring[2]);
				createItem(barcode, name, price);
				return;
			}
			catch
			{
				ShowError();
			}
		}

		public void DisplayPriceList()
		{
			foreach (var items in ItemList)
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

		public void Exit()
		{
			savePriceListToFile(ItemList);
			saveStockToFile(StockList);
			Environment.Exit(0);
		}

		private List<Stock> groupStockItems(List<Stock> list)
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

		private Item getItemFromBarcode(int barcode)
		{
			foreach (var items in ItemList)
			{
				if (items.Barcode == barcode)
				{
					return items;
				}
			}
			return null;
		}

		public void TakeToStock(string stockValues)
		{

			try
			{
				string[] subStockValue = stockValues.Split(' ');
				int barcode = Convert.ToInt32(subStockValue[0]);
				int count = Convert.ToInt32(subStockValue[1]);
				if (getItemFromBarcode(barcode) != null)
				{
					StockList.Add(new Stock(getItemFromBarcode(barcode), count, DateTime.Now));
				}
				else
				{
					Console.WriteLine("There is no such item in PriceList");
				}
			}
			catch
			{
				ShowError();
			}
		}

		public void SellFromStock(string stockValues)
		{
			try
			{
				string[] subStockValue = stockValues.Split(' ');
				int barcode = Convert.ToInt32(subStockValue[0]);
				int count = Convert.ToInt32(subStockValue[1]);
				if (!checkItemCountByBarcode(barcode, count))
				{
					return;
				}
				for (int i = 0; i < StockList.Count; i++)
				{
					Stock item = StockList[i];
					if (item.Item.Barcode == barcode)
					{
						int tmpCount = item.Count;
						if (count >= tmpCount)
						{
							removeItemFromStock(item);
							count -= tmpCount;
							i--;
						}
						else
						{
							item.Count -= count;
							break;
						}
					}
				}
			}
			catch
			{
				ShowError();
			}
		}

		private bool checkItemCountByBarcode(int barcode, int count)
		{
			int sum = 0;
			foreach (var item in StockList)
			{
				sum += item.Count;
			}
			return count <= sum;
		}

		public void RemoveItem(string itemValues)
		{
			try
			{
				int barcode = Convert.ToInt32(itemValues);
				ItemList.Remove(new Item(barcode));
			}
			catch
			{
				ShowError();
			}
		}

		private void removeItemFromStock(Stock stock)
		{
			StockList.Remove(stock);
		}

		private void createItem(int barcode, string name, double price)
		{
			ItemList.Add(new Item(barcode, name, price));
		}

		private void savePriceListToFile(List<Item> pricelist)
		{
			using (StreamWriter stream = new StreamWriter(@"pricelist.ms"))
			{
				for (int i = 0; i < ItemList.Count; i++)
				{
					stream.WriteLine(pricelist[i].FileSavingFormat());
				}
			}
		}

		private void saveStockToFile(List<Stock> stock)
		{
			using (StreamWriter stream = new StreamWriter(@"stocklist.ms"))
			{
				for (int i = 0; i < ItemList.Count; i++)
				{
					stream.WriteLine(stock[i].FileSavingFormat());
				}
			}
		}

		public void LoadFiles()
		{
			loadPriceList("pricelist.ms");
			loadStockList("stocklist.ms");
		}

		private void loadPriceList(string path)
		{
			try
			{
				using (StreamReader stream = new StreamReader(path))
				{

					while (!stream.EndOfStream)
					{
						string StringToSplit = stream.ReadLine();
						string[] split = StringToSplit.Split('|');
						int barcode = Convert.ToInt32(split[0]);
						string name = split[1];
						double price = Convert.ToDouble(split[2]);
						ItemList.Add(new Item(barcode, name, price));
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"File {path} doesn't exist!");
			}
		}
		private void loadStockList(string path)
		{
			try
			{
				using (StreamReader stream = new StreamReader(path))
				{
					while (!stream.EndOfStream)
					{
						string StringToSplit = stream.ReadLine();
						string[] split = StringToSplit.Split('|');
						int barcode = Convert.ToInt32(split[0]);
						int count = Convert.ToInt32(split[1]);
						DateTime date = Convert.ToDateTime(split[2]);
						StockList.Add(new Stock(getItemFromBarcode(barcode), count, date));
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"File {path} doesn't exist!");
			}
		}
	}
}
