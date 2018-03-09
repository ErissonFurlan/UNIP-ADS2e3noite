using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeiraAula.Modelo
{
    public class Controle
    {
        public String Calcular(String num1, String num2, String op)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0;
            String resposta = "";
            try
            {
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                if (op.Equals("+"))
                    resultado = n1 + n2;
                if (op.Equals("-"))
                    resultado = n1 - n2;
                if (op.Equals("*"))
                    resultado = n1 * n2;
                resposta = resultado.ToString("0.##");
                if (op.Equals("/"))
                    if (n2 == 0)
                        resposta = "Divisão por zero";
                    else
                    {
                        resultado = n1 / n2;
                        resposta = resultado.ToString("0.##");
                    }
            }
            catch (FormatException e)
            {
                resposta = "Digite um número válido";
            }
            return resposta;
        }
    }
}
