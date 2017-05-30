using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuStrip2.Visible = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.redToolStripMenuItem.Checked)
                this.BackColor = Color.Red;
            else
                this.BackColor = Color.White;
        }

        private void yelowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.yelowToolStripMenuItem.Checked)
                this.BackColor = Color.Yellow;
            else
                this.BackColor = Color.White;
        }

       

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HHHHHHHHHHH");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Українська")
            {
                menuStrip2.Visible = true;
                menuStrip1.Visible = false;
                button1.Text = "English";
                this.MainMenuStrip = menuStrip2;
            }
            else
            {
                menuStrip2.Visible = false;
                menuStrip1.Visible = true;
                button1.Text = "Українська";
                this.MainMenuStrip = menuStrip1;
            }
        }

       

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
