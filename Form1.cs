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

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text!="")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "÷";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "2";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "4";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "7";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "9";
        }

        private void bP_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text!="")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
        }

        private void bL_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != "")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
        }

        private void bM_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text!="")
            {
                valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "x";
            }           
        }

        private void result_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtresultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRACAO")
            {
                txtresultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                txtresultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                txtresultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            txtresultado.Clear();
            lblOperacao.Text = "";
            valor1 = 0;
            valor2 = 0;           
        }

        private void ce_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            txtresultado.Text = ".";
        }
    }
}
