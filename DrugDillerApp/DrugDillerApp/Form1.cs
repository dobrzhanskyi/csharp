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
        public MainForm()
        {
            InitializeComponent();           
        }

        List<Client> clients = new List<Client>();

        Client nark = new Client();
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
            /*   if (ClientDB.Contains(new Client() {ClientName= tb_CustomerName.Text }))
               {
                   MessageBox.Show("This Customer is already existing");
               }
               else
               {


               }
               */
            clients.Add(new Client() { clientName = tb_CustomerName.Text });
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
    }
}
