using System;
using System.Windows.Forms;
using WorkFlow.Telas.Imagens;

namespace WorkFlow.Telas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void MiConvertImagens_Click(object sender, EventArgs e)
        {
            FrmConvertImagens FormConvertImagens = new FrmConvertImagens();
            FormConvertImagens.MdiParent = this;
            FormConvertImagens.Show();
        }

        private void miDownloadImagem_Click(object sender, EventArgs e)
        {
            FrmDownloadImagemLink FormDownImag = new FrmDownloadImagemLink();
            FormDownImag.MdiParent = this;
            FormDownImag.Show();
        }
    }
}
