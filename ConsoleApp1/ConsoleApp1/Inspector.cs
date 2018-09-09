using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Inspector
    {
        private Database indice;

        public Inspector(Database indice)
        {
            this.indice = indice;
        }

        public void Obtener_Info_Doc(string docName)
        {
            Consultado consultado = new Consultado(docName);
            consultado.Set_info_doc(indice.Get_dic_docs_word()[docName]);
            foreach (var item in this.indice.Get_doc_info())
            {
                if (item.Get_name() == docName)
                {
                    consultado.Set_yas_lon(item.Get_size().ToString(), item.Get_yardstick().ToString());
                }
            }
        }

        public void Obtener_Info_Termino(string termino)
        {
            Consultado consultado = new Consultado(termino);
            string doc = indice.Get_dic_docs_word().First().Key;
            consultado.Set_info_word(indice.Get_dic_docs_word()[doc]);
            consultado.Set_appaerances(this.indice.Get_dic_appearances_words()[termino].ToString());
        }
    }
}
