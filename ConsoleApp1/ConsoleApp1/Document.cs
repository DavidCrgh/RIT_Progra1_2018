using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Document
    {
        private string name = "";
        private string text = "";
        private List<string> words_document = new List<string>();

        public Document(string n, string t)
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
            string contenido = this.text;
            contenido = ServiciosRegex.RemoverFormato_Comentarios(contenido);
            contenido = ServiciosRegex.ReemplazarParametros(contenido);
            this.words_document = ServiciosRegex.TokenizarMatches(contenido);
            //this.words_document = this.text.Split(' ').ToList();
        }

        public void Set_words(List<string> list)
        {
            this.words_document = list;
        }

        public List<string> Get_words_document()
        {
            return this.words_document;
        }
    }
}
