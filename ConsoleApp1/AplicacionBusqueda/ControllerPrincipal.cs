using LibreriaBusqueda;
using LibreriaBusqueda.algoritmos;
using LibreriaBusqueda.escritores;
using LibreriaBusqueda.lectores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBusqueda
{
    class ControllerPrincipal
    {
        public string pathIndex { set; get; }
        public string pathCollection { set; get; }
        public string pathStopwords { set; get; }
        private Database indice { set; get; }

        private Okapi_BM25 bm25 = null;
        private Vectorial vectorial = null;

        public ControllerPrincipal()
        {
            this.pathIndex = "";
            this.pathCollection = "";
            this.pathStopwords = "";
            this.indice = null;
        }

        public void Set_index()
        {
            indice = Indexer.IndexarColeccion(this.pathCollection, this.pathStopwords);
        }

        public void Write_index()
        {
            EscritorIndice.Escribir_Indice(this.pathIndex, this.indice);
        }

        public void Read_Index()
        {
            this.indice = LectorIndice.Leer_Indice(this.pathIndex);
        }
    }
}
