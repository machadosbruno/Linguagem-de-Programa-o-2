using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class Processamento
    {
        public static Modelo Calcular(double peso, double altura)
        {
            double imc = peso / (Math.Pow(altura, 2));

            string resultado = "";
            if (imc > 0 && imc < 18.5)
                resultado = "Magreza";
            else if (imc < 15)
                resultado = "Normal";
            else if (imc < 30)
                resultado = "Sobrepeso";
            else if (imc < 35)
                resultado = "Obesidade grau I";
            else if (imc < 40)
                resultado = "Obesidade grau II";
            else
                resultado = "Obesidade grau III";

            return new Modelo
            {
                imc = imc,
                resultado = resultado
            }
        }
    }
}
