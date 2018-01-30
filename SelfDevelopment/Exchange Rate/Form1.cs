using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_Rate
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private String OschadBankBuy()
		{
			System.Net.WebClient webClient = new System.Net.WebClient();
			String responce = webClient.DownloadString("https://www.oschadbank.ua/ua/");
			String rate = System.Text.RegularExpressions.Regex.Match(responce, @"buy-USD"" data-buy=""([0-9]+\,[0-9]+)""").Groups[1].Value;
			return "ОщадБанк: " + rate + " грн.\r\n";
		}
		private String OschadBankSell()
		{
			System.Net.WebClient webClient = new System.Net.WebClient();
			String responce = webClient.DownloadString("https://www.oschadbank.ua/ua/");
			String rate = System.Text.RegularExpressions.Regex.Match(responce, @"sell-USD"" data-sell=""([0-9]+\,[0-9]+)""").Groups[1].Value;
			return "ОщадБанк: " + rate + " грн.\r\n";
			//sell-USD" data-sell="28,9200"
		}
		private void Form1_Shown(object sender, EventArgs e)
		{
			textBox1.Text = "Покупка $:\r\n" + OschadBankBuy() + "\r\nПродажа $:\r\n" + OschadBankSell();
		}
	}
}
