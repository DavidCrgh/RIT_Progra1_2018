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
            string pathColeccion = "C:\\Users\\User\\Downloads\\Tarea programada 1\\man-es";
            string pathStopwords = "";
            string pathIndice = "";

            Database indice = Indexer.IndexarColeccion(pathColeccion, pathStopwords, pathIndice);

            string consulta = "colas de mensajes para la comunicacion entre procesos";

            Indexer.IndexarQuery(consulta, indice);

            Vectorial vectorial = new Vectorial();

            /*vectorial.Set_dic(indice.Get_dic_docs_word());

            vectorial.Set_dic_appearances(indice.Get_dic_appearances_words());

            vectorial.algorithm();
            
            vectorial.Set_dic_query(indice.Get_dic_query());

            vectorial.Apply_algo_query();

            vectorial.Make_Scale();

            vectorial.scale.print_Scale();*/

            //Okapi_BM25 bm25 = new Okapi_BM25(indice);

            //bm25.CrearEscalafonBM25();
          
            Console.ReadKey();
        }
    }
}
