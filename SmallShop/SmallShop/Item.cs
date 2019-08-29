namespace SmallShop
{
	internal class Item
	{
		public string Name;
		public int Barcode;
		public double Price;

		public Item(int barcode)
		{
			Barcode = barcode;
		}

		public Item(int barcode, string name, double price)
		{
			Barcode = barcode;
			Name = name;
			Price = price;
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