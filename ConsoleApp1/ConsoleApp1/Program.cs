using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.lectores;
using ConsoleApp1.algoritmos;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            Vectorial vectorial = new Vectorial();

            string text1 = "Costa Rica denominada oficialmente República de Costa Rica" +
                " es una nación soberana organizada como una república presidencialista unitaria compuesta por 7 provincias";
            string text2 = "Ubicada en América Central posee un territorio con un área" +
                " total de 51100 km² Limita con Nicaragua al norte el mar Caribe al este Panamá al sureste y el océano Pacífico al oeste";
            string text3 = "En cuanto a los límites marítimos colinda con Panamá Nicaragua Colombia y Ecuador";

            Document doc1 = new Document("doc1", text1.ToLower());
            Document doc2 = new Document("doc2", text2.ToLower());
            Document doc3 = new Document("doc3", text3.ToLower());

            doc1.Set_words_document();
            doc2.Set_words_document();
            doc3.Set_words_document();

            doc1.Set_words(Scrubber.Remove_stopwords(doc1.Get_words_document()));
            doc2.Set_words(Scrubber.Remove_stopwords(doc2.Get_words_document()));
            doc3.Set_words(Scrubber.Remove_stopwords(doc3.Get_words_document()));

            List<Document> list_docs = new List<Document>();

            list_docs.Add(doc1);
            list_docs.Add(doc2);
            list_docs.Add(doc3);

            database.Set_docs(list_docs);

            database.Set_terms();

            database.Set_diccionary();

            database.Set_words_per_doc();

            database.Get_appearances_words_per_docs();

            vectorial.Set_dic(database.Get_dic_docs_word());

            vectorial.Set_dic_appearances(database.Get_dic_appearances_words());

            vectorial.algorithm();

            string query_text = Console.ReadLine();

            Query query = new Query("query",query_text.ToLower());

            query.Set_words_document();

            query.Set_words(Scrubber.Remove_stopwords(query.Get_words_document()));



            /*string pathArchivo = Console.ReadLine();
            string contenido = LectorColeccion.ObtenerContenidoArchivo(pathArchivo);

            contenido = ServiciosRegex.RemoverFormato_Comentarios(contenido);
            contenido = ServiciosRegex.ReemplazarParametros(contenido);
            contenido = Scrubber.Remove_acentos(contenido);

            var listaTerminos = ServiciosRegex.TokenizarMatches(contenido);

            Console.WriteLine(contenido);
            Console.WriteLine("\nlistaTerminos=");
            foreach(var t in listaTerminos)
            {
                Console.WriteLine(t);
            }*/

            Console.ReadKey();
        }
    }
}
