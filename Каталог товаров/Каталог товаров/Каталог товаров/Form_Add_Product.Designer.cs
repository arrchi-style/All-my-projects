namespace Каталог_товаров
{
    partial class Form_Add_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_name_product = new System.Windows.Forms.Label();
            this.label_country_of_made = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label_name_product
            // 
            this.label_name_product.AutoSize = true;
            this.label_name_product.Location = new System.Drawing.Point(12, 24);
            this.label_name_product.Name = "label_name_product";
            this.label_name_product.Size = new System.Drawing.Size(42, 13);
            this.label_name_product.TabIndex = 1;
            this.label_name_product.Text = "Назва:";
            // 
            // label_country_of_made
            // 
            this.label_country_of_made.AutoSize = true;
            this.label_country_of_made.Location = new System.Drawing.Point(15, 86);
            this.label_country_of_made.Name = "label_country_of_made";
            this.label_country_of_made.Size = new System.Drawing.Size(101, 13);
            this.label_country_of_made.TabIndex = 2;
            this.label_country_of_made.Text = "Країна виробника:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(18, 170);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(57, 13);
            this.label_price.TabIndex = 5;
            this.label_price.Text = "Вартьсть:";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(21, 227);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(160, 227);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_country_of_made);
            this.Controls.Add(this.label_name_product);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Add_Product";
            this.Text = "Form_Add_Product";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_name_product;
        private System.Windows.Forms.Label label_country_of_made;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}