using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Indexer
    {
        public static Database Indexar(string pathColeccion, string pathStopwords, string pathIndice)
        {
            //TODO: pathIndice no es utilizado, hay que crear y llamar a componente que
            // escribe el indice.

            Dictionary<string, Document> coleccion = lectores.LectorColeccion.ObtenerColeccion(pathColeccion);

            Database terminos_coleccion = new Database();
            terminos_coleccion.Set_terms(coleccion);
            terminos_coleccion.Set_diccionary();
            terminos_coleccion.Set_words_per_doc();

            return terminos_coleccion;
        }
    }
}
