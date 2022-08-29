using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication7
{
    

    public partial class Form1 : Form
    {
        private void Form1_DoubleClick(object sender, EventArgs e)
        {

            SendKeys.Send("{ENTER}");

        }




        public Form1()
        {
            InitializeComponent();
        }



        int count;
        double ans, num1;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "7";
            }

            else
            { textBox1.Text += "7"; }
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            compute(count);

        }



        public void button0_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "0";
            }

            else
            { textBox1.Text += "0"; }

        }

        public void buttonMultiply_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "1";
            }

            else
            { textBox1.Text += "1"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "2";
            }

            else
            { textBox1.Text += "2"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {




            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "3";
            }

            else
            { textBox1.Text += "3"; }

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "4";
            }

            else
            { textBox1.Text += "4"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "5";
            }

            else
            { textBox1.Text += "5"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "6";
            }

            else
            { textBox1.Text += "6"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "8";
            }

            else
            { textBox1.Text += "8"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += "9";
            }

            else
            { textBox1.Text += "9"; }
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && textBox1.TextLength > 0)
            {
                num1 = 0; textBox1.Clear();
            }
            else if (num1 > 0 && textBox1.TextLength > 0)
            {
                textBox1.Clear();
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 5;
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == Keys.Multiply))
            {

                num1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;


            }
            else if ((e.KeyCode == Keys.Divide))
            {

               
                num1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 2;

            }
           
            else if (e.KeyCode == Keys.Add)
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 3;
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 4;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                compute(count);
            }
            else if ((e.KeyCode == Keys.NumPad0) || (e.KeyCode == Keys.NumPad1) || (e.KeyCode == Keys.NumPad2) || (e.KeyCode == Keys.NumPad3) || (e.KeyCode == Keys.NumPad4) || (e.KeyCode == Keys.NumPad5) || (e.KeyCode == Keys.NumPad6) || (e.KeyCode == Keys.NumPad7) || (e.KeyCode == Keys.NumPad8) || (e.KeyCode == Keys.NumPad9))
            {
                {
                    if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
                    {
                        int lenght = textBox1.TextLength - 1;
                        string text = textBox1.Text;
                        textBox1.Clear();
                        for (int i = 0; i < lenght; i++)
                        { textBox1.Text = textBox1.Text + text[i]; }

                    }

                    else
                    {
                    }


                }
            
           

            }
         
        }
    

        private void backspace_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
                textBox1.Text = textBox1.Text + text[i];
        }

        private void buttondecimal_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "*") || (textBox1.Text == "+") || (textBox1.Text == "/") || (textBox1.Text == "x") || (textBox1.Text == "-"))
            {
                int lenght = textBox1.TextLength - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                { textBox1.Text = textBox1.Text + text[i]; }
                textBox1.Text += ".";
            }

            else
            { textBox1.Text += "."; }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            textBox1.Text= Math.Tan(Convert.ToDouble(num1)).ToString()+" Radians";
          




        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {


            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

            textBox1.Text = (Math.Sin(Convert.ToDouble(num1))).ToString()+" Radians";
        }

        private void button12_Click(object sender, EventArgs e)
        {

            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

            textBox1.Text = (Math.Cos(Convert.ToDouble(num1))).ToString()+" Radians";
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {
        
        }

    
        public double funcofx (double x)
        {
            string xyz = textBox1.Text;
            double abc = double.Parse(xyz);
            return abc;
        }
        public void button13_Click(object sender, EventArgs e)
        {
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void graphingCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            Double num01 = Convert.ToDouble(num1);
            Double num02 = num01 * (180 / Math.PI);
            textBox1.Text = num02.ToString() + " degrees";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            Double num01 = Convert.ToDouble(num1);
            Double num02 = num01 * (Math.PI/180);
            textBox1.Text = num02.ToString() + " degrees";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //F to C
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            Double F = Convert.ToDouble(num1);
            Double C = (F-32) * (5 / 9);
            textBox1.Text = C.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //C to F
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            Double C = Convert.ToDouble(num1);
            Double F = (C * (9 / 5)) + 32;
            textBox1.Text = F.ToString();
        }

        public void compute(int count)
        {
            switch (count)
            {

                case 1:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    if (textBox1.Text == "0")
                    {
                        textBox1.Text = "Divide by Zero Error";
                    }
                    else
                    {
                        ans = num1 / float.Parse(textBox1.Text);
                        textBox1.Text = ans.ToString();
                    }
                    break;
                case 3:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
               
                default:
                    break;
            }
         
           
        }


    }
}