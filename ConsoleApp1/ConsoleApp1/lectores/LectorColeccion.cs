using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.lectores
{
    class LectorColeccion
    {
        public static Dictionary<string, Document> ObtenerColeccion(string sDir)
        {
            Dictionary<string, Document> coleccionArchivos = new Dictionary<string, Document>();

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
                return new Dictionary<string, Document>();
            }
        }

        private static void AgregarDocumento(string doc, Dictionary<string, Document> coleccion)
        {
            Regex expReg = new Regex(@".+\.[1-8]"); //nombre, punto, cualquier numero del 1 al 8 (ABCD.1 o WXYZ.8)

            string nombreArchivo = Path.GetFileName(doc);

            if (expReg.IsMatch(nombreArchivo))
            {
                string contenidoArchivo = ObtenerContenidoArchivo(doc);
                contenidoArchivo = Scrubber.Limpiar_Raw_Contenido(contenidoArchivo);
                Document documento = new Document(nombreArchivo, contenidoArchivo);

                documento.Set_words_document();
                documento.Set_words(Scrubber.Remove_stopwords(documento.Get_words_document()));

                coleccion.Add(nombreArchivo, documento);
            }
        }

        private static string ObtenerContenidoArchivo(string path)
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