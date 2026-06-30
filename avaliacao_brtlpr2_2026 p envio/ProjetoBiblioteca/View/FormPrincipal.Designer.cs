namespace ProjetoBiblioteca.View
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            livrosToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            editorasToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem1 = new ToolStripMenuItem();
            pesquisarToolStripMenuItem1 = new ToolStripMenuItem();
            autoresToolStripMenuItem = new ToolStripMenuItem();
            inserirToolStripMenuItem2 = new ToolStripMenuItem();
            pesquisarToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem, livrosToolStripMenuItem, editorasToolStripMenuItem, autoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // livrosToolStripMenuItem
            // 
            livrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inserirToolStripMenuItem, pesquisarToolStripMenuItem });
            livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            livrosToolStripMenuItem.Size = new Size(50, 20);
            livrosToolStripMenuItem.Text = "Livros";
            livrosToolStripMenuItem.Click += livrosToolStripMenuItem_Click;
            // 
            // inserirToolStripMenuItem
            // 
            inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            inserirToolStripMenuItem.Size = new Size(124, 22);
            inserirToolStripMenuItem.Text = "Inserir";
            inserirToolStripMenuItem.Click += inserirToolStripMenuItem_Click;
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(124, 22);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            pesquisarToolStripMenuItem.Click += pesquisarToolStripMenuItem_Click;
            // 
            // editorasToolStripMenuItem
            // 
            editorasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inserirToolStripMenuItem1, pesquisarToolStripMenuItem1 });
            editorasToolStripMenuItem.Name = "editorasToolStripMenuItem";
            editorasToolStripMenuItem.Size = new Size(61, 20);
            editorasToolStripMenuItem.Text = "Editoras";
            // 
            // inserirToolStripMenuItem1
            // 
            inserirToolStripMenuItem1.Name = "inserirToolStripMenuItem1";
            inserirToolStripMenuItem1.Size = new Size(124, 22);
            inserirToolStripMenuItem1.Text = "Inserir";
            inserirToolStripMenuItem1.Click += inserirToolStripMenuItem1_Click;
            // 
            // pesquisarToolStripMenuItem1
            // 
            pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            pesquisarToolStripMenuItem1.Size = new Size(124, 22);
            pesquisarToolStripMenuItem1.Text = "Pesquisar";
            pesquisarToolStripMenuItem1.Click += pesquisarToolStripMenuItem1_Click;
            // 
            // autoresToolStripMenuItem
            // 
            autoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inserirToolStripMenuItem2, pesquisarToolStripMenuItem2 });
            autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            autoresToolStripMenuItem.Size = new Size(60, 20);
            autoresToolStripMenuItem.Text = "Autores";
            // 
            // inserirToolStripMenuItem2
            // 
            inserirToolStripMenuItem2.Name = "inserirToolStripMenuItem2";
            inserirToolStripMenuItem2.Size = new Size(180, 22);
            inserirToolStripMenuItem2.Text = "Inserir";
            inserirToolStripMenuItem2.Click += inserirToolStripMenuItem2_Click;
            // 
            // pesquisarToolStripMenuItem2
            // 
            pesquisarToolStripMenuItem2.Name = "pesquisarToolStripMenuItem2";
            pesquisarToolStripMenuItem2.Size = new Size(180, 22);
            pesquisarToolStripMenuItem2.Text = "Pesquisar";
            pesquisarToolStripMenuItem2.Click += pesquisarToolStripMenuItem2_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema da Biblioteca";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem livrosToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem inserirToolStripMenuItem;
        private ToolStripMenuItem editorasToolStripMenuItem;
        private ToolStripMenuItem inserirToolStripMenuItem1;
        private ToolStripMenuItem pesquisarToolStripMenuItem1;
        private ToolStripMenuItem autoresToolStripMenuItem;
        private ToolStripMenuItem inserirToolStripMenuItem2;
        private ToolStripMenuItem pesquisarToolStripMenuItem2;
    }
}