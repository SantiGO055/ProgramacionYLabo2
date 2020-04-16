using System;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string retorno = "+";
            if ((operador == "+") || (operador == "-") || (operador == "*") || (operador == "/"))
            {
                retorno = operador;
            }
            else
                retorno = "+";
            return retorno;
        }
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            double resultado = 0;
            operador = ValidarOperador(operador);

            switch (operador)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    resultado = n1 / n2;
                    break;
            }
            return resultado;
        }
    }
}
