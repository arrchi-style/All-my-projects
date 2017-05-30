using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int v = 0; v <= 10; v++)
            {
                Thread.Sleep(200);
                progressBar1.PerformStep();    
            }
            Application.Exit();
        }

        private void tr1_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(tr1.Value, tr2.Value, tr3.Value);
        }

        private void tr2_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(tr1.Value, tr2.Value, tr3.Value);
        }

        private void tr3_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(tr1.Value, tr2.Value, tr3.Value);
        }

        private void Текст_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["Текст"])//your specific tabname
            {
                label4.Text = "artyr";
            }
        }

        private void Розмір_Click(object sender, EventArgs e)
        {

        }
    }
}
