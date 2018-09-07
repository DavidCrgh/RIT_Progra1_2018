using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.escritores
{
    class EscritorHTML
    {
        private List<Document> documentos { set; get; }

        public EscritorHTML(List<Document> documentos)
        {
            this.documentos = documentos;
        }

        private string ObtenerDescripcion(string docName)
        {
            Document documento = documentos.Find(x => x.Get_name() == docName);
            string descripcion = lectores.LectorColeccion.ObtenerContenidoArchivo_Raw(documento.)
            return descripcion;
        }
    }
}
