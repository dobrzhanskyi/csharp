using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
	class Operations
	{
		public List<Item> item = new List<Item>();

		private void CreateNewItem(int barcode, string name, double price)
		{
			item.Add(new Item(barcode, name, price));
		}

		public void SaveToFile(List<Item> messages)
		{
			using (StreamWriter stream = new StreamWriter(@"pricelist.ms"))
			{
				for (int i = 0; i < item.Count; i++)
				{
					stream.WriteLine(messages[i].ToString());
				}
			}
		}
	}
}
