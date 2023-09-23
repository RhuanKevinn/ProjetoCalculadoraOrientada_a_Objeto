using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCalculadoraOrientada_a_Objeto.Classe;
using ProjetoCalculadoraOrientada_a_Objeto.Properties;
using ProjetoCalculadoraOrientada_a_Objeto;
using System.Windows.Forms;
using System.Web;
using System.Security.Cryptography;

namespace ProjetoCalculadoraOrientada_a_Objeto.Classe
{
    public class CalcCientifica : CalculadoraBasica
    {
        public string Comparar()
        {
            string texto;

            //Lógica de comparação  
            if (Num1 > Num2)
            {

                texto = Num1.ToString();
                texto += " é maior ";
                return texto;
            }
            else if (Num1 < Num2)
            {
                
                texto = Num2.ToString();
                texto += " é maior ";
                return texto;
            }

            else
            {
                texto = " São iguais ";
                return texto;
            }
                

        }
        public string Par_impar()
        {
            if (Num1 % 2 == 0)
            {
              
                return "É par";
            }
            else
            {
                return "É impar";
            }


        }
        public string Potenciação(double p1, double p2)
        {

            //Lógica de fazer potenciação
            return Math.Pow(p1, p2).ToString();
        }


    }
}
