using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
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
    public partial class FormLivroPesquisar : Form
    {
        public FormLivroPesquisar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Livro> resultado = LivroController.Pesquisar();
            dataGridView1.DataSource = resultado;
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            FormLivroInserir formLivroInserir = new FormLivroInserir();
            formLivroInserir.ShowDialog();
            if (formLivroInserir.salvou)
            {
                List<Livro> resultado = LivroController.Pesquisar();
                dataGridView1.DataSource = resultado;
            }
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                Livro livro = (Livro)dataGridView1.SelectedRows[0].DataBoundItem;
                DialogResult confirma = MessageBox.Show("Você realmente quer excluir o livro "+ livro.Titulo +"?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirma == DialogResult.Yes)
                {
                    LivroController.Excluir(livro);
                }
            }

        }
    }
}
