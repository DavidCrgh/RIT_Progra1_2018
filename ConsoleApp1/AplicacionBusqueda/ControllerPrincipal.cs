﻿using LibreriaBusqueda;
using LibreriaBusqueda.algoritmos;
using LibreriaBusqueda.escritores;
using LibreriaBusqueda.lectores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBusqueda.lectores;

namespace AplicacionBusqueda
{
    class ControllerPrincipal
    {
        public string pathIndex { set; get; }
        public string pathCollection { set; get; }
        public string pathStopwords { set; get; }
        public string pathEscalafon { set; get; }
        public string pathHTML { set; get; }
        public int numDocs { set; get; }
        private Database indice { set; get; }

        public Okapi_BM25 bm25 = null;
        public Vectorial vectorial = null;

        public ControllerPrincipal()
        {
            this.pathIndex = "";
            this.pathCollection = "";
            this.pathStopwords = "";
            this.indice = null;
        }

        public void Indexar_Consulta(string consulta)
        {
            Indexer.IndexarQuery(consulta, this.indice);
        }

        public void Inicializar_Vectorial()
        {
            this.vectorial = new Vectorial(this.indice);
            this.vectorial.Compare_Query_Docs();
        }

        public void Escribir_Escalafon_Vectorial()
        {
            EscritorEscalafon escritor = new EscritorEscalafon(
                indice.Get_doc_info(),
                vectorial.scale,
                numDocs
                );
            escritor.Escribir_Texto(pathEscalafon);
            escritor.Escribir_HTML(pathHTML);
        }

        public void Inicializar_BM25()
        {
            this.bm25 = new Okapi_BM25(this.indice);
            this.bm25.CrearEscalafonBM25();
        }

        public void Escribir_Escalafon_BM25()
        {
            EscritorEscalafon escritor = new EscritorEscalafon(
                indice.Get_doc_info(),
                bm25.scale,
                numDocs
                );
            escritor.Escribir_Texto(pathEscalafon);
            escritor.Escribir_HTML(pathHTML);
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
