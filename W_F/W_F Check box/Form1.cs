using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W_F_Check_box
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> dict = new Dictionary<string, string>();


        public Form1()
        {
            InitializeComponent();
          
            dict.Add("pavlechko777@gmail.com", "0936639416Artyr");
            dict.Add("mrdunki2@gmail.com", "pavlechko777");         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                MessageBox.Show("Ви клікнули на 1 check box");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            MessageBox.Show("Ви клікнули на 2 check box");
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

      

        private void radioButton_P_CheckedChanged(object sender, EventArgs e)
        {
            this.Text ="Периметр: " + Convert.ToString(2 * 3.1415 * Convert.ToInt32(textBox1.Text));
        }

        private void radioButton_S_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(Convert.ToUInt32(textBox1.Text) * Convert.ToUInt32(textBox1.Text) * 3.1415);
        }

        private void button_change_color_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(Convert.ToInt32(R.Text), Convert.ToInt32(G.Text), Convert.ToInt32(B.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan tm = DateTime.Now - new DateTime(Convert.ToInt32(Year.Text), Convert.ToInt32(Month.Text), Convert.ToInt32(Days.Text));
            if(radioButton_Days.Checked)
                MessageBox.Show(tm.Days.ToString());

            if (radioButton_Hours.Checked)
                MessageBox.Show(tm.TotalHours.ToString());

            if (radioButton_Seconds.Checked)
                MessageBox.Show(tm.TotalSeconds.ToString());   
        }

        private void reset_login_Click(object sender, EventArgs e)
        {
            Login.Text = "";
            Paswords.Text = "";
        }

        private void ok_login_Click(object sender, EventArgs e)
        {
            Paswords.PasswordChar = '*';
            if (Login.Text == "")
                MessageBox.Show("Error Login");
            if (Paswords.Text == "")
                MessageBox.Show("Error pasword");

            bool log = false;
            bool pasw = false;
            bool you_in = false;
            foreach(var v in dict)
            {
                if (Login.Text == v.Key)
                    log = true;
                if (Paswords.Text == v.Value)
                    pasw = true;
                if (Login.Text == v.Key && Paswords.Text == v.Value)
                    you_in = true;
            }
            if (!log)
                MessageBox.Show("Wrong LOGIN");
            if (!pasw)
                MessageBox.Show("Wrong PASWORDS");

            MessageBox.Show(you_in ? "You in" : "Wrong");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            this.Text = dt.Date.ToString();
        }
    }
}
