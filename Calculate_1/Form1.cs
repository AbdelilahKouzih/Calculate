﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculate_1
{
    public partial class Form1 : Form
    {
       
       
        string operation;
        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

            textBox1.Text= textBox1.Text + "0";
        }

        private void btnegal_Click(object sender, EventArgs e)
        {
           
    

            if (operation == "+")
            {
                string[] chaine = textBox1.Text.Split('+');
                textBox1.Text += Environment.NewLine+"+"+ Environment.NewLine + (double.Parse(chaine[0]) + double.Parse(chaine[1])).ToString();
            }
            if (operation == "-")
            {
                string[] chaine = textBox1.Text.Split('-');
                textBox1.Text += Environment.NewLine + "-" + Environment.NewLine + (double.Parse(chaine[0]) - double.Parse(chaine[1])).ToString();

            }
            if (operation == "*")
            {
                string[] chaine = textBox1.Text.Split('×');
                textBox1.Text += Environment.NewLine + "×" + Environment.NewLine + (double.Parse(chaine[0]) * double.Parse(chaine[1])).ToString();
                
            }
            if (operation == "/")
            {
                string[] chaine = textBox1.Text.Split('/');

                if (double.Parse(chaine[0]) == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    textBox1.Text += Environment.NewLine + "÷" + Environment.NewLine +(double.Parse(chaine[0]) / double.Parse(chaine[1])).ToString();

                }
            }



        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
         
            operation = "+";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
                textBox1.Text = textBox1.Text +"2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void btnmoins_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";

              operation = "-";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
                textBox1.Text = textBox1.Text + "9";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
           
            operation = "/";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {

            textBox1.Text = textBox1.Text + "×";
           
            operation = "*";
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            textBox1.Text=string.Empty;
        }


       

        
    }
}
