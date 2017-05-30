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

namespace Search
{
    public partial class Form1 : Form
    {
        int cnt_of_files = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cnt_of_files = 0;

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                string sourceDirectory = folderBrowserDialog1.SelectedPath;

                if (comboBox1.Text == ".txt")
                {
                    var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");
                    foreach (string currentFile in txtFiles)
                    {
                        listBox1.Items.Add(currentFile.ToString());
                        cnt_of_files++;
                    }
                    MessageBox.Show("Нараховано " + cnt_of_files.ToString() + " txt файлів");
                }

                if (comboBox1.Text == ".docx")
                {
                    var docxFiles = Directory.EnumerateFiles(sourceDirectory, "*.docx");
                    foreach (string currentFile in docxFiles)
                    {
                        listBox1.Items.Add(currentFile.ToString());
                        cnt_of_files++;
                    }
                    MessageBox.Show("Нараховано " + cnt_of_files.ToString() + " docx файлів");
                }

                if (comboBox1.Text == ".html")
                {
                    var htmlFiles = Directory.EnumerateFiles(sourceDirectory, "*.html");
                    foreach (string currentFile in htmlFiles)
                    {
                        listBox1.Items.Add(currentFile.ToString());
                        cnt_of_files++;
                    }
                    MessageBox.Show("Нараховано " + cnt_of_files.ToString() + " html файлів");
                }
                if (comboBox1.Text == ".xml")
                {
                    var xmlFiles = Directory.EnumerateFiles(sourceDirectory, "*.xml");
                    foreach (string currentFile in xmlFiles)
                    {
                        listBox1.Items.Add(currentFile.ToString());
                        cnt_of_files++;
                    }
                    MessageBox.Show("Нараховано " + cnt_of_files.ToString() + " xml файлів");
                }
                if (comboBox1.Text == ".exe")
                {
                    var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.exe");
                    foreach (string currentFile in txtFiles)
                    {
                        listBox1.Items.Add(currentFile.ToString());
                        cnt_of_files++;
                    }
                    MessageBox.Show("Нараховано " + cnt_of_files.ToString() + " exe файлів"); ;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (DialogResult.No != MessageBox.Show("Зберегти результати?", "Save", MessageBoxButtons.YesNo))
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.ShowDialog();

                    StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                    foreach (var v in listBox1.Items)
                    {
                        writer.WriteLine(v);
                    }
                    writer.WriteLine("Нараховано " + cnt_of_files + " файлів");
                    writer.Close();
                }
            }
            else
            {
                MessageBox.Show("Список пустий");
            }

        }
    }
}
