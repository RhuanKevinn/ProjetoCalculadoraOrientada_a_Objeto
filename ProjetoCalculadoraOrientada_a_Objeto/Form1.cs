using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCalculadoraOrientada_a_Objeto.Classe;

namespace ProjetoCalculadoraOrientada_a_Objeto
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }



        private void CmbFunc_SelectedIndexChanged(object sender, EventArgs e)
        {





            switch (cmbFunc.Text)
            {
                 
        
                case "Somar":
                    {
                  



                        if (txtNumero1.Enabled == false) 
                        {
                            txtNumero1.Enabled = true;

                            txtNumero1.Text = "0";


                        }
                  
                        decimal a, b;
                        b = decimal.Parse(txtNumero1.Text);
                        a = decimal.Parse(txtNumero2.Text);

                   
                        txtNumero1.Enabled = true;
                        CalculadoraBasica calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        calc.Somar();
                        label1.Text = calc.Resultado.ToString();
                        break;
                    }

                case "Subtrair":
                    {
                        if (txtNumero1.Enabled == false)
                        {
                            txtNumero1.Enabled = true;

                            txtNumero1.Text = "0";


                        }
                        decimal a, b;
                        b = decimal.Parse(txtNumero1.Text);
                        a = decimal.Parse(txtNumero2.Text);
                        CalculadoraBasica calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        label1.Text = calc.Subtrair();
                        break;
                    }
                case "Multiplicar":
                    {
                        if (txtNumero1.Enabled == false)
                        {
                            txtNumero1.Enabled = true;

                            txtNumero1.Text = "0";


                        }
                        decimal a, b;
                        b = decimal.Parse(txtNumero1.Text);
                        a = decimal.Parse(txtNumero2.Text);
                        CalculadoraBasica calc = new CalculadoraBasica();
                        label1.Text = calc.Multiplicar(a, b);
                        /*MessageBox.Show("Confirma?");*/
                        break;

                    }
                case "Dividir":
                    {
                        if (txtNumero1.Enabled == false)
                        {
                            txtNumero1.Enabled = true;

                            txtNumero1.Text = "0";


                        }
                        decimal a, b;
                        b = decimal.Parse(txtNumero1.Text);
                        a = decimal.Parse(txtNumero2.Text);
                        if (b == 0)
                        {
                            label1.Text = " Não divide por 0";
                           
                            
                        }
                        else { 
                        CalculadoraBasica calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        label1.Text = calc.Dividir().ToString();
                            
                        }
                        break;
                        

                    }
                case "Potenciacao":
                    {
                        if (txtNumero1.Enabled == false)
                        {
                            txtNumero1.Enabled = true;

                            txtNumero1.Text = "0";


                        }
                        decimal a, b;
                        b = decimal.Parse(txtNumero1.Text);
                        a = decimal.Parse(txtNumero2.Text);
                        CalcCientifica calc = new CalcCientifica();
                        label1.Text = calc.Potenciação(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();
                        /* label1.Text = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();*/
                        /*MessageBox.Show("Confirma?");*/

                        break;
                    }
                    case "Par_Impar":
                    {
                        decimal a, b;
                       
                        a = decimal.Parse(txtNumero2.Text);
                        CalcCientifica calc = new CalcCientifica();
                        txtNumero1.Enabled = false;
                        txtNumero1.Text = "";
                        calc.Num1 = a;
                        label1.Text = calc.Par_impar().ToString();
                        break;
                    }
                    case "Comparar":
                    {
                        if (txtNumero1.Enabled == false)
                        {
                            txtNumero1.Enabled = true;

                            txtNumero1.Text = "0";


                        }
                        decimal a, b;

                        a = decimal.Parse(txtNumero1.Text);
                        b = decimal.Parse(txtNumero2.Text);     
                        CalcCientifica calc = new CalcCientifica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        label1.Text = calc.Comparar();
                        
                       

                        break;
                    }

                       
                    
                        default:
                    break;



            }
        }
    }
}

