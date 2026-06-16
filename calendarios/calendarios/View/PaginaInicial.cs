using calendarios.Controller;
using calendarios.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calendarios.View
{
    public partial class PaginaInicial : Form
    {
        public PaginaInicial()
        {
            InitializeComponent();
            Usuario usuario =  UsuarioController.getUsuario();
            lblNome.Text = usuario.Nome;
            picBoxUsuario.Image = Image.FromFile(usuario.Foto.ToString());
        }

        private void PaginaInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
