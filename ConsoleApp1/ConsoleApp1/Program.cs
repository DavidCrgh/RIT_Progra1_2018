using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp1.lectores;
using ConsoleApp1.escritores;
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

<<<<<<< HEAD
            vectorial.scale.print_Scale();*/

            //Okapi_BM25 bm25 = new Okapi_BM25(indice);
=======
            //vectorial.scale.print_Scale();

            /*string pathArchivo = Console.ReadLine();
            string contenido = LectorColeccion.ObtenerContenidoArchivo_Raw(pathArchivo);

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

            string pathColeccion = "C:\\Users\\davva\\Desktop\\RIT_P1\\man-es";
            string pathStopwords = "";
            string pathIndice = "";

            Database indice = Indexer.IndexarColeccion(pathColeccion, pathStopwords, pathIndice);

            string consulta = "segmentos de memoria compartida";

            Indexer.IndexarQuery(consulta, indice);

            Okapi_BM25 bm25 = new Okapi_BM25(indice);

            bm25.CrearEscalafonBM25();

            string pathEscalafonTexto = "C:\\Users\\davva\\Desktop\\escalafon.txt";
            string pathEscalafonHTML = "C:\\Users\\davva\\Desktop\\escalafon.html";

            EscritorEscalafon escritor = new EscritorEscalafon(indice.Get_doc_info(), bm25.scale, 30);
            escritor.Escribir_Texto(pathEscalafonTexto);
            escritor.Escribir_HTML(pathEscalafonHTML);
>>>>>>> 64238337da80a6c8e90895b04b1d6d4b8667da6a

            //bm25.CrearEscalafonBM25();
          
            Console.ReadKey();
        }
    }
}
