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
        string opreator = "";
        double value = 0;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
              
                textBox1.Clear();

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
           
            else
            {
                
                textBox1.Text = textBox1.Text + button.Text;
               
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        //function for opreators
        private void opreator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           
            
                opreator = button.Text;
                value = double.Parse(textBox1.Text);
                currentopreator.Text = value + " " + opreator;
                textBox1.Text = "";
                
            
        }

        //the function for equalopretor=
        private void button18_click(object sender, EventArgs e)
        {

            if (opreator == "+")
            {
                double sum = value + double.Parse(textBox1.Text);
                textBox1.Text = sum.ToString();

            }

            else if (opreator == "-")
            {
                double sum = value - double.Parse(textBox1.Text);
                textBox1.Text = sum.ToString();

            }
            else if (opreator == "*")
            {
               
                textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
            }
            else if (opreator == "/")
            {
                double sum = value / double.Parse(textBox1.Text);
                textBox1.Text = sum.ToString();
            }
        }

        private void clear_click(object sender, EventArgs e)
        {

            if (textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
        }

        private void clear2_click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = "0";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void currentopreator_Click(object sender, EventArgs e)
        {

        }
    }
}
