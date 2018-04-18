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
    public partial class FrmPesquisaFunc : Form
    {
        public FrmPesquisaFunc()
        {
            InitializeComponent();
        }

        private void FrmPesquisaFunc_Load(object sender, EventArgs e)
        {
            string conexao = "Persist Security Info=False;User ID=sa;Initial Catalog=Estacionamento;Data Source=LAB-08-19;password=info211";

            SqlConnection conexaoBanco = new SqlConnection(conexao);

            conexaoBanco.Open();

            string comandoSQL = "SELECT * FROM CadFunc";

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL, conexaoBanco);

            DataSet datasetCadFunc = new DataSet();
            adaptador.Fill(datasetCadFunc);

            DtFunc.DataSource = datasetCadFunc;
            DtFunc.DataMember = datasetCadFunc.Tables[0].TableName;
        }
    }
}
