namespace Teste1
{
    public class Funcoes
    {
        public static String linhasSepararadoraSimples = "--------------------------------------------------------------------";
        public static String linhasSepararadoraDupla = "====================================================================";
        /// <summary>
        /// Retorna uma mensagem de boas-vindas para o nome fornecido.
        /// </summary>
        /// <param name="Nome">O nome da pessoa a ser cumprimentada.</param>
        /// <returns>A mensagem de boas-vindas.</returns>
        public static string BemVindo(string Nome)
        {
            return $"Olá {Nome}, seja bem vindo.";
        }
    }
}