using System.Collections.Generic;
using System.Globalization;
using System.Text;


namespace ConsoleApp1
{
    class Scrubber
    {
        //"C:\\Users\\davva\\Desktop\\RIT_P1\\stopwords"
        //private static List<string> stopwords = LectorStopwords.ObtenerStopwords(PATH_STOPWORDS); 
        //TODO: Cambiar por LectorStopwords
        //Ya esta implementado pero hay que ver como se llega del path que se le pasa
        // a indexer hasta el Scrubber
        private static List<string> stopwords = new List<string>() {"a", "ante", "bajo", "cabe", "con", "contra", "de", "desde", "e",
            "el", "en", "entre", "hacia", "hasta", "ni", "la", "le", "lo", "los", "las", "o", "para", "pero", "por", "que", "segun",
            "sin", "so", "uno", "unas", "unos", "y", "sobre", "tras", "u","un","una"}; 

        public static List<string> Remove_stopwords(List<string> words)
        {
            string[] temp = new string[words.Count];
            words.CopyTo(temp);
            foreach (var word in temp)
            {
                if (stopwords.Contains(word))
                {
                    words.Remove(word);
                }
            }

            return words;
        }

        public static string Limpiar_Raw_Contenido(string contenido)
        {
            string texto_limpio = contenido.ToLowerInvariant();
            texto_limpio = Remove_acentos(texto_limpio);
            texto_limpio = ServiciosRegex.RemoverFormato_Comentarios(texto_limpio);
            texto_limpio = ServiciosRegex.ReemplazarParametros(texto_limpio);

            return texto_limpio;
        }

        private static string Remove_acentos(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
