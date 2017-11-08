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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tb_CustomerName.TextChanged += new System.EventHandler(this.tb_CustomerName_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "10$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "30$";
            
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

