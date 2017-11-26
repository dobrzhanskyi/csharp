using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugDillerApp
{
    public partial class MainForm : Form
    {
        public  MainForm()
        {
            InitializeComponent();           
        }

        Dictionary <Guid,Client> clients = new Dictionary<Guid,Client>();

        //private  static string MyToString<TKey, TValue>
        //(this IDictionary<TKey, TValue> dictionary)
        //    {
        //        var items = from kvp in dictionary
        //                    select kvp.Key + "=" + kvp.Value;

        //        return "{" + string.Join(",", items) + "}";
        //    }

        Client nark = new Client();
        Client nark2 = new Client();
        Drug ganja = new Drug("Ganja", 10);
        Drug cocain = new Drug("Cocaine", 30);       

        private void rb_Ganja_CheckedChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tb_DrugQuantity.Text, out int GanjaQuantity);
            lbl_Price.Text = (GanjaQuantity * ganja.drugPrice).ToString();          
        }

        public void rb_Cocain_CheckedChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tb_DrugQuantity.Text, out int CocainQuantity);
            lbl_Price.Text = (CocainQuantity * cocain.drugPrice).ToString();
        }

        private void tb_DrugQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            tb_DrugQuantity.Text = "";
        }

        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            var client = new Client(tb_CustomerName.Text);
            clients.Add(client.guid,client);
            lw_clients.Items.Add(client.guid.ToString(), client.ToString(), 0);
        }
          
        public void btn_Sell_Click(object sender, EventArgs e)
        {
            if (rb_Cocain.Checked )
            {
                Int32.TryParse((tb_DrugQuantity.Text), out int result);
                nark.BuyDrugs(result, 0);                           
            }                                   
            else if(rb_Ganja.Checked)
            {
                Int32.TryParse((tb_DrugQuantity.Text), out int result);
                nark.BuyDrugs(0, result);
            }
            else if(tb_DrugQuantity.Text=="")
            {
                MessageBox.Show("Enter Quantity");
            }
            else 
            {
                MessageBox.Show("Choose your Drug");
            }
        }
        
        private void tb_DrugQuantity_TextChanged(object sender, EventArgs e)
        {
            bool checkInput = Int32.TryParse(tb_DrugQuantity.Text, out int result);           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = nark.guid.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = nark2.guid.ToString();
        }
    }
}
