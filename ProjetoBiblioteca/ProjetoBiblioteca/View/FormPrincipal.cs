using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBiblioteca.View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnInserirLivro_Click(object sender, EventArgs e)
        {
            FormLivroInserir formLivroInserir = new FormLivroInserir();
            formLivroInserir.ShowDialog();
        }
    }
}
