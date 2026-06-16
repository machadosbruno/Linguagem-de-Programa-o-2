namespace Exercicio8
{
    partial class FormExibicao
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
            dataGridView1 = new DataGridView();
            ddlSituacao = new ComboBox();
            usuarioBindingSource = new BindingSource(components);
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            senhaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            situacaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            situacaoDisplayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { usernameDataGridViewTextBoxColumn, senhaDataGridViewTextBoxColumn, situacaoDataGridViewTextBoxColumn, situacaoDisplayDataGridViewTextBoxColumn });
            dataGridView1.DataSource = usuarioBindingSource;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 382);
            dataGridView1.TabIndex = 0;
            // 
            // ddlSituacao
            // 
            ddlSituacao.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlSituacao.FormattingEnabled = true;
            ddlSituacao.Items.AddRange(new object[] { "[Todos]", "Apenas ativos", "Apenas inativos" });
            ddlSituacao.Location = new Point(12, 12);
            ddlSituacao.Name = "ddlSituacao";
            ddlSituacao.Size = new Size(776, 38);
            ddlSituacao.TabIndex = 1;
            ddlSituacao.SelectedIndexChanged += ddlSituacao_SelectedIndexChanged;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Usuario);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.FillWeight = 40F;
            usernameDataGridViewTextBoxColumn.HeaderText = "Nome de usuário";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            senhaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            senhaDataGridViewTextBoxColumn.FillWeight = 40F;
            senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            situacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao";
            situacaoDataGridViewTextBoxColumn.HeaderText = "Situacao";
            situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            situacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // situacaoDisplayDataGridViewTextBoxColumn
            // 
            situacaoDisplayDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            situacaoDisplayDataGridViewTextBoxColumn.DataPropertyName = "SituacaoDisplay";
            situacaoDisplayDataGridViewTextBoxColumn.FillWeight = 20F;
            situacaoDisplayDataGridViewTextBoxColumn.HeaderText = "Situação";
            situacaoDisplayDataGridViewTextBoxColumn.Name = "situacaoDisplayDataGridViewTextBoxColumn";
            situacaoDisplayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormExibicao
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ddlSituacao);
            Controls.Add(dataGridView1);
            Name = "FormExibicao";
            Text = "FormExibicao";
            Load += FormExibicao_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox ddlSituacao;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn situacaoDisplayDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
    }
}