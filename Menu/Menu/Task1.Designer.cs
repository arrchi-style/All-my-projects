namespace Menu
{
    partial class Task1
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
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.button_add_p_menu = new System.Windows.Forms.Button();
            this.button_add_podmenu = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(45, 133);
            this.TopLevelMenu.Multiline = true;
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(145, 55);
            this.TopLevelMenu.TabIndex = 0;
            this.TopLevelMenu.Text = "TopLevelMenu";
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(45, 194);
            this.SubItem.Multiline = true;
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(145, 54);
            this.SubItem.TabIndex = 1;
            this.SubItem.Text = "SubItem";
            // 
            // button_add_p_menu
            // 
            this.button_add_p_menu.Location = new System.Drawing.Point(45, 275);
            this.button_add_p_menu.Name = "button_add_p_menu";
            this.button_add_p_menu.Size = new System.Drawing.Size(75, 43);
            this.button_add_p_menu.TabIndex = 2;
            this.button_add_p_menu.Text = "Добавить пункт меню";
            this.button_add_p_menu.UseVisualStyleBackColor = true;
            // 
            // button_add_podmenu
            // 
            this.button_add_podmenu.Location = new System.Drawing.Point(138, 275);
            this.button_add_podmenu.Name = "button_add_podmenu";
            this.button_add_podmenu.Size = new System.Drawing.Size(75, 43);
            this.button_add_podmenu.TabIndex = 3;
            this.button_add_podmenu.Text = "Добавить подменю";
            this.button_add_podmenu.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 43);
            this.listBox1.TabIndex = 4;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 392);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_add_podmenu);
            this.Controls.Add(this.button_add_p_menu);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Name = "Task1";
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private System.Windows.Forms.Button button_add_p_menu;
        private System.Windows.Forms.Button button_add_podmenu;
        private System.Windows.Forms.ListBox listBox1;
    }
}