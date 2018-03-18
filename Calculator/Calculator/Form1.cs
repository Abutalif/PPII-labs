using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double first_num = 0, second_num = 0, res = 0, mem = 0;
        string oper = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void res_Click(object sender, EventArgs e)
        {
            if(oper == "x"|| oper=="/"|| oper == "+" || oper == "-" || oper == "x root y" || oper == "x^y")
                second_num = double.Parse(textBox1.Text);
            switch(oper)
            {
                case "x":
                    res = first_num * second_num;
                    break;
                case "/":
                    res = first_num / second_num;
                    break;
                case "+":
                    res = first_num + second_num;
                    break;
                case "-":
                    res = first_num - second_num;
                    break;
                case "x^y":
                    res = Math.Pow(first_num, second_num);
                    break;
                case "x root y":
                    res = Math.Pow(first_num, 1 / second_num);
                    break;

                case "sin x":
                    res = Math.Sin(first_num);
                    break;

                case "cos x":
                    res = Math.Cos(first_num);
                    break;

                case "tan x":
                    res = Math.Tan(first_num);
                    break;

                case "asin x":
                    res = Math.Asin(first_num);
                    break;

                case "acos x":
                    res = Math.Acos(first_num);
                    break;

                case "atan x":
                    res = Math.Atan(first_num);
                    break;

                case "log x":
                    res = Math.Log10(first_num);
                    break;

                case "10^x":
                    res = Math.Pow(10, first_num);
                    break;

                case "ln x":
                    res = Math.Log(first_num);
                    break;

                case "e^x":
                    res = Math.Pow(Math.E, first_num);
                    break;

                case "1/x":
                    res = 1 / first_num;
                    break;

                case "x^2":
                    res = first_num * first_num;
                    break;

                case "Sqrt":
                    res = Math.Sqrt(first_num);
                    break;
                default:
                    textBox1.Text = "";
                    res = second_num;
                    break;
            }
            textBox1.Text = res.ToString();

        }
        
        private void oper_Click(object sender, EventArgs e)
        {
            Button operation = sender as Button;
            first_num = double.Parse(textBox1.Text);
            oper = operation.Text;

            textBox1.Text = "0";
        }
        
        private void change_Sign(object sender, EventArgs e)
        {
            if(textBox1.Text[0]!='-')
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(0,1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool has_dot = false;
            for(int i = 0; i<textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == ',')
                    has_dot = true;
            }
            if (!has_dot)
                textBox1.Text += ',';
        }

        private void nums_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length < 20 && textBox1.Text != Math.PI.ToString())
            {
                Button btn = sender as Button;
                if (textBox1.Text[0] == '0')
                {
                    textBox1.Text = btn.Text;
                }
                else
                {

                    if (btn.Text != "Pi")
                        textBox1.Text = textBox1.Text + btn.Text;
                    else
                        textBox1.Text = Math.PI.ToString();
                }
            }
        }

        private void sys_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Text=="CE")
            {
                res = 0;
                textBox1.Text = "0";
                second_num = 0;
            }
            if(btn.Text=="C")
            {
                res = 0;
                second_num = 0;
                first_num = 0;
                oper = "";
                textBox1.Text = "0";
            }
        }
        
        private void mem_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string mem_Command = btn.Text;
            switch(mem_Command)
            {
                case "MS":
                    mem = first_num; 
                    break;
                case "MR":
                    textBox1.Text = mem.ToString();
                    break;
                case "M+:":
                    mem += double.Parse(textBox1.Text);
                    break;
                case "M-":
                    mem -= double.Parse(textBox1.Text);
                    break;
                case "MC":
                    mem = 0;
                    mem_Command = "";
                    break;
            }
        }
    }
}
