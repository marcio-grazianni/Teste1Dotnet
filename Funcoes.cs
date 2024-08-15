using System.Globalization;
using System.Text;

namespace Teste1
{
    public class Funcoes
    {
        public static String linhasSepararadoraSimples = "----------------------------------";
        public static String linhasSepararadoraDupla = "==================================";
        /// <summary>
        /// Retorna uma mensagem de boas-vindas para o nome fornecido.
        /// </summary>
        /// <param name="Nome">O nome da pessoa a ser cumprimentada.</param>
        /// <returns>A mensagem de boas-vindas.</returns>
        public static string BemVindo(string Nome)
        {
            return $"Olá {Nome}, seja bem vindo.";
        }

        public static string RemoveAcentos(string text)
        {
            // Normaliza a string, remove os acentos e converte para minúsculas
            return string.Concat(
                text.Normalize(NormalizationForm.FormD)
                    .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
            ).Normalize(NormalizationForm.FormC)
             .ToLowerInvariant();
        }

        public static string LeftStr(string input, int length)
        {
            // Verifica se o comprimento solicitado é maior que a string ou negativo
            if (length <= 0) return string.Empty;
            if (length > input.Length) length = input.Length;

            return input.Substring(0, length);
        }

        public static string RightStr(string input, int length)
        {
            // Verifica se o comprimento solicitado é maior que a string ou negativo
            if (length <= 0) return string.Empty;
            if (length > input.Length) length = input.Length;

            return input.Substring(input.Length - length, length);
        }
    }
}