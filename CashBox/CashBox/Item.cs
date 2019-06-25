namespace CashBox
{
	class Item
	{
		public int Balance;
		public int Barcode;
		public int Price;

		public Item(int barcode, int price,int balance)
		{
			this.Barcode = barcode;
			this.Balance = balance;
			this.Price = price;
		}
	}
}
