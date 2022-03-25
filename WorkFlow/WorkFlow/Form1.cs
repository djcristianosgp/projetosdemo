using Bibliotec.API;
using Bibliotec.Classes;
using System;
using System.Windows.Forms;

namespace WorkFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblconexao.Text = ClsBancoPostgres.sConexao + "\r\n";
            lblconexao.Text += DateTime.Now.ToString();

            ClsAuthNotion cNotion = new ClsAuthNotion();
            cNotion.FU_Loga();

            foreach (string c in cNotion.SListaUser)
            {
                txtLista.Text = c + "\r\n";
            }
        }
    }
}
