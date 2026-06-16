namespace ProjetoBiblioteca.View
{
    partial class FormLivroInserir
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
            label1 = new Label();
            txtTitulo = new TextBox();
            label2 = new Label();
            dtpDataPublicacao = new DateTimePicker();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            label3 = new Label();
            cboEditora = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 30);
            label1.TabIndex = 0;
            label1.Text = "Tìtulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitulo.Location = new Point(12, 42);
            txtTitulo.MaxLength = 101;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(501, 35);
            txtTitulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(192, 30);
            label2.TabIndex = 2;
            label2.Text = "Data de publicação";
            // 
            // dtpDataPublicacao
            // 
            dtpDataPublicacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDataPublicacao.Format = DateTimePickerFormat.Short;
            dtpDataPublicacao.Location = new Point(12, 113);
            dtpDataPublicacao.Name = "dtpDataPublicacao";
            dtpDataPublicacao.Size = new Size(501, 35);
            dtpDataPublicacao.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(376, 228);
            button1.Name = "button1";
            button1.Size = new Size(137, 40);
            button1.TabIndex = 4;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(78, 30);
            label3.TabIndex = 5;
            label3.Text = "Editora";
            // 
            // cboEditora
            // 
            cboEditora.DisplayMember = "Nome";
            cboEditora.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEditora.FormattingEnabled = true;
            cboEditora.Location = new Point(12, 184);
            cboEditora.Name = "cboEditora";
            cboEditora.Size = new Size(501, 38);
            cboEditora.TabIndex = 6;
            cboEditora.ValueMember = "Id";
            // 
            // FormLivroInserir
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 283);
            Controls.Add(cboEditora);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(dtpDataPublicacao);
            Controls.Add(label2);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(554, 242);
            Name = "FormLivroInserir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Livro";
            Load += FormLivroInserir_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitulo;
        private Label label2;
        private DateTimePicker dtpDataPublicacao;
        private Button button1;
        private ErrorProvider errorProvider1;
        private ComboBox cboEditora;
        private Label label3;
    }
}