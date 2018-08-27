using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Scrubber
    {
        //"C:\\Users\\davva\\Desktop\\RIT_P1\\stopwords"
        //private static List<string> stopwords = LectorStopwords.ObtenerStopwords(PATH_STOPWORDS); 
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
    }
}
