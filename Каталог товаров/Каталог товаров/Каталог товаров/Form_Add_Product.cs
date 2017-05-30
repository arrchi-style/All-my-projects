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
    public partial class Form_Add_Product : Form
    {
        Product product = new Product();

        public Form_Add_Product()
        {
            InitializeComponent();
            this.Text = "Додавання товару";
        }

        public Form_Add_Product(string str)
        {
            InitializeComponent();
            this.Text = str;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "")
            {
                MessageBox.Show("Не всі поля заповненні");
            }
            else
            {
                product.Name = textBox1.Text;
                product.Country_of_made = textBox2.Text;
                product.Price = textBox3.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        public Product return_Product
        {
            get { return product; }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }


}
