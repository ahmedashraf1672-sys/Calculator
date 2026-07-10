using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Form
{
    public partial class Form1 : Form
    { // varibles  
        string op = "";
        double result = 0;
        bool isop = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {// ( = )

            switch (op)
            {
                case "+" :
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-" :
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                
                case "*" : 
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                
                case "/" :
                    if (double.Parse(textBox1.Text) == 0)
                    {
                        MessageBox.Show("Error: Cannot divide by zero!");
                        textBox1.Text = "0";
                    }
                    else
                    {
                        textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    }
                    break;
                
                case "%" :
                    textBox1.Text = (result % double.Parse(textBox1.Text)).ToString();
                    break;
            } 
        }

        private void button12_Click(object sender, EventArgs e)
        {// ( AC )
            textBox1.Text = "0";
            result = 0;
            op = "";
            isop=false;

        }

        private void button1_Click(object sender, EventArgs e)
        { // (0,1,2,3,4,5,6,7,8,9,.)
            Button but = (Button)sender;
            if (textBox1.Text == "0" || isop == true)
            {
                textBox1.Clear();
            }
            if (but.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text += but.Text;
                }

            }
            else
            {
                textBox1.Text += but.Text;
            }
            isop = false;

        }

        private void button2_Click(object sender, EventArgs e)
        { // ( +,-,*,/,% )
            Button but = (Button)sender;
            op = but.Text;
            result =double.Parse(textBox1.Text);
            isop =true;

         
        }    // BY Ahmed Ashraf Tolba 42510385

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
