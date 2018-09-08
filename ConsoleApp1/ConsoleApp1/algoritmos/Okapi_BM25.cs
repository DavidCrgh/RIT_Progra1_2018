using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.algoritmos
{
    class Okapi_BM25
    {
        private Database indice;
        private Dictionary<string, int> doc_lengths; // lista de |D|'s, sirve para calcular avgdl
        private double avgdl; // promedio de |D|'s
        private const double K = 1.2; // parametro de funcion de similitud (valor default)
        private const double B = 0.75; // parametro de funcion de similitud (valor default)
        public Scale scale { get; }

        public Okapi_BM25(Database indice)
        {
            this.indice = indice;
            doc_lengths = new Dictionary<string, int>();
            avgdl = 0.0;
            scale = new Scale();
        }

        public void CrearEscalafonBM25()
        {
            List<string> terms_consulta = indice.Get_Query().Get_words_query();

            Calcular_avgdl();

            double sim_D_Q;
            string doc_name;

            foreach (Document doc in indice.Get_doc_info())
            {
                doc_name = doc.Get_name();
                sim_D_Q = 0.0;

                foreach (string qi in terms_consulta)
                {
                    if (Validar_Termino_IDF(qi))
                    {
                        sim_D_Q += Calcular_Peso_qi(doc_name, qi);
                    }
                }
                scale.Add_scale(doc_name, sim_D_Q);
            }
            scale.Sort();
            scale.print_Scale(); //TODO: Quitar
        }

        /**
         * Calcular_Peso_qi: funcion de similitud del modelo Okapi BM25
         */
        public double Calcular_Peso_qi(string doc, string qi)
        {
            double frecuencia_qi = Calcular_F_qi_D(qi, doc);
            double doc_length = doc_lengths[doc];

            double dl_entre_avgdl = doc_length / avgdl;

            double numerador = frecuencia_qi * (K + 1);
            double denominador = frecuencia_qi + K * (1 - B + B * dl_entre_avgdl);

            double IDF_qi = Calcular_IDF_qi(qi);

            Guardar_IDF(IDF_qi, doc, qi);

            return IDF_qi * (numerador / denominador);
        }

        /**
         * Calcular_F_qi_D: obtiene la frecuencia f(qi, D) para un termino en un documento
         * Se accede a la matriz de ocurrencias (words_per_doc) del indice.
         */
        private int Calcular_F_qi_D(string termino, string documento)
        {
            return indice.Get_dic_docs_word()[documento][termino].Get_appearance();
        }

        /**
         * Calcular_avgdl: calcula cada |D| de la coleccion y los guarda en un diccionario;
         * despues obtiene el promedio de los D y lo guarda en memoria (avgdl).
         */
        private void Calcular_avgdl()
        {
            foreach (Document doc in indice.Get_doc_info())
            {
                string doc_name = doc.Get_name();
                int D = Calcular_doc_length(doc_name);

                doc_lengths.Add(doc_name, D);
            }

            avgdl = doc_lengths.Values.Average();
        }

        /**
         * Calcular_D: calcula la longitud (|D|) de un documento dado por su nombre.
         * La longitud de un documento es la suma de las frecuencias de sus terminos.
         */
        private int Calcular_doc_length(string documento)
        {
            int doc_length = 0;
            Dictionary<string, Term> doc_terms = indice.Get_dic_docs_word()[documento];

            foreach(KeyValuePair<string, Term> entry in doc_terms)
            {
                doc_length += entry.Value.Get_appearance();
            }

            return doc_length;
        }

        /**
         * Calcular_IDF_qi: obtiene el inverse document frequency (IDF) para un termino
         */
        private double Calcular_IDF_qi(string termino)
        {
            double N = indice.Get_doc_info().Count;
            double n_qi = indice.Get_dic_appearances_words()[termino]; 

            double numerador_log = N - n_qi + 0.5;
            double denominador_log = n_qi + 0.5;

            double idf_qi = Math.Log(numerador_log / denominador_log, 10); // log base 10

            return idf_qi;
        }

        /**
         * Validar_Termino_IDF: verificar si un termino aparece en mas de la mitad de los documentos
         */
        private bool Validar_Termino_IDF(string termino)
        {
            double N = indice.Get_doc_info().Count;
            double n_qi = indice.Get_dic_appearances_words()[termino];

            return (N/2) > n_qi;
        }

        /**
         * Guardar_IDF: guarda el IDF del termino en el indice
         */
        private void Guardar_IDF(double idf, string doc, string term)
        {
            indice.Get_dic_docs_word()[doc][term].Set_bm25(idf);
        }

    }
}
