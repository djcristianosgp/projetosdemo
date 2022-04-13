namespace WorkFlow.Telas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.StPrincipal = new System.Windows.Forms.StatusStrip();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.MuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MuImagens = new System.Windows.Forms.ToolStripMenuItem();
            this.MiConvertImagens = new System.Windows.Forms.ToolStripMenuItem();
            this.miDownloadImagem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // StPrincipal
            // 
            this.StPrincipal.Location = new System.Drawing.Point(0, 382);
            this.StPrincipal.Name = "StPrincipal";
            this.StPrincipal.Size = new System.Drawing.Size(848, 22);
            this.StPrincipal.TabIndex = 1;
            this.StPrincipal.Text = "statusStrip1";
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MuArquivo,
            this.MuImagens});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(848, 24);
            this.mnPrincipal.TabIndex = 3;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // MuArquivo
            // 
            this.MuArquivo.Name = "MuArquivo";
            this.MuArquivo.Size = new System.Drawing.Size(61, 20);
            this.MuArquivo.Text = "Arquivo";
            // 
            // MuImagens
            // 
            this.MuImagens.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiConvertImagens,
            this.miDownloadImagem});
            this.MuImagens.Name = "MuImagens";
            this.MuImagens.Size = new System.Drawing.Size(64, 20);
            this.MuImagens.Text = "Imagens";
            // 
            // MiConvertImagens
            // 
            this.MiConvertImagens.Name = "MiConvertImagens";
            this.MiConvertImagens.Size = new System.Drawing.Size(180, 22);
            this.MiConvertImagens.Text = "Converter Imagens";
            this.MiConvertImagens.Click += new System.EventHandler(this.MiConvertImagens_Click);
            // 
            // miDownloadImagem
            // 
            this.miDownloadImagem.Name = "miDownloadImagem";
            this.miDownloadImagem.Size = new System.Drawing.Size(180, 22);
            this.miDownloadImagem.Text = "Download Imagem";
            this.miDownloadImagem.Click += new System.EventHandler(this.miDownloadImagem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 404);
            this.Controls.Add(this.StPrincipal);
            this.Controls.Add(this.mnPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkFlow - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StPrincipal;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MuArquivo;
        private System.Windows.Forms.ToolStripMenuItem MuImagens;
        private System.Windows.Forms.ToolStripMenuItem MiConvertImagens;
        private System.Windows.Forms.ToolStripMenuItem miDownloadImagem;
    }
}