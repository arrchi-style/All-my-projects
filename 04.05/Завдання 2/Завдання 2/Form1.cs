using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_2
{
    public partial class Form1 : Form
    {
        Form2 form2;       //силка
        string file_name;

        public Form1()
        {
            form2 = new Form2(this.textBox1);
            InitializeComponent();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";



            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                file_name = openFileDialog1.FileName;

                textBox1.Text = reader.ReadToEnd();

                button2.Enabled = true;
                reader.Close();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                form2.Str = this.textBox1;
                form2.TEXT = textBox1.Text;
                form2.Show();
            }
            catch
            {
                form2.Str = this.textBox1;
                form2.TEXT = textBox1.Text;
                form2 = new Form2(this.textBox1);
                form2.Show();
            }

        }



        public string Str
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (DialogResult.No != MessageBox.Show("Зберегти", "Save", MessageBoxButtons.YesNo))
            {
                try
                {

                    StreamWriter writer = new StreamWriter(file_name);
                    writer.WriteLine(textBox1.Text);
                    writer.Close();
                }

                catch
                {
                    MessageBox.Show("Ви не вибрали файл для редагування");
                }
            }

        }
    }
}
