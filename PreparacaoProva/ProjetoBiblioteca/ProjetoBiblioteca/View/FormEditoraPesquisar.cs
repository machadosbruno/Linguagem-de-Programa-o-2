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
    public partial class FormEditoraPesquisar : Form
    {
        public FormEditoraPesquisar()
        {
            InitializeComponent();
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            FormEditoraInserir form = new FormEditoraInserir();
            form.ShowDialog();

            if (form.salvou)
            {
                txtPesquisaNome.Clear();
                Pesquisar();
            }
        }

        private void Pesquisar()
        {
            Editora editora = new Editora();
            editora.Nome = txtPesquisaNome.Text.Trim(); ;
            List<Editora> resultado = EditoraController.Pesquisar(editora);
            dataGridView1.DataSource = resultado;
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editora editoraSelecionada = (Editora)dataGridView1.SelectedRows[0].DataBoundItem;
                FormEditoraInserir form = new FormEditoraInserir(editoraSelecionada.Id);
                form.ShowDialog();

                if (form.salvou)
                {
                    txtPesquisaNome.Clear();
                    Pesquisar();
                }
            }
        }

        private void recortarToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editora editoraSelecionada = (Editora)dataGridView1.SelectedRows[0].DataBoundItem;
                DialogResult dr = MessageBox.Show($"Você realmente quer remover a editora {editoraSelecionada.Nome}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2); ;
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        EditoraController.Excluir(editoraSelecionada);
                        txtPesquisaNome.Clear();
                        Pesquisar();
                        MessageBox.Show("Editora removida com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void editoraBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
