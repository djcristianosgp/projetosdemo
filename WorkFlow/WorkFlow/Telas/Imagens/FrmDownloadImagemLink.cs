using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WorkFlow.Telas.Imagens
{
    public partial class FrmDownloadImagemLink : Form
    {
        public FrmDownloadImagemLink()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtLink.Text))
                {
                    Uri uri = new Uri(txtLink.Text);

                    using (WebClient webClient = new WebClient())
                    {

                        using (Stream stream = webClient.OpenRead(uri))
                        {
                            if (stream != null)
                            {
                                piImagemDownload.Image = Image.FromStream(stream);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
