using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_2
{
    public partial class Form2 : Form
    {
        TextBox textBoxForm1;       //силка

        public Form2()
        {
            InitializeComponent();                 
        }
        public Form2(TextBox text)
        {
            InitializeComponent();
            this.textBoxForm1 = text;
        }

       public TextBox Str
        {
            set { textBoxForm1 = value; }
        }
        public string TEXT
        {
            set { textBox1.Text = value; }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxForm1.Text = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
