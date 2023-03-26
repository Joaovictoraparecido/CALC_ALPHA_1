using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC_ALPHA_1
{
    public partial class Form1 : Form
    {
        decimal VALOR1 = 0;
        decimal VALOR2 = 0;
        string operacao;
        decimal valormenos;
        decimal valormenos2;
        decimal valorvezes;
        decimal valorvezes2;
        decimal valordividir;
        decimal valordividir2;
        decimal valorraiz;
        decimal valorraiz2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            VALOR2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if(operacao == "SOMA")
            {
                textBox1.Text= Convert.ToString(VALOR1 + VALOR2);
            }
            valormenos2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (operacao == "menos")
            {
                textBox1.Text = Convert.ToString(valormenos - valormenos2);
            }

            valorvezes2= decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (operacao == "vezes")
            {
                textBox1.Text = Convert.ToString(valorvezes * valorvezes2);
            }
            valordividir2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (operacao == "dividir")
            {
                textBox1.Text = Convert.ToString(valordividir / valordividir2);
            }
            valorraiz2 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            if (operacao == "dividir")
            {
                textBox1.Text = Convert.ToString(valorraiz * valorraiz2);
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text +="0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            VALOR1 = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            textBox1.Text = "";
            operacao = "SOMA";
            label1.Text = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valormenos = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            textBox1.Text = "";
            operacao = "menos";
            label1.Text = "-";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            valorvezes = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            textBox1.Text = "";
            operacao = "vezes";
            label1.Text = "*";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            valordividir = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            textBox1.Text = "";
            operacao = "dividir";
            label1.Text = "/";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            valorraiz = decimal.Parse(textBox1.Text, CultureInfo.InvariantCulture);

            textBox1.Text = "";
            operacao = "RAIZ";
            label1.Text = "√";
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
