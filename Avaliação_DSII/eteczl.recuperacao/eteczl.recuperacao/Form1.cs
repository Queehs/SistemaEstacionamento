using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eteczl.recuperacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadCarro_Click(object sender, EventArgs e)
        {
            FrmCadCarros cadastroCarros = new FrmCadCarros();
            cadastroCarros.Show();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            FrmCadCli cadastroClientes = new FrmCadCli();
            cadastroClientes.Show();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            FrmCadFunc cadastroFuncionarios = new FrmCadFunc();
            cadastroFuncionarios.Show();
        }
    }
}
