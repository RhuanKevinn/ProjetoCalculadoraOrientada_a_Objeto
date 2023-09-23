using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadoraOrientada_a_Objeto
{
    public partial class Form2 : Form
    {
        decimal calculo;
        bool adicao = false;    //Variável topo bool recebe apenas duas respostas, true ou false, funciona como um botão, em algum momento será ativada.
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtOperacao.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtOperacao.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtOperacao.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtOperacao.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtOperacao.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtOperacao.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtOperacao.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtOperacao.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtOperacao.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtOperacao.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtOperacao.Text += "9";
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal (txtResultado.Text);

            txtOperacao.Text += "+";
            txtResultado.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            resultado = true;
            txtOperacao.Text += "";

            //Operação de calculo para Adição:
            if(adicao == true) //Qual operação será executada se "adicao" estiver ativa.
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) + calculo);
            }

            //Operação de calculo para Subtração:
            if (subtracao == true) //Qual operação será executada se "subtracao" estiver ativa.
            {
                txtResultado.Text = Convert.ToString(calculo - Convert.ToDecimal(txtResultado.Text));
            }
            
            if (multiplicacao == true) //Qual operação será executada se "subtracao" estiver ativa.
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) * calculo);
            }

            if (divisao == true) //Qual operação será executada se "subtracao" estiver ativa.
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) / calculo);
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "-";
            txtResultado.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "x";
            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "/";
            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ",";
            txtOperacao.Text += ",";
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = txtResultado.Text;

                Apagar = Apagar.Remove(Apagar.Length -1); //Length conta o total de caracteres e remove 1.
                txtResultado.Text = Apagar;
                txtOperacao.Text = Apagar;
            }
            catch(Exception) //excecao de erro.
            {

            }
        }



    }
}
