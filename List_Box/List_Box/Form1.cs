using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Box
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("Вже існує");
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }
            textBox1.Text = "";
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
                Text = "List is empty";
            if(listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button_find_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(textBox_find.Text))
                listBox1.SelectedItem = textBox_find.Text;
            else this.Text = "No";
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            foreach(var v in listBox1.SelectedItems)
            {
                listBox2.Items.Add(v);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
           
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach(var v in checkedListBox1.CheckedItems)
            {
                str += v.ToString() + "\n";   
            }
            

             MessageBox.Show(str); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
