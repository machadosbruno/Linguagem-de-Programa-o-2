using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Model
{
    public class Editora
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string Cidade { get; set; }

        public int AnoFundacao { get; set; }
    }
}
