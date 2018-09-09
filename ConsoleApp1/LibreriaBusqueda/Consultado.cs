using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBusqueda
{
    class Consultado
    {
        private string name = "";
        private List<List<string>> info = new List<List<string>>();
        public Consultado(string n)
        {
            this.name = n;
        }

        //documento
        public void Set_info_doc(Dictionary<string, Term> words)
        {
            List<string> values = new List<string>();
            foreach (var word in words.Keys)
            {
                values.Add(word);
                values.Add(words[word].Get_appearance().ToString());
                values.Add(words[word].Get_vectorial().ToString());
                values.Add(words[word].Get_vec().ToString());
                values.Add(words[word].Get_bm25().ToString());
            }
            this.info.Add(values);
        }
        //termino
        public void Set_info_word(Dictionary<string, Term> words)
        {
            List<string> values = new List<string>();
            foreach (var word in words.Values)
            {
                values.Add(word.Get_vec().ToString());
                values.Add(word.Get_bm25().ToString());
            }
            this.info.Add(values);
        }
        public void Set_yas_lon(string lon, string yas)
        {
            List<string> extra = new List<string>();
            extra.Add(lon);
            extra.Add(yas);
            this.info.Add(extra);
        }
        public void Set_appaerances(string appear)
        {
            List<string> extra = new List<string>();
            extra.Add(appear);
            this.info.Add(extra);
        }
        public List<List<string>> Get_info()
        {
            return this.info;
        }
    }
}
