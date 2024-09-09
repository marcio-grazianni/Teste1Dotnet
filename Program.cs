using System.Numerics;

namespace Teste1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(Funcoes.linhasSepararadoraDupla);

            Console.WriteLine();

            Console.WriteLine("Testando funções em outro arquivo");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            string hello = Funcoes.BemVindo("Marcio");
            Console.WriteLine(hello);

            Console.WriteLine();

            Console.WriteLine("Testando foreach em args");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            Console.WriteLine();

            Console.WriteLine("Arrays");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            var textos_array = new string[2];
            textos_array[0] = "Marcio";
            textos_array[1] = "Grazianni";
            foreach (string texto in textos_array)
            {
                Console.WriteLine(texto);
            }

            Console.WriteLine();

            Console.WriteLine("Listas");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            var textosLista = new List<string>();
            textosLista.Add("Grazianni");
            textosLista.Add("Oliveira");
            foreach (string texto in textosLista)
            {
                Console.WriteLine(texto);
            }

            Console.WriteLine();

            Console.WriteLine("Dicionários");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            var textosDict = new Dictionary<string, object>
            {
                { "nome", "Marcio" },
                { "idade", 46 },
                { "cidade", "Salvador" }
            };

            // Acessando valores
            Console.WriteLine($"Nome: {textosDict["nome"]}");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);

            // Adicionando um novo par chave-valor
            textosDict["country"] = "Brazil";

            // Iterando sobre o dicionário
            foreach (var chaveValor in textosDict)
            {
                Console.WriteLine($"{chaveValor.Key}: {chaveValor.Value}");
            }

            Console.WriteLine();

            Console.WriteLine("Testando null");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            string? nome = null;
            if (nome is null)
            {
                Console.WriteLine("Nome nulo");
            }
            else
            {
                Console.WriteLine($"Nome: {nome}");
            }

            Console.WriteLine();

            Console.WriteLine("Testando GetType");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            string nomeCliente = "Marcio";
            int idadeCliente = 46;
            Console.WriteLine($"nomeCliente.GetType(): {nomeCliente.GetType()}");
            Console.WriteLine($"idadeCliente.GetType(): {idadeCliente.GetType()}");

            Console.WriteLine();

            Console.WriteLine("Testando Screen");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            var alturaConsole = Console.WindowHeight;
            var larguraConsole = Console.WindowWidth;
            Console.WriteLine($"Altura: {alturaConsole}   Largura: {larguraConsole}");

            Console.WriteLine();

            Console.WriteLine("Testando Guid");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            var id = Guid.NewGuid();
            Console.WriteLine($"Guid id: {id}");

            Console.WriteLine();

            Console.WriteLine("Testando Múltiplas Linhas");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            var sql01 = """
                SELECT
                    *
                FROM
                    produto
            """;
            Console.WriteLine(sql01);

            Console.WriteLine();

            Console.WriteLine("Testando Extended Extensions - Contains");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            var texto1 = "Meu nome é Márcio";
            var texto2 = "mARçíõ";
            Console.WriteLine(texto1);
            Console.WriteLine("texto1.RemoveAcentos()");
            Console.WriteLine(texto1.RemoveAcentos());
            Console.WriteLine(texto2);
            Console.WriteLine("texto1.RemoveAcentos().Contains(texto2.RemoveAcentos())");
            Console.WriteLine(texto1.RemoveAcentos().Contains(texto2.RemoveAcentos()));

            Console.WriteLine();

            Console.WriteLine("Testando Extended Extensions - Esquerda e Direita");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            string texto3 = "Marcio Grazianni";
            string esquerdaTexto3 = texto3.Esquerda(6);
            string direitaTexto3 = texto3.Direita(9);

            Console.WriteLine(texto3);
            Console.WriteLine($"texto3.Esquerda(6): {esquerdaTexto3}");
            Console.WriteLine($"texto3.Direita(9): {direitaTexto3}");

            Console.WriteLine();

            string nomeArquivoTeste = "Teste.txt";
            Console.WriteLine($"Testando Gravação de arquivo - {nomeArquivoTeste}");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            using (var arquivo = new StreamWriter(nomeArquivoTeste))
            {
                arquivo.WriteLine("Marcio");
                arquivo.WriteLine("Grazianni");
                arquivo.WriteLine("");
                arquivo.WriteLine("");
                arquivo.WriteLine("Mascarenhas");
                arquivo.WriteLine("Oliveira");
                arquivo.WriteLine("");
            }
            Console.WriteLine($"Arquivo {nomeArquivoTeste} gravado com sucesso.");

            Console.WriteLine();

            Console.WriteLine($"Testando Leitura de arquivo - {nomeArquivoTeste}");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            int numeroLinha = 1;
            string? conteudoLinha = null;
            using (var arquivo = new StreamReader(nomeArquivoTeste))
            {
                while ((conteudoLinha = arquivo.ReadLine()) != null)
                {
                    if (conteudoLinha.Trim().Length == 0)
                        continue;

                    Console.WriteLine($"Linha {numeroLinha}: [{conteudoLinha}]");
                    numeroLinha++;
                }
            }
            Console.WriteLine($"Arquivo {nomeArquivoTeste} lido com sucesso.");

            return 0;
        }
    }
}