using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();

            lblTotal.Text = "";
        }              

        public void btnSoma_Click(object sender, EventArgs e)
        {
            Conta valores = new Conta();
            valores.num1 = Convert.ToDouble(txtNum1.Text);
            valores.num2 = Convert.ToDouble(txtNum2.Text);            

            valores.Soma(valores);
            lblTotal.Text = valores.total;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Conta valores = new Conta();
            valores.num1 = Convert.ToDouble(txtNum1.Text);
            valores.num2 = Convert.ToDouble(txtNum2.Text);

            valores.Multiplicacao(valores);
            lblTotal.Text = valores.total;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            Conta valores = new Conta();
            valores.num1 = Convert.ToDouble(txtNum1.Text);
            valores.num2 = Convert.ToDouble(txtNum2.Text);

            valores.Subtracao(valores);
            lblTotal.Text = valores.total;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Conta valores = new Conta();
            valores.num1 = Convert.ToDouble(txtNum1.Text);
            valores.num2 = Convert.ToDouble(txtNum2.Text);

            valores.Divisao(valores);
            lblTotal.Text = valores.total;
        }
    }
}