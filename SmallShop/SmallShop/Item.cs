using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
	class Item : IEquatable<Item>
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

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			Item objAsItem = obj as Item;
			if (objAsItem == null) return false;
			else return Equals(objAsItem);
		}
		public override int GetHashCode()
		{
			return Barcode;
		}
		public bool Equals(Item other)
		{
			if (other == null) return false;
			return (this.Barcode.Equals(other.Barcode));
		}
	}
}
