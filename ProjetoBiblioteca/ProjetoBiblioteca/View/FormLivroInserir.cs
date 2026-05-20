using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using ProjetoBiblioteca.Utils;
using ProjetoBiblioteca.Utils.MensagensErro;
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
    public partial class FormLivroInserir : Form
    {
        private ErrorProvider errorProvider1 = new ErrorProvider();
        public FormLivroInserir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tituloLivro = txtTitulo.Text;
            DateTime dataPublicaco = dtpDataPublicacao.Value;

            if (tituloLivro == "")
            {
                errorProvider1.SetError(txtTitulo, MensagensErro.TituloInvalido);
            }

            if(tituloLivro.Length > 100)
            {
                errorProvider1.SetError(txtTitulo, MensagensErro.TituloTamanhoMaximo);
            }

            if (dataPublicaco > DateTime.Now)
            {
                errorProvider1.SetError(dtpDataPublicacao, MensagensErro.DataPublicacaoMaxima);
            }

            if (!errorProvider1.HasErrors)
            {
                Livro livro = new Livro
                {
                    Titulo = tituloLivro,
                    DataPublicacao = dataPublicaco
                };
                try
                {
                    LivroController.Salvar(livro);
                    MessageBox.Show("Livro Salvo com sucesso!");
                    Close();
                }
                catch (ExcecaoEsperada ex) {
                    MessageBox.Show(Geral.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void FormLivroInserir_Load(object sender, EventArgs e)
        {
            dtpDataPublicacao.MaxDate = DateTime.Today;
        }
    }
}
