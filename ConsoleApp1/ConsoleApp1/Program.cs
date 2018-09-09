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

            /*Okapi_BM25 bm25 = new Okapi_BM25(indice);

            bm25.CrearEscalafonBM25();*/

            Vectorial vectorial = new Vectorial(indice);

            vectorial.Compare_Query_Docs();

            /*string pathEscalafonTexto = "C:\\Users\\davva\\Desktop\\escalafon.txt";
            string pathEscalafonHTML = "C:\\Users\\davva\\Desktop\\escalafon.html";

            EscritorEscalafon escritor = new EscritorEscalafon(indice.Get_doc_info(), bm25.scale, 30);
            escritor.Escribir_Texto(pathEscalafonTexto);
            escritor.Escribir_HTML(pathEscalafonHTML);*/

            //bm25.CrearEscalafonBM25();
          
            Console.ReadKey();
        }
    }
}
