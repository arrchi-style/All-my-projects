using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }

        public string Str
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
