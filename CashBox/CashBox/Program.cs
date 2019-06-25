using System;
using System.Collections.Generic;
using System.Linq;

namespace CashBox
{
	class Program
	{
		static void Main(string[] args)
		{
			Operations operations = new Operations();

			int[] inputNumbers = Console.ReadLine().Split(' ').//Parsing to int [] array
				Where(x => !string.IsNullOrWhiteSpace(x)).
					Select(x => int.Parse(x)).ToArray();

			int stop = 0;
			for (int i = 0; i < inputNumbers.Length; i += 3)//Creating Items with barcode,price and balance
			{
				if (inputNumbers[i] == -1)
				{
					stop += i;
					break;
				}
				else
				{
					operations.createItem(inputNumbers[i], inputNumbers[i + 1], inputNumbers[i + 2]); 
				}
			}

			int daysCount = inputNumbers[stop + 1];
			int stopStop = stop + 2;//First Index for parsing each day selling
			int sumOfDay = 0;

			for (int j = stopStop; j < inputNumbers.Length; j += 2)
			{
				if (inputNumbers[j] == -1)
				{
					j--;
				}
				else
				{
					operations.SellFromItem(inputNumbers[j], inputNumbers[j + 1]);
					for (int i = 0; i < operations.itemList.Count; i++)
					{
						sumOfDay += operations.itemList[i].Balance * operations.itemList[i].Price;
					}
				}
			}

		}
	}
}
