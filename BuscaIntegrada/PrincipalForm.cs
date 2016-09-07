using BuscadorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BuscaIntegrada
{
    public partial class PrincipalForm : Form
    {

        public List<DadosBusca> buscas;
        private string configPath = Application.StartupPath;
        private string configArquivo = "config.xml";

        public PrincipalForm()
        {
            buscas = new List<DadosBusca>();

            if (File.Exists(this.GetConfigPath()))
            {
                this.LerBuscas();
            }
            else
            {
                this.SalvarBuscas();
            }

            #region Buscas para teste
            /*
            buscas.Add(
                new DadosBusca
                {
                    nomeBusca = "Busca de Teste 2016",
                    pathArquivo = @"path\to\your\file.mdb",
                    campoChave = "bo",
                    campoExibicao1 = "id",
                    campoExibicao2 = "delegacia",
                    nomeTabela = "reg",
                    tituloCampoExibicao1 = "REG",
                    tituloCampoExibicao2 = "DELEGACIA"
                }
            );

            buscas.Add(
                new DadosBusca
                {
                    nomeBusca = "Busca de Teste 2015",
                    pathArquivo = @"path\to\your\file.mdb",
                    campoChave = "bo",
                    campoExibicao1 = "id",
                    campoExibicao2 = "delegacia",
                    nomeTabela = "reg",
                    tituloCampoExibicao1 = "REG",
                    tituloCampoExibicao2 = "DELEGACIA"
                }
            );
            */
            #endregion

            InitializeComponent();
        }

        private void LerBuscas()
        {
            XmlSerializer SerializerObj = new XmlSerializer(typeof(List<DadosBusca>));
            FileStream ReadFileStream = new FileStream(this.GetConfigPath(), FileMode.Open, FileAccess.Read, FileShare.Read);

            buscas = (List<DadosBusca>)SerializerObj.Deserialize(ReadFileStream);
            ReadFileStream.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void preferenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cf = new ConfiguracoesForm();
            var novasBuscas = cf.SelecionaBuscas(this.buscas);
            this.buscas = novasBuscas;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Projeto Integrador: Univesp Bim 09 - Setembro de 2016\n\n" + 
                "Grupo: SANTOS SM.1\n\n" +
                "Anderson de Carvalho 1500041\n" +
                "Ermogenes Daniel Palacio (Dev) - 1400882\n" +
                "Luciene Sacone - 1401646\n"+
                "Maria dos Passos Silva - 1401849\n"+
                "Sabrina Heloisa da Silva - 1500454\n"+
                "Vinicius Vitor da Silva - 1500506\n"+
                "\nhttps://github.com/ermogenes/busca-jet4-multiplos-arquivos\n"+
                "\nÍcone: tks to http://www.fatcow.com/free-icons",
                "Sobre...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BuscaButton_Click(object sender, EventArgs e)
        {
            var chave = BuscaTextBox.Text.Trim();
            if (!String.IsNullOrEmpty(chave))
            {
                BuscaDataGridView.Rows.Clear();

                this.Cursor = Cursors.WaitCursor;
                this.Enabled = false;

                BuscaProgressBar.Maximum = this.buscas.Count;
                BuscaProgressBar.Value = 0;
                BuscaProgressBar.Show();

                foreach (var busca in this.buscas)
                {
                    var b = new Buscador(busca);
                    var resultados = b.buscar(chave);
                    resultados.ForEach(
                        r => BuscaDataGridView.Rows.Add(new String[] {
                            b.Nome,
                            b.TituloChave + " = " + r.chave,
                            b.TituloExibicao1 + " = " + r.exibicao1,
                            b.TituloExibicao2 + " = " + r.exibicao2
                        })
                    );

                    BuscaProgressBar.Value++;
                }

                this.Cursor = Cursors.Default;
                this.Enabled = true;
                LimpaProgressoTimer.Enabled = true;
            }
        }

        private void PrincipalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.SalvarBuscas();
        }

        private void SalvarBuscas()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<DadosBusca>));
            using (FileStream fs = new FileStream(this.GetConfigPath(), FileMode.Create))
            {
                ser.Serialize(fs, buscas);
            }
        }

        private string GetConfigPath()
        {
            return this.configPath + @"\" + this.configArquivo;
        }

        private void LimpaProgressoTimer_Tick(object sender, EventArgs e)
        {
            BuscaProgressBar.Hide();
            LimpaProgressoTimer.Enabled = false;
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show(
                "Deseja finalizar a aplicação?",
                "Atenção",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK);
        }
    }
}
