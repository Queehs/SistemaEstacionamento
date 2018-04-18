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
    public partial class FrmCadFunc : Form
    {
        public FrmCadFunc()
        {
            InitializeComponent();
        }

        private void btnLimpFunc_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txtNomeFunc.Text = string.Empty;
            txtSobrenomeFunc.Text = string.Empty;
            txtNasc.Text = string.Empty;
            txtAdmissao.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtEnderecoFunc.Text = string.Empty;
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            if (txtNomeFunc.Text == "" || txtSobrenomeFunc.Text == "" || txtNasc.Text == "" || txtAdmissao.Text == "" || txtCPF.Text == "" || txtRG.Text == "" || txtEnderecoFunc.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "ETEC ZL");
            }
            {
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Estacionamento;Data Source=LAB-08-19;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQL = "INSERT INTO CadFunc VALUES ('" + txtNomeFunc.Text + "','" + txtSobrenomeFunc.Text + "', '" +
                txtNasc.Text + "', '" +
                txtAdmissao.Text + "', '" +
                txtCPF.Text + "', '" +
                txtRG.Text + "', '" +
                txtEnderecoFunc.Text + "')";

                SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
                execucaoSQL.ExecuteNonQuery();
                conexaoBanco.Close();

                MessageBox.Show("Cadastro realizado", "ETEC Zona Leste");
                limpar();
            }
        }

        private void btnPesqFunc_Click(object sender, EventArgs e)
        {
            FrmPesquisaFunc pesquisaFunc = new FrmPesquisaFunc();
            pesquisaFunc.Show();
        }
    }
}
