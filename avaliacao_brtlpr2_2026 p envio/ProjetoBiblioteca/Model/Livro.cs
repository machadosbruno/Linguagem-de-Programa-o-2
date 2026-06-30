using Microsoft.IdentityModel.Tokens;
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
    
        public int AutorId { get; set; }

        public Autor AutorA { get; set; }

        [NotMapped]
        public string NomeAutor
        {
            get
            {
                return AutorA.Nome;
            }
            set
            {
                AutorA.Nome = value;
            }

        }

        [NotMapped]
        public string EmailAutor
        {
            get
            {
                return AutorA.Email;
            }
            set
            {
                AutorA.Email = value;
            }
        }

        public int EditoraId { get; set; }
        public Editora Editora { get; set; }

        [NotMapped]
        public string NomeEditora
        {
            get
            {
                return Editora.Nome;
            }
        }
    }
}
