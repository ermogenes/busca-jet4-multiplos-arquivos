using BuscadorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaIntegrada
{
    public partial class AdicionarPesquisaForm : Form
    {
        private DadosBusca dadosBuscaEntrada;
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=False;";

        public AdicionarPesquisaForm()
        {
            InitializeComponent();
        }

        private void PreencherComboComTabelas(string db, ComboBox combo)
        {
            combo.Items.Clear();
            DataTable userTables = null;

            using (OleDbConnection conexao = new OleDbConnection(
                String.Format(this.connectionString, db)
            ))
            {
                string[] restrictions = new string[4];
                restrictions[3] = "Table";

                try
                {
                    conexao.Open();
                    userTables = conexao.GetSchema("Tables", restrictions);

                    for (int i = 0; i < userTables.Rows.Count; i++)
                        combo.Items.Add(userTables.Rows[i][2].ToString());

                }
                catch
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados selecionado.", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void PreencherComboComCampos(string db, string tabela, ComboBox combo)
        {
            combo.Items.Clear();
            using (OleDbConnection conexao = new OleDbConnection(
                String.Format(this.connectionString, db)
            ))
            {
                try
                {
                    conexao.Open();

                    var schemaTable = conexao.GetOleDbSchemaTable(
                            OleDbSchemaGuid.Columns,
                            new Object[] { null, null, tabela }
                    );

                    if (schemaTable != null)
                    {
                        var columnOrdinalForName = schemaTable.Columns["COLUMN_NAME"].Ordinal;
                        (from DataRow r in schemaTable.Rows select r.ItemArray[columnOrdinalForName].ToString()).ToList().ForEach(c => combo.Items.Add(c));
                    }

                }
                catch
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados selecionado.", "Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EscolherArquivoButton_Click(object sender, EventArgs e)
        {
            var of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(NomePesquisaTextBox.Text)) NomePesquisaTextBox.Text = of.FileName;
                ArquivoEscolhidoLabel.Text = of.FileName;
                ArquivoPanel.Enabled = File.Exists(of.FileName);
                this.PreencherComboComTabelas(of.FileName, NomeTabelaComboBox);
            }
        }

        private void NomeTabelaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NomeTabelaComboBox.SelectedIndex >= 0)
            {
                this.PreencherComboComCampos(ArquivoEscolhidoLabel.Text, NomeTabelaComboBox.Text, CampoBuscaComboBox);
                this.PreencherComboComCampos(ArquivoEscolhidoLabel.Text, NomeTabelaComboBox.Text, CampoExibicao1ComboBox);
                this.PreencherComboComCampos(ArquivoEscolhidoLabel.Text, NomeTabelaComboBox.Text, CampoExibicao2ComboBox);
                CamposPanel.Enabled = CampoBuscaComboBox.Items.Count > 0;
            }
        }

        private void CampoBuscaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TituloChaveTextBox.Text = CampoBuscaComboBox.Text;
        }

        private void CampoExibicao1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TituloExibicao1TextBox.Text = CampoExibicao1ComboBox.Text;
        }

        private void CampoExibicao2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TituloExibicao2TextBox.Text = CampoExibicao2ComboBox.Text;
        }

        private void VoltarButton_Click(object sender, EventArgs e)
        {
            this.dadosBuscaEntrada = new DadosBusca { };
            this.Close();
        }

        private void ConfirmarButton_Click(object sender, EventArgs e)
        {
            this.dadosBuscaEntrada = new DadosBusca {
                campoChave = CampoBuscaComboBox.Text,
                tituloCampoChave = TituloChaveTextBox.Text,
                campoExibicao1 = CampoExibicao1ComboBox.Text,
                campoExibicao2 = CampoExibicao2ComboBox.Text,
                tituloCampoExibicao1 = TituloExibicao1TextBox.Text,
                tituloCampoExibicao2 = TituloExibicao2TextBox.Text,
                nomeBusca = NomePesquisaTextBox.Text,
                nomeTabela = NomeTabelaComboBox.Text,
                pathArquivo = ArquivoEscolhidoLabel.Text
            };
            this.Close();
        }

        public DadosBusca SelecionaBusca()
        {
            this.ShowDialog();
            return this.dadosBuscaEntrada;
        }

    }
}
