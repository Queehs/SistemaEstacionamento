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
    public partial class FrmPesquisaCli : Form
    {
        public FrmPesquisaCli()
        {
            InitializeComponent();
        }

        private void FrmPesquisaCli_Load(object sender, EventArgs e)
        {
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Estacionamento;Data Source=LAB-08-19;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQL = "SELECT * FROM CadCli";

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexaoBanco);

            DataSet datasetCadCli = new DataSet();
            adaptador.Fill(datasetCadCli);

            DtCli.DataSource = datasetCadCli;
            DtCli.DataMember = datasetCadCli.Tables[0].TableName;
        }
    }
}
