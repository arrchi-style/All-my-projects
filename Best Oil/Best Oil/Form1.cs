﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Best_Oil
{
    public partial class Form1 : Form
    {
        OIL_Station station = new OIL_Station();
        Shop shop = new Shop();

        static double all = 0;

        static double cnt;
        public Form1()
        {
            InitializeComponent();
            comboBox_OIL.SelectedIndex = 0;
            this.Text = "BestOIL";
            textBox_grn.Enabled = false;

            textBox1.Enabled = false;
            textBox1.Text = shop.Gamburger.ToString();

            textBox2.Enabled = false;
            textBox2.Text = shop.Potatoe.ToString();

            textBox3.Enabled = false;
            textBox3.Text = shop.Coca_cola.ToString();

            textBox4.Enabled = false;
            textBox4.Text = shop.Hot_Dog.ToString();

            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = comboBox_OIL.Text;
            if (comboBox_OIL.Text == "A-95+")
            {
                label_oil_price.Text = station.A_95_PLUS.ToString();
            }
            if (comboBox_OIL.Text == "A-95")
            {
                label_oil_price.Text = station.A_95.ToString();
            }
            if (comboBox_OIL.Text == "Diseal")
            {
                label_oil_price.Text = station.Diseal.ToString();
            }
            if (comboBox_OIL.Text == "Gas")
            {
                label_oil_price.Text = station.Gas.ToString();
            }

        }

        private void textBox_liters_TextChanged(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Text = "До оплати:";
                label6.Text = "грн.";

                double litres = Convert.ToDouble(textBox_liters.Text);

                if (comboBox_OIL.Text == "A-95+")
                {
                    label_Price.Text = Convert.ToString(litres * station.A_95_PLUS);
                }
                if (comboBox_OIL.Text == "A-95")
                {
                    label_Price.Text = Convert.ToString(litres * station.A_95);
                }
                if (comboBox_OIL.Text == "Diseal")
                {
                    label_Price.Text = Convert.ToString(litres * station.Diseal);
                }
                if (comboBox_OIL.Text == "Gas")
                {
                    label_Price.Text = Convert.ToString(litres * station.Gas);
                }
            }

            catch
            {
                label_Price.Text = "0";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Text = "Літрів:";
                label6.Text = "л.";

                double grn = Convert.ToDouble(textBox_grn.Text);

                if (comboBox_OIL.Text == "A-95+")
                {
                    label_Price.Text = Convert.ToString(grn / station.A_95_PLUS);
                }
                if (comboBox_OIL.Text == "A-95")
                {
                    label_Price.Text = Convert.ToString(grn / station.A_95);
                }
                if (comboBox_OIL.Text == "Diseal")
                {
                    label_Price.Text = Convert.ToString(grn / station.Diseal);
                }
                if (comboBox_OIL.Text == "Gas")
                {
                    label_Price.Text = Convert.ToString(grn / station.Gas);
                }
            }

            catch
            {
                label_Price.Text = "0";
            }

        }

        private void radioButton_liters_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_liters.Checked == false)
            {
                textBox_liters.Enabled = false;
                textBox_grn.Enabled = true;

                groupBox2.Text = "";
                label6.Text = "";
                label_Price.Text = "";
            }
        }

        private void radioButton_price_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_price.Checked == false)
            {
                textBox_grn.Enabled = false;
                textBox_liters.Enabled = true;

                groupBox2.Text = "";
                label6.Text = "";
                label_Price.Text = "";
            }
        }
        //---------------------------------------------------------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                all += Convert.ToDouble(textBox5.Text) * shop.Gamburger;
                shop.Gamburger_price = Convert.ToDouble(textBox5.Text) * shop.Gamburger;
                label7.Text = all.ToString();
            }
            catch
            {
                all -= shop.Gamburger_price;
                label7.Text = all.ToString();
            }
           

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox6.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "";
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                all += Convert.ToDouble(textBox6.Text) * shop.Potatoe;
                shop.Potatoe_price = Convert.ToDouble(textBox6.Text) * shop.Potatoe;
                label7.Text = all.ToString();
            }
            catch
            {
                all -= shop.Potatoe_price;
                label7.Text = all.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox7.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                all += Convert.ToDouble(textBox7.Text) * shop.Coca_cola;
                shop.Coca_cola_price = Convert.ToDouble(textBox7.Text) * shop.Coca_cola;
                label7.Text = all.ToString();
            }
            catch
            {
                all -= shop.Coca_cola_price;
                label7.Text = all.ToString();
            }
        }

        private void checkBox_4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_4.Checked)
            {
                textBox8.Enabled = true;
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                all += Convert.ToDouble(textBox8.Text) * shop.Hot_Dog;
                shop.Hot_Dog_price = Convert.ToDouble(textBox8.Text) * shop.Hot_Dog;
                label7.Text = all.ToString();
            }
            catch
            {
                all -= shop.Hot_Dog_price;
                label7.Text = all.ToString();
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox5.Text == "" & textBox6.Text == "" &
                         textBox7.Text == "" & textBox8.Text == "")
            { label7.Text = ""; }
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if(label_Price.Text == "")
            {
                 label9.Text = label7.Text;
            }
            if(label7.Text == "")
            {
                label9.Text = label_Price.Text;
            }
            else
            {
                label9.Text = Convert.ToString(Convert.ToDouble(label_Price.Text) + Convert.ToDouble(label7.Text));
            }
            
        }
    }

    class OIL_Station
    {
        public double A_95_PLUS { set; get; }
        public double A_95 { set; get; }
        public double Diseal { set; get; }
        public double Gas { set; get; }

        public OIL_Station(double A_95_plus = 27.50, double A_95 = 26.50, double Diseal = 26, double Gas = 12.70)
        {
            this.A_95_PLUS = A_95_plus;
            this.A_95 = A_95;
            this.Diseal = Diseal;
            this.Gas = Gas;
        }

    }

    class Shop
    {
        public double Hot_Dog { set; get; }
        public double Gamburger { set; get; }
        public double Potatoe { set; get; }
        public double Coca_cola { set; get; }

        public double Hot_Dog_price { set; get; }
        public double Gamburger_price { set; get; }
        public double Potatoe_price { set; get; }
        public double Coca_cola_price { set; get; }



        public Shop(double Gamburger = 5.40, double Potatoe = 7.20, double Coca_Cola = 4.40, double Hot_dog = 4.0)
        {
            this.Hot_Dog = Hot_dog;
            this.Gamburger = Gamburger;
            this.Potatoe = Potatoe;
            this.Coca_cola = Coca_Cola;
        }
    }
}
