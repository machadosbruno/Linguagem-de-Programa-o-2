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

        private void button1_Click(object sender, EventArgs e)
        {
            new FormLivroInserir().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormLivroPesquisar().ShowDialog();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormLivroInserir().ShowDialog();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormEditoraPesquisar().ShowDialog();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormEditoraInserir().ShowDialog();
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new FormAutorInserir().ShowDialog();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new FormAutorPesquisar().ShowDialog();
        }
    }
}
