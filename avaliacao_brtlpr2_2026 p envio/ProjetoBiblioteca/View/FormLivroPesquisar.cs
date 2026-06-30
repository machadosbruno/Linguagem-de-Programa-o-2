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
    public partial class FormLivroPesquisar : Form
    {
        public FormLivroPesquisar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            Livro livro = new Livro();
            livro.AutorA = new Autor()
            {
                Email = txtPesquisaTitulo.Text.Trim(),
                Nome = txtPesquisaTitulo.Text.Trim()
            };
            livro.Titulo = txtPesquisaTitulo.Text.Trim();
            
            List<Livro> resultado = LivroController.Pesquisar(livro);
            dataGridView1.DataSource = resultado;
        }

        private void txtPesquisaTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            FormLivroInserir form = new FormLivroInserir();
            form.ShowDialog();

            if (form.salvou)
            {
                txtPesquisaTitulo.Clear();
                Pesquisar();
            }
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Livro livroSelecionado = (Livro)dataGridView1.SelectedRows[0].DataBoundItem;
                DialogResult dr = MessageBox.Show($"Você realmente quer remover o livro de título {livroSelecionado.Titulo}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); ;
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        LivroController.Excluir(livroSelecionado);
                        txtPesquisaTitulo.Clear();
                        Pesquisar();
                        MessageBox.Show("Livro removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (ExcecaoEsperada ee)
                    {
                        MessageBox.Show(ee.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        //log ex
                        MessageBox.Show(Utils.MensagensErro.Geral.Erro_Geral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Livro livroSelecionado = (Livro)dataGridView1.SelectedRows[0].DataBoundItem;
                FormLivroInserir form = new FormLivroInserir(livroSelecionado.Id);
                form.ShowDialog();

                if (form.salvou)
                {
                    txtPesquisaTitulo.Clear();
                    Pesquisar();
                }
            }
        }
    }
}
