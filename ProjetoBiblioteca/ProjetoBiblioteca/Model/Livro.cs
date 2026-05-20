using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBiblioteca.Model
{
    public class Livro
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Titulo { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataPublicacao { get; set; }
    }
}
