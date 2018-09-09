using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBusqueda
{
    public class Inspector
    {
        private Database indice;

        public Inspector(Database indice)
        {
            this.indice = indice;
        }

        public Dictionary<string, Term> Obtener_Info_Doc(string docName)
        {
            return this.indice.Get_dic_docs_word()[docName];
        }

        public List<string> Obtener_longitud_norma(string docName)
        {
            List<string> datos = new List<string>();
            foreach (var item in this.indice.Get_doc_info())
            {
                if (item.Get_name() == docName)
                {
                    datos.Add(item.Get_size().ToString());
                    datos.Add(item.Get_size().ToString());
                }
            }
            return datos;
        }

        public List<List<string>> Obtener_Info_Termino(string termino)
        {
            Consultado consulado = new Consultado(termino);
            consulado.Set_info_word(this.indice);
            return consulado.Get_info();
        }

        public string Obtener_Info_Extra_Termino(string termino)
        {
            Consultado consulado = new Consultado(termino);
            return consulado.Get_appearance(this.indice);
        }

    }
}