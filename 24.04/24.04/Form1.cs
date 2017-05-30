﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._04
{
    public partial class Form1 : Form
    {
        double res;
        DateTime data = new DateTime();
        DateTime data1 = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            data = this.dateTimePicker1.Value;
            data1 = this.dateTimePicker2.Value;
            TimeSpan rizn = data - data1;
            this.label1.Text = rizn.TotalDays.ToString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            data = this.dateTimePicker1.Value;
            data1 = this.dateTimePicker2.Value;
            TimeSpan rizn = data - data1;
            this.label1.Text = rizn.TotalDays.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                monthCalendar1.AddBoldedDate(new DateTime(Convert.ToInt32(this.textBox_year.Text), Convert.ToInt32(this.textBox_month.Text), Convert.ToInt32(this.textBox_day.Text)));
                monthCalendar1.SelectionStart = new DateTime(Convert.ToInt32(this.textBox_year.Text), Convert.ToInt32(this.textBox_month.Text), Convert.ToInt32(this.textBox_day.Text));
                monthCalendar1.SelectionEnd = new DateTime(Convert.ToInt32(this.textBox_year.Text), Convert.ToInt32(this.textBox_month.Text), Convert.ToInt32(this.textBox_day.Text));
            }
            catch
            {
                this.textBox_year.Text = this.monthCalendar1.SelectionStart.Year.ToString();
                this.textBox_month.Text = this.monthCalendar1.SelectionStart.Month.ToString();
                this.textBox_day.Text = this.monthCalendar1.SelectionStart.Day.ToString();
                this.textBox_Weekend.Text = this.monthCalendar1.SelectionStart.DayOfWeek.ToString();
            }
                  
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.label5.Text = dateTimePicker3.Value.ToShortDateString();      
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            this.label5.Text = dateTimePicker3.Value.ToShortDateString();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label_text.Font = new Font(label_text.Font.Name, 14, FontStyle.Italic);
                checkBox1.Checked = true;
            }
            else
            {
                label_text.Font = new Font(label_text.Font.Name, 14, FontStyle.Regular);
                checkBox1.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label_text.Font = new Font(label_text.Font.Name, 14, FontStyle.Bold);
                checkBox2.Checked = true;
            }
            else
            {
                label_text.Font = new Font(label_text.Font.Name, 14, FontStyle.Regular);
                checkBox2.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label_text.Font = new Font(label_text.Font.Name, 14, FontStyle.Underline);
                checkBox3.Checked = true;
            }
            else
            {
                label_text.Font = new Font(label_text.Font.Name, 14, FontStyle.Regular);
                checkBox3.Checked = false;
            }
        }

        private void button_week_Click(object sender, EventArgs e)
        {
            this.textBox_year.Text = this.monthCalendar1.SelectionStart.Year.ToString();
            this.textBox_month.Text = this.monthCalendar1.SelectionStart.Month.ToString();
            this.textBox_day.Text = this.monthCalendar1.SelectionStart.Day.ToString();
            this.textBox_Weekend.Text = this.monthCalendar1.SelectionStart.DayOfWeek.ToString();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(this.numb1.Text);
            double n2 = Convert.ToDouble(this.num2.Text);
            if (this.operation.Text == "+")
                res = n1 + n2;
            else if (this.operation.Text == "-")
                res = n1 - n2;
            else if (this.operation.Text == "*")
                res = n1 * n2;
            else if (this.operation.Text == "/")
                res = n1 / n2;
            this.result.Text = res.ToString();
        }

        
    }
}