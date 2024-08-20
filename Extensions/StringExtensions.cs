using System.Globalization;
using System.Text;

namespace App.Extensions
{
    public static class StringExtensions
    {
        public static string Esquerda(this string input, int length)
        {
            // Verifica se o comprimento solicitado é maior que a string ou negativo
            if (length <= 0) return string.Empty;
            if (length > input.Length) length = input.Length;

            return input.Substring(0, length);
        }

        public static string Direita(this string input, int length)
        {
            // Verifica se o comprimento solicitado é maior que a string ou negativo
            if (length <= 0) return string.Empty;
            if (length > input.Length) length = input.Length;

            return input.Substring(input.Length - length, length);
        }

        public static string RemoveAcentos(this string text)
        {
            // Normaliza a string, remove os acentos e converte para minúsculas
            return string.Concat(
                text.Normalize(NormalizationForm.FormD)
                    .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
            ).Normalize(NormalizationForm.FormC)
             .ToLowerInvariant();
        }
    }
}