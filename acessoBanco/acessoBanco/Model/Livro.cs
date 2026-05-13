using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acessoBanco.Model
{
    internal class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataPublicacao { get; set; }

        //public int EditoraId { get; set; }
        //[NotMapped]
        //public string NomeEditora { get; set; }
    }
}
