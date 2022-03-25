namespace WorkFlow
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblconexao = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblconexao
            // 
            this.lblconexao.AutoSize = true;
            this.lblconexao.Location = new System.Drawing.Point(216, 93);
            this.lblconexao.Name = "lblconexao";
            this.lblconexao.Size = new System.Drawing.Size(35, 13);
            this.lblconexao.TabIndex = 0;
            this.lblconexao.Text = "label1";
            // 
            // txtLista
            // 
            this.txtLista.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtLista.Location = new System.Drawing.Point(347, 0);
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(453, 450);
            this.txtLista.TabIndex = 1;
            this.txtLista.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.lblconexao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconexao;
        private System.Windows.Forms.RichTextBox txtLista;
    }
}

