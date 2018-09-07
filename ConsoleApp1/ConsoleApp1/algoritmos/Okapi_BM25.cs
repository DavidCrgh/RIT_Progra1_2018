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
        private double k; // parametro de funcion de similitud
        private double b; // parametro de funcion de similitud

        public Okapi_BM25(Database indice)
        {
            this.indice = indice;
            doc_lengths = new Dictionary<string, int>();
            avgdl = 0.0;
            k = 1.2; // valor default segun especificacion
            b = 0.75; // valor default segun especificacion
        }

        public void CrearEscalafonBM25()
        {
            List<string> terms_consulta = new List<string>(); //TODO mecanismo para procesar consulta en lista de terminos

            Calcular_avgdl();

            foreach(Document doc in indice.Get_doc_info())
            {
                string doc_name = doc.Get_name();

                foreach (string qi in terms_consulta)
                {
                    double sim_D_Q = Calcular_sim_D_Q(doc_name, qi);
                }
            }
        }

        /**
         * Calcular_sim_D_Q: funcion de similitud del modelo Okapi BM25
         */
        public double Calcular_sim_D_Q(string doc, string qi)
        {
            int frecuencia_qi = Calcular_F_qi_D(qi, doc);
            int doc_length = doc_lengths[doc];

            double dl_entre_avgdl = doc_length / avgdl;

            double numerador = frecuencia_qi * (k + 1);
            double denominador = frecuencia_qi + k * (1 - b + b * dl_entre_avgdl);

            double IDF_qi = Calcular_IDF_qi(qi);

            return IDF_qi * (numerador / denominador);
        }

        /**
         * Calcular_F_qi_D: obtiene la frecuencia f(qi, D) para un termino en un documento
         * Se accede a la matriz de ocurrencias (words_per_doc) del indice.
         */
        public int Calcular_F_qi_D(string termino, string documento) //TODO: pasar a private
        {
            return indice.Get_dic_docs_word()[documento][termino].Get_appearance();
        }

        /**
         * Calcular_avgdl: calcula cada |D| de la coleccion y los guarda en un diccionario;
         * despues obtiene el promedio de los D y lo guarda en memoria (avgdl).
         */
        public void Calcular_avgdl() //TODO: pasar a private
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
            int N = indice.Get_doc_info().Count;
            int n_qi = 0; //TODO obtener n_qi de term_info en indice.

            double numerador_log = N - n_qi + 0.5;
            double denominador_log = n_qi + 0.5;

            double idf_qi = Math.Log(numerador_log / denominador_log, 10); // log base 10

            return 0.0;
        }

    }
}
