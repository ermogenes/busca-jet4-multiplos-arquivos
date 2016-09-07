using BuscadorLib;
using System;

namespace BuscadorConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string arquivo2016 = @"path\to\your\file.mdb";
                string BO = "0050/16";

                Buscador b2016 = new Buscador(new DadosBusca
                {
                    pathArquivo = arquivo2016,
                    nomeTabela = "reg",
                    campoChave = "bo",
                    tituloCampoChave = "BO",
                    campoExibicao1 = "id",
                    tituloCampoExibicao1 = "REG",
                    campoExibicao2 = "delegacia",
                    tituloCampoExibicao2 = "DELEGACIA"
                });

                if (b2016.testarConexao()) Console.WriteLine("OK"); else Console.WriteLine("Erro"); ;

                var r2016 = b2016.buscar(BO);

                Console.WriteLine(b2016.Query);
                Console.WriteLine("Buscando em {0}:", arquivo2016);

                r2016.ForEach(r => Console.WriteLine("Encontrado {0}: {1}, {2}", r.chave, r.exibicao1, r.exibicao2));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível buscar: " + ex.Message);
                
            }

            Console.ReadKey();

        }
    }
}
