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

namespace Calculator_W_F
{
    public partial class Form1 : Form
    {
        int num;
        string op;
        string str;
        public Form1()
        {
            InitializeComponent();
            this.Text = "MyCalc";

            Button[,] buttons = new Button[4, 4];
            int cnt = 0;
            int x = 0, y = 0;
            for (x = 0; x < 4; x++)
                for (y = 0; y < 4; y++)
                {
                    buttons[x, y] = new Button();
                    buttons[x, y].Location = new Point((x + 1) * 45, (y + 2) * 45);
                    buttons[x, y].Size = new Size(40, 40);
                    buttons[x, y].Name = "Button" + cnt;
                    cnt++;
                    // buttons[x, y].MouseEnter += Form1_MouseEnter;
                    // buttons[x, y].MouseLeave += Form1_MouseLeave;
                    buttons[x, y].MouseClick += Form1_MouseClick;

                    this.Controls.Add(buttons[x, y]);
                }

            buttons[0, 0].Text = "7";
            buttons[1, 0].Text = "8";
            buttons[2, 0].Text = "9";
            buttons[3, 0].Text = "+";

            buttons[0, 1].Text = "4";
            buttons[1, 1].Text = "5";
            buttons[2, 1].Text = "6";
            buttons[3, 1].Text = "-";

            buttons[0, 2].Text = "1";
            buttons[1, 2].Text = "2";
            buttons[2, 2].Text = "3";
            buttons[3, 2].Text = "*";

            buttons[0, 3].Text = "0";
            buttons[1, 3].Text = "C";
            buttons[2, 3].Text = "/";
            buttons[3, 3].Text = "=";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            str = (sender as Button).Text;

            if(str == "C")
            {
                this.Text = "MyCalc";
                textBox1.Text = "";
                num = 0;
                op = "";
                goto end;
            }

            if(num != 0 & op != null)
            {
                this.Text = num.ToString() + op + str;
            }

            textBox1.Text += str;

            if (str == "+" | str == "-" |
                str == "*" | str == "/")
            {
                num = Convert.ToInt32(textBox1.Text.Substring(0, textBox1.Text.Length - 1));       //записали число і видалили останій символ
                op = str;           //записали операцію 
                this.Text = num.ToString() + op;
                textBox1.Text = "";
            }

            if (str == "=")
            {

                if (op == "+")
                {                   
                    this.Text = num.ToString() + op + textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    double res = Convert.ToDouble(num + Convert.ToInt32(textBox1.Text.Substring(0, textBox1.Text.Length - 1)));
                    textBox1.Text = Convert.ToString(res);      //видаляємо останій символ бо не конвертується в інт
                    this.Text = (res.ToString());
                }
                if (op == "-")
                {
                    this.Text = num.ToString() + op + textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    double res = Convert.ToDouble(num - Convert.ToInt32(textBox1.Text.Substring(0, textBox1.Text.Length - 1)));
                    textBox1.Text = Convert.ToString(res);      //видаляємо останій символ бо не конвертується в інт
                    this.Text = (res.ToString());
                }
                if (op == "/")
                {
                    this.Text = num.ToString() + op + textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    double res = Convert.ToDouble(num / Convert.ToDouble(textBox1.Text.Substring(0, textBox1.Text.Length - 1)));
                    textBox1.Text = Convert.ToString(res);      //видаляємо останій символ бо не конвертується в інт
                    this.Text = (res.ToString());
                }
                if (op == "*")
                {
                    this.Text = num.ToString() + op + textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    double res = Convert.ToDouble(num * Convert.ToInt32(textBox1.Text.Substring(0, textBox1.Text.Length - 1)));
                    textBox1.Text = Convert.ToString(res);      //видаляємо останій символ бо не конвертується в інт
                    this.Text = (res.ToString());
                }

                str = "";
            }
           
            end:;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.White;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Green;
        }

       
    }
}
