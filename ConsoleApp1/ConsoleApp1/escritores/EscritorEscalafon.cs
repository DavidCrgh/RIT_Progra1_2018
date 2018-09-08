using System;
using System.IO;
using System.Web.UI;
using System.Collections.Generic;

using ConsoleApp1.lectores;

namespace ConsoleApp1.escritores
{
    class EscritorEscalafon
    {
        private List<Document> Documentos { set; get; }
        private Scale escalafon { set; get; }
        private int maxDocs { set; get; } //Numero de documentos mostrado

        public EscritorEscalafon(List<Document> documentos, Scale escalafon, int maxDocs)
        {
            this.Documentos = documentos;
            this.escalafon = escalafon;
            this.maxDocs = maxDocs;
        }

        public void Escribir_Texto(string path)
        {
            string texto = "";
            int pos = 1;

            foreach(KeyValuePair<string, double> entry in escalafon.Get_scale())
            {
                if (pos > maxDocs)
                    break;

                texto += pos + "\t";
                texto += entry.Key + "\t";
                texto += entry.Value + "\r\n";

                pos++;
            }

            File.WriteAllText(path, texto);
        }

        public void Escribir_HTML(string path)
        {
            StringWriter stringWriter = new StringWriter();

            using(HtmlTextWriter escritorHTML = new HtmlTextWriter(stringWriter))
            {
                escritorHTML.Write("<!DOCTYPE html>");
                escritorHTML.RenderBeginTag(HtmlTextWriterTag.Html);

                Escribir_Encabezado_HTML(escritorHTML);
                Escribir_Cuerpo_HTML(escritorHTML);

                escritorHTML.RenderEndTag(); //</html>
            }
            string html = stringWriter.ToString();
            File.WriteAllText(path, html);
        }

        private void Escribir_Encabezado_HTML(HtmlTextWriter escritorHTML)
        {
            escritorHTML.RenderBeginTag(HtmlTextWriterTag.Head);
            escritorHTML.RenderBeginTag(HtmlTextWriterTag.Style);
            escritorHTML.RenderEndTag(); //</style>
            escritorHTML.RenderEndTag(); //</head>
        }

        private void Escribir_Cuerpo_HTML(HtmlTextWriter escritorHTML)
        {
            string[] encabezados_tabla = {"Posición", "Documento", "Similitud", "Descripción"};


            escritorHTML.RenderBeginTag(HtmlTextWriterTag.Body);

            escritorHTML.RenderBeginTag(HtmlTextWriterTag.H2);
            escritorHTML.Write("Escalafón");
            escritorHTML.RenderEndTag(); //</h2>

            escritorHTML.RenderBeginTag(HtmlTextWriterTag.Table);
            escritorHTML.RenderBeginTag(HtmlTextWriterTag.Tr);

            foreach(string encabezado in encabezados_tabla)
            {
                escritorHTML.RenderBeginTag(HtmlTextWriterTag.Th);
                escritorHTML.Write(encabezado);
                escritorHTML.RenderEndTag();
            }

            escritorHTML.RenderEndTag(); //</tr>

            //Iterar sobre scale
            int pos = 1;
            string doc_name_actual;
            
            foreach (KeyValuePair<string, double> entry in escalafon.Get_scale())
            {
                if (pos > maxDocs)
                    break;

                doc_name_actual = entry.Key;

                escritorHTML.RenderBeginTag(HtmlTextWriterTag.Tr);

                Escribir_Fila_Tabla_HTML(pos.ToString(), escritorHTML);
                Escribir_Fila_Tabla_HTML(doc_name_actual, escritorHTML);
                Escribir_Fila_Tabla_HTML(entry.Value.ToString(), escritorHTML);
                Escribir_Fila_Tabla_HTML(ObtenerDescripcion(doc_name_actual), escritorHTML);

                escritorHTML.RenderEndTag(); //</tr>

                pos++;
            }
            ////////////////////

            escritorHTML.RenderEndTag(); //</table>

            escritorHTML.RenderEndTag(); //</body>
        }

        private void Escribir_Fila_Tabla_HTML(string valor, HtmlTextWriter escritorHTML)
        {
            escritorHTML.RenderBeginTag(HtmlTextWriterTag.Td);
            escritorHTML.Write(valor);
            escritorHTML.RenderEndTag(); //</td>
        }

        private string ObtenerDescripcion(string docName)
        {
            Document documento = Documentos.Find(x => x.Get_name() == docName);
            string contenido_raw = LectorColeccion.ObtenerContenidoArchivo_Raw(documento.Get_path());

            return ServiciosRegex.Extraer_Descripcion(contenido_raw);
        }
    }
}
