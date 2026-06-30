namespace ProjetoBiblioteca.View
{
    partial class FormAutorInserir
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
            button1 = new Button();
            dtpDataNascimento = new DateTimePicker();
            lblDataNascimento = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(375, 280);
            button1.Name = "button1";
            button1.Size = new Size(137, 40);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpDataNascimento.Font = new Font("Segoe UI", 15.75F);
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(12, 217);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(500, 35);
            dtpDataNascimento.TabIndex = 8;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Font = new Font("Segoe UI", 15.75F);
            lblDataNascimento.Location = new Point(12, 184);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(199, 30);
            lblDataNascimento.TabIndex = 7;
            lblDataNascimento.Text = "Data de nascimento";
            lblDataNascimento.Click += label2_Click;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Segoe UI", 15.75F);
            txtNome.Location = new Point(12, 49);
            txtNome.MaxLength = 101;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(500, 35);
            txtNome.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15.75F);
            lblNome.Location = new Point(12, 16);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 30);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Font = new Font("Segoe UI", 15.75F);
            txtEmail.Location = new Point(12, 130);
            txtEmail.MaxLength = 101;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(500, 35);
            txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.75F);
            lblEmail.Location = new Point(12, 97);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 30);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormAutorInserir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 332);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(button1);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblDataNascimento);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FormAutorInserir";
            Text = "Inserir Autor";
            Load += FormAutorInserir_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DateTimePicker dtpDataNascimento;
        private Label lblDataNascimento;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtEmail;
        private Label lblEmail;
        private ErrorProvider errorProvider1;
    }
}