namespace Каталог_товаров
{
    partial class Form1
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
            this.button_add = new System.Windows.Forms.Button();
            this.button_change_product = new System.Windows.Forms.Button();
            this.button_delete_product = new System.Windows.Forms.Button();
            this.button_clear_list = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 156);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(274, 23);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Додати товар";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_change_product
            // 
            this.button_change_product.Location = new System.Drawing.Point(12, 186);
            this.button_change_product.Name = "button_change_product";
            this.button_change_product.Size = new System.Drawing.Size(274, 23);
            this.button_change_product.TabIndex = 1;
            this.button_change_product.Text = "Редагувати товар";
            this.button_change_product.UseVisualStyleBackColor = true;
            this.button_change_product.Click += new System.EventHandler(this.button_change_product_Click);
            // 
            // button_delete_product
            // 
            this.button_delete_product.Location = new System.Drawing.Point(12, 215);
            this.button_delete_product.Name = "button_delete_product";
            this.button_delete_product.Size = new System.Drawing.Size(274, 23);
            this.button_delete_product.TabIndex = 2;
            this.button_delete_product.Text = "Видалити товар";
            this.button_delete_product.UseVisualStyleBackColor = true;
            this.button_delete_product.Click += new System.EventHandler(this.button_delete_product_Click);
            // 
            // button_clear_list
            // 
            this.button_clear_list.Location = new System.Drawing.Point(13, 245);
            this.button_clear_list.Name = "button_clear_list";
            this.button_clear_list.Size = new System.Drawing.Size(273, 23);
            this.button_clear_list.TabIndex = 3;
            this.button_clear_list.Text = "Очистити список";
            this.button_clear_list.UseVisualStyleBackColor = true;
            this.button_clear_list.Click += new System.EventHandler(this.button_clear_list_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 95);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 282);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_clear_list);
            this.Controls.Add(this.button_delete_product);
            this.Controls.Add(this.button_change_product);
            this.Controls.Add(this.button_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_change_product;
        private System.Windows.Forms.Button button_delete_product;
        private System.Windows.Forms.Button button_clear_list;
        private System.Windows.Forms.ListBox listBox1;
    }
}

