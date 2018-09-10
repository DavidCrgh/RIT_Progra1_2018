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

        //termino
        public void Set_info_word(Database indice)
        {
            
            foreach (var doc in indice.Get_dic_docs_word().Keys)
            {
                List<string> values = new List<string>();
                values.Add(doc);
                values.Add(indice.Get_dic_docs_word()[doc][this.name].Get_appearance().ToString());
                values.Add(indice.Get_dic_docs_word()[doc][this.name].Get_vec().ToString());
                values.Add(indice.Get_dic_docs_word()[doc][this.name].Get_bm25().ToString());
                this.info.Add(values); 
            }
        }

        public string Get_appearance(Database indice)
        {
            return indice.Get_dic_appearances_words()[this.name].ToString();
        }

        public List<List<string>> Get_info()
        {
            return this.info;
        }
    }
}
