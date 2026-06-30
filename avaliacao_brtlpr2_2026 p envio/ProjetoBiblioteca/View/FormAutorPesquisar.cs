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
    public partial class FormAutorPesquisar : Form
    {
        public FormAutorPesquisar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            Autor autor = new Autor();
            if(txtPesquisa.Text.Contains("@"))
                autor.Email = txtPesquisa.Text.Trim();
            else
                autor.Nome = txtPesquisa.Text.Trim();
            List<Autor> resultado = AutorController.Pesquisar(autor);
            dataGridView1.DataSource = resultado;
        }

        private void novaToolStripButton_Click_1(object sender, EventArgs e)
        {
            FormAutorInserir form = new FormAutorInserir();
            form.ShowDialog();

            if (form.salvou)
            {
                txtPesquisa.Clear();
                Pesquisar();
            }
        }

        private void abrirToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Autor autorSelecionado = (Autor)dataGridView1.SelectedRows[0].DataBoundItem;
                FormAutorInserir form = new FormAutorInserir(autorSelecionado.Id);
                form.ShowDialog();

                if (form.salvou)
                {
                    txtPesquisa.Clear();
                    Pesquisar();
                }
            }
        }

        private void recortarToolStripButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Autor autorSelecionado = (Autor)dataGridView1.SelectedRows[0].DataBoundItem;
                Livro buscar = new Livro() {
                    AutorId = autorSelecionado.Id
                };
                if (LivroController.LivroPorAutor(buscar))
                {
                    MessageBox.Show($"Não é possível remover o autor {autorSelecionado.Nome} pois ele tem livros relacionados cadastrados." +
                        $"Para remover o autor, remova os livros relacionados à ele antes.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Você realmente quer remover o autor {autorSelecionado.Nome}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); ;
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            AutorController.Excluir(autorSelecionado);
                            txtPesquisa.Clear();
                            Pesquisar();
                            MessageBox.Show("Autor removido com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
    }
}
