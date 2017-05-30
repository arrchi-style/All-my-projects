using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Каталог_товаров
{
    public partial class Form1 : Form
    {
        Form_Add_Product add_pr;
        List<Product> product = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Каталог товаров";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            add_pr = new Form_Add_Product();
            if (add_pr.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(add_pr.return_Product.ToString());
                product.Add(add_pr.return_Product);
            }

        }

        private void button_change_product_Click(object sender, EventArgs e)
        {
            add_pr = new Form_Add_Product("Редагування товару");
            try
            {
                this.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Ви не вибрали який товар редагувати");
                goto end;
            }
            //----------------------------------------------перевірка чи вибрали товар для редагування
            try
            {
                foreach (string item in listBox1.Items)
                {
                    string removelistitem = listBox1.SelectedItem.ToString();
                    if (item.Contains(removelistitem))
                    {
                        listBox1.Items.Remove(item);
                        product.RemoveAt(listBox1.SelectedIndex);
                    }
                }
            }
            catch
            {
                if (add_pr.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(add_pr.return_Product.ToString());
                }
            }
            end:;
        }

        private void button_delete_product_Click(object sender, EventArgs e)
        {
            add_pr = new Form_Add_Product("Редагування товару");
            try
            {
                this.Text = listBox1.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Ви не вибрали який товар видаляти");
                goto end;
            }
            //---------------------------------------------------------
            try
            {
                foreach (string item in listBox1.Items)
                {
                    string removelistitem = listBox1.SelectedItem.ToString();
                    if (item.Contains(removelistitem))
                    {
                        listBox1.Items.Remove(item);                //видалення елементу з ліст боксу
                        product.RemoveAt(listBox1.SelectedIndex);   //видалення елементу з колекції
                    }
                }
            }
            catch
            {
                MessageBox.Show("Товар видалено");
            }
            end:;
        }

        private void button_clear_list_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            product.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Зберегти?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach(var v in product)
                {
                    v.XML(Environment.CurrentDirectory);
                }
                MessageBox.Show(Environment.CurrentDirectory);
                Application.Exit();
            }
            
        }
    } 
}
