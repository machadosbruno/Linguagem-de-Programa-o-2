using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BVI
{
    internal class Excecoes
    {
        public class SemDinheiro : Exception
        {
            public void ExcecaoSemDinheiro()
            {
                Console.WriteLine("O cliente está sem dinheiro na conta para poder realizar a transação! :/");
            }
        }
    }
}
