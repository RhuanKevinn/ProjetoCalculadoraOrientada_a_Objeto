using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadoraOrientada_a_Objeto.Classe
{
    public class CalculadoraBasica
    {
        decimal _Num1;
        decimal _Num2;
        decimal _Resultado;
        public decimal Num1 { get => _Num1; set => _Num1 = value; }
        public decimal Num2 { get => _Num2; set => _Num2 = value; }
        public decimal Resultado { get => _Resultado; set => _Resultado = value; }

        public void Somar()
        {
            _Resultado = _Num1 + _Num2;
        }
        public string Subtrair()
        {
            return (_Num1 - _Num2).ToString();
        }

        public string Multiplicar(decimal p1, decimal p2)
        {
            return (p1 * p2).ToString();
        }


        public decimal Multiplicar()
        {
            return _Num1 * _Num2;

        }

        public decimal Dividir()
        {
                     
            return _Num1 / _Num2;

        }
 
    }
}
