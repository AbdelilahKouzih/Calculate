using System;
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
        double premierNombre;
       
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
                
                label1.Text = label1.Text + "0";
        }

        private void btnegal_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "=";
            double deusiemmeNombre;
            double Result;
            
            deusiemmeNombre = double.Parse(label1.Text);

            if (operation == "+")
            {
                Result = (premierNombre + deusiemmeNombre);
                label1.Text = Convert.ToString(Result);
                premierNombre = Result;
            }
            if (operation == "-")
            {
                Result = (premierNombre - deusiemmeNombre);
                label1.Text = Convert.ToString(Result);
                premierNombre = Result;
            }
            if (operation == "*")
            {
                Result = (premierNombre * deusiemmeNombre);
                label1.Text = Convert.ToString(Result);
                premierNombre = Result;
            }
            if (operation == "/")
            {
                if (deusiemmeNombre == 0)
                {
                    label1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (premierNombre / deusiemmeNombre);
                    label1.Text = Convert.ToString(Result);
                    premierNombre = Result;
                }
            }



        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "+";
            premierNombre = double.Parse(label1.Text);
            label1.Text = "0";
            operation = "+";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "1";
            }
            else
                label1.Text = label1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "2";
            }
            else
                label1.Text = label1.Text +"2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "3";
            }
            else
                label1.Text = label1.Text + "3";
        }

        private void btnmoins_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "-";
            premierNombre = double.Parse(label1.Text);
            label1.Text = "0";
            operation = "-";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "4";
            }
            else
                label1.Text = label1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "5";
            }
            else
                label1.Text = label1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "6";
            }
            else
                label1.Text = label1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "7";
            }
            else
                label1.Text = label1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "8";
            }
            else
                label1.Text = label1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0" && label1.Text != null)
            {
                label1.Text = "9";
            }
            else
                label1.Text = label1.Text + "9";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "/";
            premierNombre = double.Parse(label1.Text);
            label1.Text = "0";
            operation = "/";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            
            label1.Text = label1.Text + "×";
            premierNombre = double.Parse(label1.Text);
            label1.Text = "0";
            operation = "*";
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
            label1.Text=string.Empty;
        }


       private void nequal_Click(object sender, EventArgs e)  
        {  
           
        }  
  
               

        
    }
}
