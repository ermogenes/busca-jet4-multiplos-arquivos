using BuscadorLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaIntegrada
{
    public partial class ConfiguracoesForm : Form
    {

        private List<DadosBusca> dadosBuscaConfiguracoes = new List<DadosBusca>();

        public ConfiguracoesForm()
        {
            InitializeComponent();
        }

        private void ReloadLista()
        {
            BuscasListBox.Items.Clear();
            this.dadosBuscaConfiguracoes.ForEach(db => BuscasListBox.Items.Add(db));
        }

        private void FecharButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (BuscasListBox.SelectedIndex >= 0)
            {
                if (MessageBox.Show(BuscasListBox.Text, "Confirma exclusão?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dadosBuscaConfiguracoes.RemoveAt(BuscasListBox.SelectedIndex);
                    this.ReloadLista();
                }
            }
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            var f = new AdicionarPesquisaForm();
            DadosBusca db = f.SelecionaBusca();


            if (!String.IsNullOrEmpty(db.nomeBusca))
            {
                this.dadosBuscaConfiguracoes.Add(db);
                this.ReloadLista();
            }
        }

        public List<DadosBusca> SelecionaBuscas(List<DadosBusca> dadosBuscaInicial)
        {
            this.dadosBuscaConfiguracoes = dadosBuscaInicial;
            this.ShowDialog();
            return this.dadosBuscaConfiguracoes;
        }

        private void ConfiguracoesForm_Load(object sender, EventArgs e)
        {
            this.ReloadLista();
        }
    }
}
