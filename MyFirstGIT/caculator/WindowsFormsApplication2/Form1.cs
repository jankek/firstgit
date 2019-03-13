using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// добавить операции к результату в лейбле
//
namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c;
        int count;
        bool znak = true;
        double msave;
        int operation;
        bool end;


        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.Focus();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.Focus();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text + 0;
                textBox1.Focus();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                textBox1.Text = textBox1.Text + ",";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0,";
            }
            textBox1.Focus();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true) { textBox1.ReadOnly = false; }
            if (textBox1.TextLength > 0)
            {
                cal();
                count = 1;
                label2.Text = "+";
                znak = true;
            }
            textBox1.Focus();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true) { textBox1.ReadOnly = false; }
            if (textBox1.TextLength > 0)
            {
                cal();
                count = 2;
                label2.Text = "-";
                znak = true;
            }
            textBox1.Focus();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true) { textBox1.ReadOnly = false; }
            if (textBox1.TextLength > 0)
            {
                cal();
                count = 3;
                label2.Text = "*";
                znak = true;
            }
            textBox1.Focus();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.ReadOnly == true) { textBox1.ReadOnly = false; }
            if (textBox1.TextLength > 0)
            {
                cal();
                count = 4;
                label2.Text = "/";
                znak = true;
            }
            textBox1.Focus();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label2.Text = "";
            textBox1.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ReadOnly = false;
        }


        private void button18_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            textBox1.ReadOnly = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 && label2.Text == "" && label1.Text != "")
            {
                b = double.Parse(label1.Text);
                b = Math.Sqrt(b);
                textBox1.Text = Convert.ToString(b);
                label1.Text = "";
                textBox1.ReadOnly = true;
            }else
            if (label1.Text != "")
            {
                c = double.Parse(textBox1.Text);
                c = Math.Sqrt(c);
                calculate();
                textBox1.Text = label1.Text;
                label1.Text = "";
                textBox1.ReadOnly = true;
            }
            else if (textBox1.ReadOnly == true && textBox1.TextLength > 0)
            { b = Math.Sqrt(double.Parse(textBox1.Text)); textBox1.Text = Convert.ToString(b);  }
                      
            else if (textBox1.TextLength > 0)
            {
                try
                {
                    b = double.Parse(textBox1.Text);
                    b = Math.Sqrt(b);
                    textBox1.Text = Convert.ToString(b);
                    label1.Text = "";
                    textBox1.ReadOnly = true;
                }
                catch { textBox1.Text = "Error"; }
            }

        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                calculate();
                textBox1.Text = "";
                label2.Text = "";
                end = true;
            }
            textBox1.Focus();
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    
                    if (c == 0) { b = a + double.Parse(textBox1.Text); }
                    else { b = a + c; c = 0; label2.Text = ""; }
                    textBox1.Clear();
                    label1.Text = b.ToString();
                    break;
                case 2:
                    
                    if (c == 0) { b = a - double.Parse(textBox1.Text); }
                    else { b = a - c; c = 0; label2.Text = ""; }
                    textBox1.Clear();
                    label1.Text = b.ToString();
                    break;
                case 3:
                    
                    if (c == 0) { b = a * double.Parse(textBox1.Text); }
                    else { b = a * c; c = 0; label2.Text = ""; }
                    textBox1.Clear();
                    label1.Text = b.ToString();
                    break;
                case 4:
                    
                    if (c == 0) { b = a / double.Parse(textBox1.Text); }
                    else { b = a / c; c = 0; label2.Text = ""; }
                    textBox1.Clear();
                    label1.Text = b.ToString();
                    break;
               
                default:
                    break;
            }
        }
        
        private void button25_Click(object sender, EventArgs e) 
        {
            if (textBox1.TextLength > 0 && label1.Text.Length > 0)
            {
                c = double.Parse(textBox1.Text);
                c = a / 100 * c;
                calculate();
                textBox1.Text = label1.Text;
                label1.Text = "";
                textBox1.ReadOnly = true;
            }
            else { textBox1.Clear(); label1.Text = "Error"; }
            textBox1.Focus();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 && label2.Text == "" && label1.Text != "")
            {
                c = double.Parse(label1.Text);
                textBox1.Clear();
                c = 1 / c;
                textBox1.Text = Convert.ToString(c);
                label1.Text = "";
                textBox1.ReadOnly = true;
                c = 0;
            }
            else if (textBox1.ReadOnly == true && textBox1.TextLength > 0)
            { b = 1 / double.Parse(textBox1.Text); textBox1.Text = Convert.ToString(b); }

            else if (textBox1.TextLength > 0)
            {
                c = double.Parse(textBox1.Text);
                textBox1.Clear();
                c = 1 / c;
                calculate();
                textBox1.Text = label1.Text;
                label1.Text = "";
                textBox1.ReadOnly = true;
            }
            textBox1.Focus();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            msave = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
                textBox1.Text = Convert.ToString(msave);
            else { label1.Text = Convert.ToString(msave); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
                msave = double.Parse(textBox1.Text);
            else msave = double.Parse(label1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            if (label1.Text == "")
            {
                double n;
                n = msave + double.Parse(textBox1.Text);
                msave = n;
            }
            else
            {
                double n;
                n = msave + double.Parse(label1.Text);
                msave = n;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                    e.Handled = true;
            }
            if (e.KeyChar == 43)
            {
                if (textBox1.ReadOnly == true) { textBox1.ReadOnly = false; }
                if (textBox1.TextLength == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    cal();
                    count = 1;
                    label2.Text = "+";
                    e.Handled = true;
                    znak = true;
                }
            }
            if (e.KeyChar == 45)
            {
                if(textBox1.TextLength == 0)
                {
                    e.Handled = true;
                    textBox1.Text = "-";
                    textBox1.Select(textBox1.Text.Length, 0);
                    textBox1.ScrollToCaret();
                }
                else
                {
                    cal();
                    count = 2;
                    label2.Text = "-";
                    e.Handled = true;
                    znak = true;
                }
            }
            if (e.KeyChar == 42)
            {
                if (textBox1.TextLength == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    cal();
                    count = 3;
                    label2.Text = "*";
                    e.Handled = true;
                    znak = true;
                }
            }
            if (e.KeyChar == 47)
            {
                if (textBox1.TextLength == 0)
                {
                    e.Handled = true;
                }
                else {
                    cal();
                    count = 4;
                    label2.Text = "/";
                    e.Handled = true;
                    znak = true;
                }
            }
            if (e.KeyChar == 13)
            {
                if (textBox1.TextLength == 0)
                {
                    e.Handled = true;
                }
                else {
                    calculate();
                    textBox1.Text = "";
                    label2.Text = "";
                    end = true;
                }
            }
            if (e.KeyChar  == 44)
            {
                if (textBox1.Text.Contains(","))
                {
                    e.Handled = true;
                }
                else if (textBox1.TextLength > 0)
                {
                    textBox1.Text = textBox1.Text + ",";
                    e.Handled = true;
                    textBox1.Select(textBox1.Text.Length, 0);
                    textBox1.ScrollToCaret();
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0,";
                    e.Handled = true;
                    textBox1.Select(textBox1.Text.Length, 0);
                    textBox1.ScrollToCaret();
                }
            }
            if(e.KeyChar==(char)Keys.Escape)
            {
                textBox1.Text = "";
                label1.Text = "";
                label2.Text = "";
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                int lenght = textBox1.Text.Length - 1;
                string text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < lenght; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                }
                textBox1.ReadOnly = false;
            }
        }
        private void cal()
        {
            try
            {
                if (label1.Text != "" && end == false) //в случае нескольких операций, начинается со второй
                {
                    calculate();
                    a = double.Parse(label1.Text);
                }
                else // первая операция
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    label1.Text = a.ToString();
                    end = false;
                }
            }
            catch { }
        }
        
    }
}
