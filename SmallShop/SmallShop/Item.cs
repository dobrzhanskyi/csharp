namespace SmallShop
{
	class Item
	{
		public string Name;
		public int Barcode;
		public double Price;

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
