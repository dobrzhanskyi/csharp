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

        bool gan = false;
        bool coc = false;

        Dictionary <Guid,Client> clients = new Dictionary<Guid,Client>();
        Drug ganja = new Drug("Ganja", 10);
        Drug cocain = new Drug("Cocaine", 30);       
        
        private void rb_Ganja_CheckedChanged(object sender, EventArgs e)
        {
            gan = true;
            Int32.TryParse(tb_DrugQuantity.Text, out int GanjaQuantity);
            lbl_Price.Text = (GanjaQuantity * ganja.drugPrice).ToString();          
        }
       
        public void rb_Cocain_CheckedChanged(object sender, EventArgs e)
        {
            coc = true;
            Int32.TryParse(tb_DrugQuantity.Text, out int CocainQuantity);
            lbl_Price.Text = (CocainQuantity * cocain.drugPrice).ToString();
        }

        private void tb_DrugQuantity_MouseClick(object sender, MouseEventArgs e)
        {
            tb_DrugQuantity.Text = "";
        }
        
        public void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            Client client = new Client(tb_CustomerName.Text);
            clients.Add(client.guid,client);                            
            lw_clients.Items.Add(client.guid.ToString(), client.ToString(), 0);
            lw_clients.Tag = client.ToString();
        }
          
        public void btn_Sell_Click(object sender, EventArgs e)
        {          
            if (rb_Cocain.Checked )
            {
                Int32.TryParse((tb_DrugQuantity.Text), out int result);                                         
            }                                   
            else if(rb_Ganja.Checked)
            {
                Int32.TryParse((tb_DrugQuantity.Text), out int result);               
            }
            else if(tb_DrugQuantity.Text=="")
            {
                MessageBox.Show("Enter Quantity");
            }
            else 
            {
                MessageBox.Show("Choose your Drug");
            }
            
            MessageBox.Show(lw_clients.Tag.ToString());


            Client client = new Client();
            if (rb_Cocain.Enabled)
                client.quantityOfCocain += Int32.Parse(tb_DrugQuantity.Text.ToString());
            else if (rb_Ganja.Enabled)
                client.quantityOfGanja += Int32.Parse(tb_DrugQuantity.Text.ToString());

            client.quantityOfMoney -= Int32.Parse(lbl_Price.Text.ToString());
            if (client.quantityOfMoney <Int32.Parse(lbl_Price.Text.ToString()))
            {
                MessageBox.Show("You don't have money");
            }
            else
            {
                MessageBox.Show(client.quantityOfMoney.ToString());
            }
        }
        
        private void tb_DrugQuantity_TextChanged(object sender, EventArgs e)
        {
            bool checkInput = Int32.TryParse(tb_DrugQuantity.Text, out int result);           
        }

        private void Sell()
        {
            if (coc|gan)
            {
                btn_Sell.Enabled = true;
            }   
            else if (tb_DrugQuantity.Text != "")
                btn_Sell.Enabled = true;
            else
                btn_Sell.Enabled = false;
        }

        private void lw_clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sell();           
        }
        
    }
}
