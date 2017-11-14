namespace DrugDillerApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_NewCustomer = new System.Windows.Forms.Button();
            this.tb_CustomerName = new System.Windows.Forms.TextBox();
            this.rb_Cocain = new System.Windows.Forms.RadioButton();
            this.rb_Ganja = new System.Windows.Forms.RadioButton();
            this.tb_DrugQuantity = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Sell = new System.Windows.Forms.Button();
            this.lb_GanjPrice = new System.Windows.Forms.Label();
            this.lb_cocprice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lw_clients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_NewCustomer
            // 
            this.btn_NewCustomer.Location = new System.Drawing.Point(12, 124);
            this.btn_NewCustomer.Name = "btn_NewCustomer";
            this.btn_NewCustomer.Size = new System.Drawing.Size(145, 23);
            this.btn_NewCustomer.TabIndex = 0;
            this.btn_NewCustomer.Text = "Add new customer";
            this.btn_NewCustomer.UseVisualStyleBackColor = true;
            this.btn_NewCustomer.Click += new System.EventHandler(this.btn_NewCustomer_Click);
            // 
            // tb_CustomerName
            // 
            this.tb_CustomerName.Location = new System.Drawing.Point(12, 54);
            this.tb_CustomerName.Name = "tb_CustomerName";
            this.tb_CustomerName.Size = new System.Drawing.Size(145, 20);
            this.tb_CustomerName.TabIndex = 1;
            this.tb_CustomerName.Text = "Enter Customer Name";
            // 
            // rb_Cocain
            // 
            this.rb_Cocain.AutoSize = true;
            this.rb_Cocain.Location = new System.Drawing.Point(397, 101);
            this.rb_Cocain.Name = "rb_Cocain";
            this.rb_Cocain.Size = new System.Drawing.Size(58, 17);
            this.rb_Cocain.TabIndex = 2;
            this.rb_Cocain.TabStop = true;
            this.rb_Cocain.Text = "Cocain";
            this.rb_Cocain.UseVisualStyleBackColor = true;
            this.rb_Cocain.CheckedChanged += new System.EventHandler(this.rb_Cocain_CheckedChanged);
            // 
            // rb_Ganja
            // 
            this.rb_Ganja.AutoSize = true;
            this.rb_Ganja.Location = new System.Drawing.Point(397, 153);
            this.rb_Ganja.Name = "rb_Ganja";
            this.rb_Ganja.Size = new System.Drawing.Size(53, 17);
            this.rb_Ganja.TabIndex = 3;
            this.rb_Ganja.TabStop = true;
            this.rb_Ganja.Text = "Ganja";
            this.rb_Ganja.UseVisualStyleBackColor = true;
            this.rb_Ganja.CheckedChanged += new System.EventHandler(this.rb_Ganja_CheckedChanged);
            // 
            // tb_DrugQuantity
            // 
            this.tb_DrugQuantity.Location = new System.Drawing.Point(397, 124);
            this.tb_DrugQuantity.Name = "tb_DrugQuantity";
            this.tb_DrugQuantity.Size = new System.Drawing.Size(100, 20);
            this.tb_DrugQuantity.TabIndex = 4;
            this.tb_DrugQuantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_DrugQuantity_MouseClick);
            this.tb_DrugQuantity.TextChanged += new System.EventHandler(this.tb_DrugQuantity_TextChanged);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(509, 101);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(31, 13);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Sell
            // 
            this.btn_Sell.Location = new System.Drawing.Point(503, 124);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(75, 43);
            this.btn_Sell.TabIndex = 6;
            this.btn_Sell.Text = "Sell";
            this.btn_Sell.UseVisualStyleBackColor = true;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // lb_GanjPrice
            // 
            this.lb_GanjPrice.AutoSize = true;
            this.lb_GanjPrice.Location = new System.Drawing.Point(456, 155);
            this.lb_GanjPrice.Name = "lb_GanjPrice";
            this.lb_GanjPrice.Size = new System.Drawing.Size(25, 13);
            this.lb_GanjPrice.TabIndex = 7;
            this.lb_GanjPrice.Text = "10$";
            // 
            // lb_cocprice
            // 
            this.lb_cocprice.AutoSize = true;
            this.lb_cocprice.Location = new System.Drawing.Point(456, 101);
            this.lb_cocprice.Name = "lb_cocprice";
            this.lb_cocprice.Size = new System.Drawing.Size(25, 13);
            this.lb_cocprice.TabIndex = 8;
            this.lb_cocprice.Text = "30$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lw_clients
            // 
            this.lw_clients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lw_clients.Location = new System.Drawing.Point(18, 160);
            this.lw_clients.Name = "lw_clients";
            this.lw_clients.Size = new System.Drawing.Size(138, 122);
            this.lw_clients.TabIndex = 11;
            this.lw_clients.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 416);
            this.Controls.Add(this.lw_clients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_cocprice);
            this.Controls.Add(this.lb_GanjPrice);
            this.Controls.Add(this.btn_Sell);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.tb_DrugQuantity);
            this.Controls.Add(this.rb_Ganja);
            this.Controls.Add(this.rb_Cocain);
            this.Controls.Add(this.tb_CustomerName);
            this.Controls.Add(this.btn_NewCustomer);
            this.Name = "MainForm";
            this.Text = "DrugDillerApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewCustomer;
        private System.Windows.Forms.TextBox tb_CustomerName;
        private System.Windows.Forms.RadioButton rb_Cocain;
        private System.Windows.Forms.RadioButton rb_Ganja;
        private System.Windows.Forms.TextBox tb_DrugQuantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Sell;
        private System.Windows.Forms.Label lb_GanjPrice;
        private System.Windows.Forms.Label lb_cocprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lw_clients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

