using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp1.lectores;

namespace ConsoleApp1.escritores
{
    class EscritorEscalafon
    {
        private List<Document> Documentos { set; get; }

        public EscritorEscalafon(List<Document> documentos)
        {
            this.Documentos = documentos;
        }

        public void Escribir_Binario()
        {

        }

        public void Escribir_HTML()
        {

        }

        private string ObtenerDescripcion(string docName)
        {
            Document documento = Documentos.Find(x => x.Get_name() == docName);
            string contenido_raw = LectorColeccion.ObtenerContenidoArchivo_Raw(documento.Get_path());

            return ServiciosRegex.Extraer_Descripcion(contenido_raw);
        }
    }
}
