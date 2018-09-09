using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBusqueda
{
    public class Indexer
    {
        public static Database IndexarColeccion(string pathColeccion, string pathStopwords)
        {
            //TODO: pathIndice no es utilizado, hay que crear y llamar a componente que
            // escribe el indice.

            List<Document> coleccion = lectores.LectorColeccion.ObtenerColeccion(pathColeccion);

            Database indice = new Database();
            indice.Set_docs(coleccion);
            indice.Set_terms();
            indice.Set_diccionary();
            indice.Set_words_per_doc();
            indice.Get_appearances_words_per_docs();

            return indice;
        }

        public static void IndexarQuery(string raw_query_text, Database database)
        {
            string query_text = Scrubber.Limpiar_Contenido_Raw(raw_query_text);

            Query query = new Query("query", query_text);

            query.Set_words_query();

            query.Set_words(Scrubber.Remove_stopwords(query.Get_words_query()));

            database.Set_query(query);

            database.Set_query_diccionary();

            database.Set_word_query();
        }
    }
}
