using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBusqueda
{
    [Serializable]
    public class Document
    {
        private string name = "";
        private string text = "";
        private List<string> words_document = new List<string>();
        private string path = "";
        private int size = 0;
        private double yardstick = 0;

        public Document(string name, string text)
        {
            this.name = name;
            this.text = text;
        }

        public Document(string n, string t, string p)
        {
            this.name = n;
            this.text = t;
            this.path = p;
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
            this.words_document = ServiciosRegex.TokenizarMatches(this.text);
        }

        public void Set_words(List<string> list)
        {
            this.words_document = list;
        }

        public void Set_size(int s)
        {
            this.size = s;
        }
        public void Set_yardstick(double y)
        {
            this.yardstick = y;
        }
        public double Get_yardstick()
        {
            return this.yardstick;
        }
        public double Get_size()
        {
            return this.size;
        }

        public List<string> Get_words_document()
        {
            return this.words_document;
        }

        public string Get_path()
        {
            return this.path;
        }
    }
}
