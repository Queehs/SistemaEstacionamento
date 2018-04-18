using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eteczl.recuperacao
{
    public partial class FrmCadCli : Form
    {
        public FrmCadCli()
        {
            InitializeComponent();
        }

        private void btnLimpCli_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txtNomeCli.Text = string.Empty;
            txtSobrenomeCli.Text = string.Empty;
            txtEnderecoCli.Text = string.Empty;
            txtNum.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.Text == "" || txtSobrenomeCli.Text == "" || txtEnderecoCli.Text == "" || txtNum.Text == "" || txtBairro.Text == "" || txtCidade.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "ETEC ZL");
            }
            {
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Estacionamento;Data Source=LAB-08-19;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQL = "INSERT INTO CadCli VALUES ('" + txtNomeCli.Text + "','" + txtSobrenomeCli.Text + "', '" +
                txtEnderecoCli.Text + "', '" +
                txtNum.Text + "', '" +
                txtBairro.Text + "', '" +
                txtCidade.Text + "')";

                SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
                execucaoSQL.ExecuteNonQuery();
                conexaoBanco.Close();

                MessageBox.Show("Cadastro realizado", "ETEC Zona Leste");
                limpar();
            }
        }

        private void btnPesqCli_Click(object sender, EventArgs e)
        {
            FrmPesquisaCli pesquisaCli = new FrmPesquisaCli();
            pesquisaCli.Show();
        }
    }
}
