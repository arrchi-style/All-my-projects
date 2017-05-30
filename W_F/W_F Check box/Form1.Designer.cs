namespace W_F_Check_box
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.radioButton_Days = new System.Windows.Forms.RadioButton();
            this.radioButton_Hours = new System.Windows.Forms.RadioButton();
            this.radioButton_Seconds = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton_P = new System.Windows.Forms.RadioButton();
            this.radioButton_S = new System.Windows.Forms.RadioButton();
            this.R = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.button_change_color = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Paswords = new System.Windows.Forms.TextBox();
            this.ok_login = new System.Windows.Forms.Button();
            this.reset_login = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 181);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 204);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // radioButton_Days
            // 
            this.radioButton_Days.AutoSize = true;
            this.radioButton_Days.Location = new System.Drawing.Point(12, 14);
            this.radioButton_Days.Name = "radioButton_Days";
            this.radioButton_Days.Size = new System.Drawing.Size(49, 17);
            this.radioButton_Days.TabIndex = 2;
            this.radioButton_Days.TabStop = true;
            this.radioButton_Days.Text = "Days";
            this.radioButton_Days.UseVisualStyleBackColor = true;
            // 
            // radioButton_Hours
            // 
            this.radioButton_Hours.AutoSize = true;
            this.radioButton_Hours.Location = new System.Drawing.Point(12, 37);
            this.radioButton_Hours.Name = "radioButton_Hours";
            this.radioButton_Hours.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Hours.TabIndex = 3;
            this.radioButton_Hours.TabStop = true;
            this.radioButton_Hours.Text = "Hours";
            this.radioButton_Hours.UseVisualStyleBackColor = true;
            // 
            // radioButton_Seconds
            // 
            this.radioButton_Seconds.AutoSize = true;
            this.radioButton_Seconds.Location = new System.Drawing.Point(12, 61);
            this.radioButton_Seconds.Name = "radioButton_Seconds";
            this.radioButton_Seconds.Size = new System.Drawing.Size(67, 17);
            this.radioButton_Seconds.TabIndex = 4;
            this.radioButton_Seconds.TabStop = true;
            this.radioButton_Seconds.Text = "Seconds";
            this.radioButton_Seconds.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Days);
            this.panel1.Controls.Add(this.radioButton_Seconds);
            this.panel1.Controls.Add(this.radioButton_Hours);
            this.panel1.Location = new System.Drawing.Point(103, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 92);
            this.panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton_P
            // 
            this.radioButton_P.AutoSize = true;
            this.radioButton_P.Location = new System.Drawing.Point(247, 28);
            this.radioButton_P.Name = "radioButton_P";
            this.radioButton_P.Size = new System.Drawing.Size(63, 17);
            this.radioButton_P.TabIndex = 8;
            this.radioButton_P.TabStop = true;
            this.radioButton_P.Text = "Perimetr";
            this.radioButton_P.UseVisualStyleBackColor = true;
            this.radioButton_P.CheckedChanged += new System.EventHandler(this.radioButton_P_CheckedChanged);
            // 
            // radioButton_S
            // 
            this.radioButton_S.AutoSize = true;
            this.radioButton_S.Location = new System.Drawing.Point(247, 42);
            this.radioButton_S.Name = "radioButton_S";
            this.radioButton_S.Size = new System.Drawing.Size(32, 17);
            this.radioButton_S.TabIndex = 9;
            this.radioButton_S.TabStop = true;
            this.radioButton_S.Text = "S";
            this.radioButton_S.UseVisualStyleBackColor = true;
            this.radioButton_S.CheckedChanged += new System.EventHandler(this.radioButton_S_CheckedChanged);
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(463, 12);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(30, 20);
            this.R.TabIndex = 10;
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(463, 49);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(30, 20);
            this.G.TabIndex = 11;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(463, 83);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(30, 20);
            this.B.TabIndex = 12;
            // 
            // button_change_color
            // 
            this.button_change_color.Location = new System.Drawing.Point(463, 119);
            this.button_change_color.Name = "button_change_color";
            this.button_change_color.Size = new System.Drawing.Size(75, 23);
            this.button_change_color.TabIndex = 13;
            this.button_change_color.Text = "COLOR";
            this.button_change_color.UseVisualStyleBackColor = true;
            this.button_change_color.Click += new System.EventHandler(this.button_change_color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "B";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(35, 23);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(40, 20);
            this.Year.TabIndex = 17;
            // 
            // Month
            // 
            this.Month.Location = new System.Drawing.Point(35, 54);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(40, 20);
            this.Month.TabIndex = 18;
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(35, 89);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(40, 20);
            this.Days.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "H_Old_are_you";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(230, 178);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 20);
            this.Login.TabIndex = 21;
            // 
            // Paswords
            // 
            this.Paswords.Location = new System.Drawing.Point(230, 218);
            this.Paswords.Name = "Paswords";
            this.Paswords.PasswordChar = '*';
            this.Paswords.Size = new System.Drawing.Size(100, 20);
            this.Paswords.TabIndex = 22;
            // 
            // ok_login
            // 
            this.ok_login.Location = new System.Drawing.Point(230, 263);
            this.ok_login.Name = "ok_login";
            this.ok_login.Size = new System.Drawing.Size(39, 23);
            this.ok_login.TabIndex = 23;
            this.ok_login.Text = "OK";
            this.ok_login.UseVisualStyleBackColor = true;
            this.ok_login.Click += new System.EventHandler(this.ok_login_Click);
            // 
            // reset_login
            // 
            this.reset_login.Location = new System.Drawing.Point(275, 263);
            this.reset_login.Name = "reset_login";
            this.reset_login.Size = new System.Drawing.Size(55, 23);
            this.reset_login.TabIndex = 24;
            this.reset_login.Text = "Reset";
            this.reset_login.UseVisualStyleBackColor = true;
            this.reset_login.Click += new System.EventHandler(this.reset_login_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(603, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pasword:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(603, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 331);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.reset_login);
            this.Controls.Add(this.ok_login);
            this.Controls.Add(this.Paswords);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_change_color);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.radioButton_S);
            this.Controls.Add(this.radioButton_P);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton_Days;
        private System.Windows.Forms.RadioButton radioButton_Hours;
        private System.Windows.Forms.RadioButton radioButton_Seconds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton_P;
        private System.Windows.Forms.RadioButton radioButton_S;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Button button_change_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Paswords;
        private System.Windows.Forms.Button ok_login;
        private System.Windows.Forms.Button reset_login;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

