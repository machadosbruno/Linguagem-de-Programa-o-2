using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVI
{
    internal class Poupanca : Conta
    {
        public override void AplicarRendimentoMensal()
        {
            if (ValorAtual > 0)
            {
                ValorAtual *= 1.04;
            }
            else
            {
                throw new Excecoes.SemDinheiro();
            }
        }

        public override void RetirarDinheiro(double ValorRetirar)
        {
            if (ValorAtual > 0)
            {
                double taxa = ValorRetirar * 0.01;
                ValorAtual -= ValorRetirar + taxa;
            }
            else
            {
                throw new Excecoes.SemDinheiro();
            }
        }
    }
}
