namespace _27._04
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tr3 = new System.Windows.Forms.TrackBar();
            this.tr2 = new System.Windows.Forms.TrackBar();
            this.tr1 = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Текст = new System.Windows.Forms.TabPage();
            this.Колір = new System.Windows.Forms.TabPage();
            this.Розмір = new System.Windows.Forms.TabPage();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Текст.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(260, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "B";
            // 
            // tr3
            // 
            this.tr3.Location = new System.Drawing.Point(70, 203);
            this.tr3.Maximum = 255;
            this.tr3.Name = "tr3";
            this.tr3.Size = new System.Drawing.Size(104, 45);
            this.tr3.TabIndex = 8;
            this.tr3.Scroll += new System.EventHandler(this.tr3_Scroll);
            // 
            // tr2
            // 
            this.tr2.Location = new System.Drawing.Point(70, 152);
            this.tr2.Maximum = 255;
            this.tr2.Name = "tr2";
            this.tr2.Size = new System.Drawing.Size(104, 45);
            this.tr2.TabIndex = 9;
            this.tr2.Scroll += new System.EventHandler(this.tr2_Scroll);
            // 
            // tr1
            // 
            this.tr1.Location = new System.Drawing.Point(70, 101);
            this.tr1.Maximum = 255;
            this.tr1.Name = "tr1";
            this.tr1.Size = new System.Drawing.Size(104, 45);
            this.tr1.TabIndex = 10;
            this.tr1.Scroll += new System.EventHandler(this.tr1_Scroll);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Текст);
            this.tabControl1.Controls.Add(this.Колір);
            this.tabControl1.Controls.Add(this.Розмір);
            this.tabControl1.Location = new System.Drawing.Point(206, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(209, 225);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Текст
            // 
            this.Текст.Controls.Add(this.label5);
            this.Текст.Controls.Add(this.label4);
            this.Текст.Controls.Add(this.radioButton2);
            this.Текст.Controls.Add(this.radioButton1);
            this.Текст.Location = new System.Drawing.Point(4, 22);
            this.Текст.Name = "Текст";
            this.Текст.Padding = new System.Windows.Forms.Padding(3);
            this.Текст.Size = new System.Drawing.Size(201, 199);
            this.Текст.TabIndex = 0;
            this.Текст.Text = "Текст";
            this.Текст.UseVisualStyleBackColor = true;
            this.Текст.Click += new System.EventHandler(this.Текст_Click);
            // 
            // Колір
            // 
            this.Колір.Location = new System.Drawing.Point(4, 22);
            this.Колір.Name = "Колір";
            this.Колір.Padding = new System.Windows.Forms.Padding(3);
            this.Колір.Size = new System.Drawing.Size(302, 274);
            this.Колір.TabIndex = 1;
            this.Колір.Text = "Колір";
            this.Колір.UseVisualStyleBackColor = true;
            // 
            // Розмір
            // 
            this.Розмір.Location = new System.Drawing.Point(4, 22);
            this.Розмір.Name = "Розмір";
            this.Розмір.Size = new System.Drawing.Size(302, 274);
            this.Розмір.TabIndex = 2;
            this.Розмір.Text = "Розмір";
            this.Розмір.UseVisualStyleBackColor = true;
            this.Розмір.Click += new System.EventHandler(this.Розмір_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tr1);
            this.Controls.Add(this.tr2);
            this.Controls.Add(this.tr3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tr1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Текст.ResumeLayout(false);
            this.Текст.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tr1;
        private System.Windows.Forms.TrackBar tr2;
        private System.Windows.Forms.TrackBar tr3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Текст;
        private System.Windows.Forms.TabPage Колір;
        private System.Windows.Forms.TabPage Розмір;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

