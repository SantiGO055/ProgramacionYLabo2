using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero (string numero):this()
        {
            double.TryParse(numero, out double numeroDouble);
            this.numero = numeroDouble;
        }
        public Numero(double numero):this()
        {
            this.numero = numero;
        }
        private double ValidarNumero(string strNumero)
        {
            double retorno = 0;
            if (double.TryParse(strNumero, out double numero)  && numero >= 0)
            {
                retorno = numero;
            }
            return retorno;
        }

        private string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
            
        }

        public static string DecimalBinario(double numero)
        {
            string numeroBinario = "";
            double NumAbsoluto = Math.Abs(numero);
            long cociente = (long)NumAbsoluto;
            long resto = (long)NumAbsoluto;

            if (cociente >= 1)
            {
                while (cociente >= 1)
                {
                    resto = cociente % 2;
                    cociente = cociente / 2;

                    if (resto != 0)
                    {
                        numeroBinario = "1" + numeroBinario;
                    }
                    else
                    {
                        numeroBinario = "0" + numeroBinario;
                    }
                }
                return numeroBinario;
            }
            else
                return "Valor Invalido";
        }
        public string DecimalBinario(string numero)
        {
            double numeroAux;
            string retorno = "";
            if(double.TryParse(numero, out numeroAux))
            { 
                retorno = DecimalBinario(numeroAux);
            }
            else
            {
                retorno = "Valor Invalido";
            }
            return retorno;
        }
        public static string BinarioDecimal(string binario)
        {
            double NumeroDecimal = 0, binarioDouble, NumAbsoluto;
            int potencia = 1;
            string NumAbsolutoStr="";


            if (double.TryParse(binario, out binarioDouble))
            {
                NumAbsoluto = Math.Abs(binarioDouble);
                NumAbsolutoStr = Convert.ToString(NumAbsoluto);
            }
            else
                NumAbsolutoStr = "Valor Invalido";



            for (int i = NumAbsolutoStr.Length - 1; i >= 0; i--)
            {
                if (binario[i] == '1')
                {
                    NumeroDecimal += potencia;
                }
                potencia *= 2;
            }
            NumAbsolutoStr = Convert.ToString(NumeroDecimal);
            return NumAbsolutoStr;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno;
            if (n2.numero==0)
            {
                retorno = Double.MinValue;
            }
            else
            {
                retorno = n1.numero / n2.numero;
            }
            if (n1.numero < n2.numero)
            {
                retorno = Math.Round (n1.numero / n2.numero,6);
            }
            return retorno;
        }


    }
}
