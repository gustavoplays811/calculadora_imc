using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_imc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double p, a, imc;
            p = double.Parse(TxtPeso.Text);
            a = double.Parse(TxtAltura.Text);

            imc = p / (a * a);
            if (imc <= 18.5)
            {
                TxtResultado.Text = Math.Round(imc, 3).ToString();
                lbnSituacao.Text = "Abaixo do Peso";
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                TxtResultado.Text = Math.Round(imc, 3).ToString();
                lbnSituacao.Text = "Peso adequado";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                TxtResultado.Text = Math.Round(imc, 3).ToString();
                lbnSituacao.Text = "Acima do Peso";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                TxtResultado.Text = Math.Round(imc, 3).ToString();
                lbnSituacao.Text = "Obesidade Grau 1";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                TxtResultado.Text = Math.Round(imc, 3).ToString();
                lbnSituacao.Text = "Obesidade Grau 2";
            }
            else
            {
                TxtResultado.Text = Math.Round(imc, 3).ToString();
                lbnSituacao.Text = "Obesidade Grau 3";
            }
        }

        private void lbnSituacao_Click(object sender, EventArgs e)
        {

        }
    }
}