using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVI
{
    public abstract class Conta
    {
        public string Nome { get; set; }
        public double ValorAtual { get; set; }
        public abstract void AplicarRendimentoMensal();

        public abstract void RetirarDinheiro(double valorRetirar);

        public void Depositar(double ValorDeposito)
        {
            ValorAtual += ValorDeposito;
        }
    }
}
