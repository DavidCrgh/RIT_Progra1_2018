using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace LibreriaBusqueda.lectores
{
    public class LectorColeccion
    {
        public static List<Document> ObtenerColeccion(string sDir)
        {
            List<Document> coleccionArchivos = new List<Document>();

            try
            {
                foreach (string directorio in Directory.GetDirectories(sDir))
                {
                    foreach (string archivo in Directory.GetFiles(directorio))
                    {
                        AgregarDocumento(archivo, coleccionArchivos);
                    }
                    ObtenerColeccion(directorio);
                }

                return coleccionArchivos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Document>();
            }
        }

        private static void AgregarDocumento(string doc, List<Document> coleccion)
        {
            Regex expReg = new Regex(@".+\.[1-8]"); //nombre, punto, cualquier numero del 1 al 8 (ABCD.1 o WXYZ.8)

            string nombreArchivo = Path.GetFileName(doc);

            if (expReg.IsMatch(nombreArchivo))
            {
                string contenidoArchivo = ObtenerContenidoArchivo_Raw(doc);
                contenidoArchivo = Scrubber.Limpiar_Contenido_Raw(contenidoArchivo);
                Document documento = new Document(nombreArchivo, contenidoArchivo, doc);

                documento.Set_words_document();
                documento.Set_words(Scrubber.Remove_stopwords(documento.Get_words_document()));

                coleccion.Add(documento);
            }
        }

        public static string ObtenerContenidoArchivo_Raw(string path)
        {
            string contenidoArchivo;
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                contenidoArchivo = streamReader.ReadToEnd();
            }

            return contenidoArchivo;
        }
    }
}