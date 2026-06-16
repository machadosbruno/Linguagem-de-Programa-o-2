using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class Usuario
    {
        public string Username { get; set; }

        public string Senha { get; set; }

        public string Situacao { get; set; }
    
        public string SituacaoDisplay
        {
            get
            {
                if (Situacao == "A")
                    return "Ativo";
                else if (Situacao == "I")
                    return "Inativo";
                else
                    return "";
            }
        }
    }
}
