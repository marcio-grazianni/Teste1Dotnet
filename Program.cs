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
            string[] textos_array = new string[2];
            textos_array[0] = "Marcio";
            textos_array[1] = "Grazianni";
            foreach (string texto in textos_array)
            {
                Console.WriteLine(texto);
            }

            Console.WriteLine();

            Console.WriteLine("Listas");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            List<string> textos_lista = new();
            textos_lista.Add("Grazianni");
            textos_lista.Add("Oliveira");
            foreach (string texto in textos_lista)
            {
                Console.WriteLine(texto);
            }

            Console.WriteLine();

            Console.WriteLine("Dicionários");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            Dictionary<string, object> textos_dict = new Dictionary<string, object>
            {
                { "nome", "Marcio" },
                { "idade", 46 },
                { "cidade", "Salvador" }
            };

            // Acessando valores
            Console.WriteLine($"Nome: {textos_dict["nome"]}");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);

            // Adicionando um novo par chave-valor
            textos_dict["country"] = "Brazil";

            // Iterando sobre o dicionário
            foreach (KeyValuePair<string, object> kvp in textos_dict)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
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
            string nome_cliente = "Marcio";
            int idade_cliente = 46;
            Console.WriteLine($"nome_cliente.GetType(): {nome_cliente.GetType()}");
            Console.WriteLine($"idade_cliente.GetType(): {idade_cliente.GetType()}");

            Console.WriteLine();

            Console.WriteLine("Testando Screen");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            int alturaConsole = Console.WindowHeight;
            int larguraConsole = Console.WindowWidth;
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

            Console.WriteLine("Testando Contains");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            var texto1 = "Meu nome é Márcio";
            var texto2 = "marcio";
            Console.WriteLine(texto1);
            Console.WriteLine("Funcoes.RemoveAcentos(texto1)");
            Console.WriteLine(Funcoes.RemoveAcentos(texto1));
            Console.WriteLine(texto2);
            Console.WriteLine("Funcoes.RemoveAcentos(texto1).Contains(texto2, StringComparison.OrdinalIgnoreCase)");
            Console.WriteLine(Funcoes.RemoveAcentos(texto1).Contains(texto2, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine();

            Console.WriteLine("Testando LeftStr e RightStr");
            Console.WriteLine(Funcoes.linhasSepararadoraSimples);
            string texto3 = "Marcio Grazianni";
            string leftPart = Funcoes.LeftStr(texto3, 6);
            string rightPart = Funcoes.RightStr(texto3, 9);

            Console.WriteLine(texto3);
            Console.WriteLine($"Funcoes.LeftStr 6: {leftPart}");
            Console.WriteLine($"Funcoes.RightStr 9: {rightPart}");

            return 0;
        }
    }
}