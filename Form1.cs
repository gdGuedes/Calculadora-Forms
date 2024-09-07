using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
               
        public Form1()
        {
            InitializeComponent();
        }
        int operador;
        float nm1, valorg;

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int p =
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                nm1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                operador = 2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
                nm1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                operador = 3;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
                nm1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                operador = 4;
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacoes(operador);
        }
        public void operacoes (int operador)
        {
            switch (operador)
            {
                case 1:
                    valorg = nm1 + float.Parse(textBox1.Text);
                    textBox1.Text = valorg.ToString();
                    break;
                case 2:
                    valorg = nm1 - float.Parse(textBox1.Text);
                    textBox1.Text = valorg.ToString();
                    break;
                case 3:
                    valorg = nm1 * float.Parse(textBox1.Text);
                    textBox1.Text = valorg.ToString();
                    break;
                case 4:
                    valorg = nm1 / float.Parse(textBox1.Text);
                    textBox1.Text = valorg.ToString();
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nm1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            operador = 1;
        }
    }
}
