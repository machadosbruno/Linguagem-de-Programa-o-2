using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace calendarios.Model
{
    public class Usuario
    {
        public int ID { get; set; }
            
        [Required]
        public string Nome { get; set; }

        [Required]
        public byte[] Foto { get; set; }
    }
}
