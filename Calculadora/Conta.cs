using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Conta
    {
        public double num1 = 0;
        public double num2 = 0;
        public string total;

        public string Soma(Conta conta)
        {
            num1 = conta.num1;
            num2 = conta.num2;
            total = Convert.ToString(num1 + num2);

            return total;
        }

        public string Subtracao(Conta conta)
        {
            num1 = conta.num1;
            num2 = conta.num2;
            total = Convert.ToString(num1 - num2);

            return total;
        }

        public string Multiplicacao(Conta conta)
        {
            num1 = conta.num1;
            num2 = conta.num2;
            total = Convert.ToString(num1 * num2);

            return total;
        }

        public string Divisao(Conta conta)
        {
            num1 = conta.num1;
            num2 = conta.num2;
            total = Convert.ToString(num1 / num2);

            return total;
        }
    }
}