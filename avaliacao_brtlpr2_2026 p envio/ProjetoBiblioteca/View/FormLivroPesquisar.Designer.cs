namespace ProjetoBiblioteca.View
{
    partial class FormLivroPesquisar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLivroPesquisar));
            txtPesquisaTitulo = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tituloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataPublicacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeAutorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeEditoraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            recortarToolStripButton = new ToolStripButton();
            txtAutor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPesquisaTitulo
            // 
            txtPesquisaTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPesquisaTitulo.Location = new Point(12, 28);
            txtPesquisaTitulo.Name = "txtPesquisaTitulo";
            txtPesquisaTitulo.PlaceholderText = "Título";
            txtPesquisaTitulo.Size = new Size(402, 35);
            txtPesquisaTitulo.TabIndex = 0;
            txtPesquisaTitulo.TextChanged += txtPesquisaTitulo_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(816, 28);
            button1.Name = "button1";
            button1.Size = new Size(138, 35);
            button1.TabIndex = 1;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tituloDataGridViewTextBoxColumn, dataPublicacaoDataGridViewTextBoxColumn, nomeAutorDataGridViewTextBoxColumn, nomeEditoraDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(942, 266);
            dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            tituloDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataPublicacaoDataGridViewTextBoxColumn
            // 
            dataPublicacaoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "DataPublicacao";
            dataPublicacaoDataGridViewTextBoxColumn.HeaderText = "DataPublicacao";
            dataPublicacaoDataGridViewTextBoxColumn.Name = "dataPublicacaoDataGridViewTextBoxColumn";
            dataPublicacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeAutorDataGridViewTextBoxColumn
            // 
            nomeAutorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeAutorDataGridViewTextBoxColumn.DataPropertyName = "NomeAutor";
            nomeAutorDataGridViewTextBoxColumn.HeaderText = "NomeAutor";
            nomeAutorDataGridViewTextBoxColumn.Name = "nomeAutorDataGridViewTextBoxColumn";
            nomeAutorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeEditoraDataGridViewTextBoxColumn
            // 
            nomeEditoraDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomeEditoraDataGridViewTextBoxColumn.DataPropertyName = "NomeEditora";
            nomeEditoraDataGridViewTextBoxColumn.HeaderText = "NomeEditora";
            nomeEditoraDataGridViewTextBoxColumn.Name = "nomeEditoraDataGridViewTextBoxColumn";
            nomeEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Model.Livro);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { novaToolStripButton, abrirToolStripButton, toolStripSeparator, recortarToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(966, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = (Image)resources.GetObject("novaToolStripButton.Image");
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&Nova";
            novaToolStripButton.Click += novaToolStripButton_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += abrirToolStripButton_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            recortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            recortarToolStripButton.Image = (Image)resources.GetObject("recortarToolStripButton.Image");
            recortarToolStripButton.ImageTransparentColor = Color.Magenta;
            recortarToolStripButton.Name = "recortarToolStripButton";
            recortarToolStripButton.Size = new Size(23, 22);
            recortarToolStripButton.Text = "E&xcluir";
            recortarToolStripButton.Click += recortarToolStripButton_Click;
            // 
            // txtAutor
            // 
            txtAutor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAutor.Location = new Point(420, 27);
            txtAutor.Name = "txtAutor";
            txtAutor.PlaceholderText = "Autor";
            txtAutor.Size = new Size(390, 35);
            txtAutor.TabIndex = 4;
            // 
            // FormLivroPesquisar
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 347);
            Controls.Add(txtAutor);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtPesquisaTitulo);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(629, 386);
            Name = "FormLivroPesquisar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Livros";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPesquisaTitulo;
        private Button button1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton recortarToolStripButton;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataPublicacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeAutorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeEditoraDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private TextBox txtAutor;
    }
}