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
    public partial class FrmCadCarros : Form
    {
        public FrmCadCarros()
        {
            InitializeComponent();
        }

        private void btnLimpCarro_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txtPlaca.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtChassi.Text = string.Empty;
            txtAnoFab.Text = string.Empty;
            txtAnoMod.Text = string.Empty;
        }

        private void btnCadCarro_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || txtCor.Text == "" || txtChassi.Text == "" || txtAnoFab.Text == "" || txtAnoMod.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "ETEC ZL");
            }
            {
                string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Estacionamento;Data Source=LAB-08-19;password=info211";

                SqlConnection conexaoBanco = new SqlConnection(conexao);

                conexaoBanco.Open();

                string comandoSQL = "INSERT INTO CadCar VALUES ('" + txtPlaca.Text + "','" + txtMarca.Text + "', '" +
                txtModelo.Text + "', '" +
                txtCor.Text + "', '" +
                txtChassi.Text + "', '" +
                txtAnoFab.Text + "', '" +
                txtAnoMod.Text + "')";

                SqlCommand execucaoSQL = new SqlCommand(comandoSQL, conexaoBanco);
                execucaoSQL.ExecuteNonQuery();
                conexaoBanco.Close();

                MessageBox.Show("Cadastro realizado", "ETEC Zona Leste");
                limpar();
            }
        }

        private void btnPesqCarro_Click(object sender, EventArgs e)
        {
            FrmPesquisaCar pesquisaCar = new FrmPesquisaCar();
            pesquisaCar.Show();
        }
    }
}
