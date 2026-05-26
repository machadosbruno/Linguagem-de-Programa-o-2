using ProjetoBiblioteca.Controller;
using ProjetoBiblioteca.Model;
using ProjetoBiblioteca.Utils;
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
        public FormLivroInserir()
        {
            InitializeComponent();
        }
        public bool salvou = false;
        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            string titulo = txtTitulo.Text.Trim();
            DateTime dataPublicacao = dtpDataPublicacao.Value;

            if (titulo == "")
                errorProvider1.SetError(txtTitulo, Utils.MensagensErro.Livro.Titulo_Obrigatorio);

            if(titulo.Length > 100)
                errorProvider1.SetError(txtTitulo, Utils.MensagensErro.Livro.Titulo_Comprimento);

            if (dataPublicacao.Date > DateTime.Today)
                errorProvider1.SetError(dtpDataPublicacao, Utils.MensagensErro.Livro.DataPublicacao_Maximo);

            if(!errorProvider1.HasErrors)
            {
                Livro livro = new Livro
                {
                    Titulo = titulo,
                    DataPublicacao = dataPublicacao
                };

                try
                {
                    LivroController.Salvar(livro);
                    MessageBox.Show("Livro salvo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    salvou = true;
                    Close();
                }
                catch(ExcecaoEsperada ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    //log ex
                    MessageBox.Show(Utils.MensagensErro.Geral.Erro_Geral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormLivroInserir_Load(object sender, EventArgs e)
        {
            dtpDataPublicacao.MaxDate = DateTime.Now;
        }
    }
}
