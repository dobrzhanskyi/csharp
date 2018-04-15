using System.Collections.Generic;

namespace CashBox
{
	//public List<Stock> stock = new List<Stock>();
	//public void createStock(int barcode,int count)
	//{
	//	stock.Add(new Stock(getItemFromBarcode(barcode), count));
	//}

	class Operations
	{
		public List<Item> itemList = new List<Item>();
		public void createItem(int barcode, int price,int balance)
		{
			itemList.Add(new Item(barcode, price, balance));
		}
	
		private Item GetItemFromBarcode(int barcode)
		{
			foreach (var items in itemList)
			{
				if (items.Barcode == barcode)
				{
					return items;
				}
			}
			return null;
		}

		public void SellFromItem(int barcode,int count)
		{		
			for (int i = 0; i < itemList.Count; i++)
				{
				Item item = itemList[i];
				if (item.Barcode == barcode)
				{
					int tmpCount = item.Balance;
					if (count >= tmpCount)
					{
						RemoveItemFromItem(item);
						count -= tmpCount;
						i--;
					}
					else
					{
						item.Balance -= count;
						break;
					}
				}
			}
		}

		private void RemoveItemFromItem(Item item)
		{
			itemList.Remove(item);
		}
	}
}
