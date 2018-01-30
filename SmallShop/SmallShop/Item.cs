<<<<<<< HEAD
﻿namespace SmallShop
=======
﻿using System;

namespace SmallShop
>>>>>>> e30619efabdd51bd4ddcd33911cd09393b7e0294
{
	class Item
	{
		public string Name { get; set; }
		public int Barcode { get; set; }
		public double Price { get; set; }

		public Item(int barcode)
		{
			this.Barcode = barcode;
		}

		public Item(int barcode, string name, double price)
		{
			this.Barcode = barcode;
			this.Name = name;
			this.Price = price;
		}

		public override string ToString()
		{
			return $"{Barcode} {Name} {Price}";
		}

		public string FileSavingFormat()
		{
			return $"{Barcode}|{Name}|{Price}";
		}
	}
}
