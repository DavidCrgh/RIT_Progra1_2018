using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Query
    {
        private string name = "";
        private string text = "";
        private List<string> words_query = new List<string>();

        public Query(string n, string t)
        {
            this.name = n;
            this.text = t;
        }

        public string Get_name()
        {
            return this.name;
        }

        public string Get_text()
        {
            return this.text;
        }

        public void Set_words_document()
        {
            this.words_query = ServiciosRegex.TokenizarMatches(this.text);
            //this.words_query = this.text.Split(' ').ToList();
        }

        public void Set_words(List<string> list)
        {
            this.words_query = list;
        }

        public List<string> Get_words_document()
        {
            return this.words_query;
        }
    }
}
