using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.lectores;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();

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

            Dictionary<string, Document> dic_docs = new Dictionary<string, Document>();

            dic_docs.Add(doc1.Get_name(), doc1);
            dic_docs.Add(doc2.Get_name(), doc2);
            dic_docs.Add(doc3.Get_name(), doc3);

            database.Set_terms(dic_docs);

            foreach (var temp in database.Get_terms())
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine("\n");

            database.Set_diccionary();

            Console.WriteLine(database.Get_lenght_dic().ToString());

            Console.ReadKey();
        }
    }
}
