using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibreriaBusqueda;
using LibreriaBusqueda.algoritmos;
using LibreriaBusqueda.escritores;

namespace AplicacionBusqueda
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string pathColeccion = "C:\\Users\\User\\Downloads\\Tarea programada 1\\man-es";
            string pathStopwords = "";
            string pathIndice = "";

            Database indice = Indexer.IndexarColeccion(pathColeccion, pathStopwords, pathIndice);

            string consulta = "colas de mensajes para la comunicacion entre procesos";

            Indexer.IndexarQuery(consulta, indice);

            Okapi_BM25 bm25 = new Okapi_BM25(indice);

            bm25.CrearEscalafonBM25();

            Vectorial vectorial = new Vectorial(indice);

            vectorial.Compare_Query_Docs();

            string pathEscalafonTexto = "C:\\Users\\davva\\Desktop\\escalafon.txt";
            string pathEscalafonHTML = "C:\\Users\\davva\\Desktop\\escalafon.html";

            EscritorEscalafon escritor = new EscritorEscalafon(indice.Get_doc_info(), bm25.scale, 30);
            escritor.Escribir_Texto(pathEscalafonTexto);
            escritor.Escribir_HTML(pathEscalafonHTML);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
