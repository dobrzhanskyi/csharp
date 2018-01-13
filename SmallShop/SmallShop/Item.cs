using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
	class Item
	{
		public string Name { get => Name; set => Name = value; }
		public int Barcode { get => Barcode; set => Barcode = value; }
		public double Price { get => Price; set => Price = value; }

		public Item(int barcode, string name, double price)
		{
			this.Barcode = barcode;
			this.Name = name;
			this.Price = price;
		}
	}
}
