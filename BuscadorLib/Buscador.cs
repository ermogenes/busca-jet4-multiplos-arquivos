using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscadorLib
{
    public class Buscador
    {
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Persist Security Info=False;";
        private string query = "SELECT {1},{2},{3} FROM {0} WHERE {1} LIKE @valor ORDER BY {2},{3};";
        private string nome;

        private string tituloChave;
        private string tituloExibicao1;
        private string tituloExibicao2;

        public string TituloExibicao1
        {
            get
            {
                return tituloExibicao1;
            }

            private set
            {
                tituloExibicao1 = value;
            }
        }
        public string TituloExibicao2
        {
            get
            {
                return tituloExibicao2;
            }

            private set
            {
                tituloExibicao2 = value;
            }
        }

        public string Query
        {
            get
            {
                return query;
            }

            private set
            {
                query = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            private set
            {
                nome = value;
            }
        }

        public string TituloChave
        {
            get
            {
                return tituloChave;
            }

            set
            {
                tituloChave = value;
            }
        }

        public Buscador(DadosBusca parametrosBusca)
        {
            this.nome = parametrosBusca.nomeBusca;
            this.connectionString = String.Format(this.connectionString, parametrosBusca.pathArquivo);
            this.query = String.Format(
                    this.query, 
                    parametrosBusca.nomeTabela, 
                    parametrosBusca.campoChave, 
                    parametrosBusca.campoExibicao1, 
                    parametrosBusca.campoExibicao2
            );
            this.TituloChave = parametrosBusca.tituloCampoChave;
            this.TituloExibicao1 = parametrosBusca.tituloCampoExibicao1;
            this.tituloExibicao2 = parametrosBusca.tituloCampoExibicao2;
        }

        public List<ResultadoBusca> buscar(string valor)
        {
            var resultados = new List<ResultadoBusca>();
            using (OleDbConnection conexao = new OleDbConnection(this.connectionString))
            {
                OleDbCommand comando = new OleDbCommand(this.Query, conexao);
                comando.Parameters.AddWithValue("@valor", valor + "%");

                try
                {
                    conexao.Open();
                    OleDbDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        resultados.Add(new ResultadoBusca{
                            chave = reader[0].ToString(),
                            exibicao1 = reader[1].ToString(),
                            exibicao2 = reader[2].ToString()
                        });
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Não foi possível realizar a consulta." + ex.Message, ex);
                }
            }
            return resultados;
        }

        public bool testarConexao()
        {
            using (OleDbConnection conexao = new OleDbConnection(this.connectionString))
            {
                OleDbCommand comando = new OleDbCommand(this.Query, conexao);
                comando.Parameters.AddWithValue("@valor", "teste");

                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch
                {
                    return false;
                }

            }
            return true;
        }
    }

    public struct ResultadoBusca
    {
        public string chave;
        public string exibicao1;
        public string exibicao2;
    }

    public struct DadosBusca
    {
        public string nomeBusca;
        public string pathArquivo;
        public string nomeTabela;
        public string campoChave;
        public string tituloCampoChave;
        public string campoExibicao1;
        public string tituloCampoExibicao1;
        public string campoExibicao2;
        public string tituloCampoExibicao2;

        public override string ToString()
        {
            return (String.IsNullOrEmpty(nomeBusca)) ? "BUSCA SEM NOME" : nomeBusca;
        }
    }

}
