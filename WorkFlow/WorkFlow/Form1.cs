﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotec.Classes;

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
            lblconexao.Text = ClsBancoPostgres.sConexao+"\r\n";
            lblconexao.Text += DateTime.Now.ToString();
        }
    }
}
