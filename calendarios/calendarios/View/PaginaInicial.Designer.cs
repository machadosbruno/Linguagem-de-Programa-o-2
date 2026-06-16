namespace calendarios.View
{
    partial class PaginaInicial
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
            picBoxUsuario = new PictureBox();
            lblNome = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).BeginInit();
            SuspendLayout();
            // 
            // picBoxUsuario
            // 
            picBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            picBoxUsuario.Location = new Point(12, 12);
            picBoxUsuario.Name = "picBoxUsuario";
            picBoxUsuario.Size = new Size(61, 58);
            picBoxUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxUsuario.TabIndex = 5;
            picBoxUsuario.TabStop = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(79, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            // 
            // PaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBoxUsuario);
            Controls.Add(lblNome);
            Name = "PaginaInicial";
            Text = "PaginaInicial";
            Load += PaginaInicial_Load;
            ((System.ComponentModel.ISupportInitialize)picBoxUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxUsuario;
        private Label lblNome;
    }
}