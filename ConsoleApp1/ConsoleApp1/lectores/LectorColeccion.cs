using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.lectores
{
    class LectorColeccion
    {
        public static List<Document> ObtenerColeccion(string sDir)
        {
            List<Document> coleccionArchivos = new List<Document>();

            try
            {
                foreach (string dir in Directory.GetDirectories(sDir))
                {
                    foreach (string archivo in Directory.GetFiles(dir))
                    {
                        AgregarDocumento(archivo, coleccionArchivos);
                    }
                    ObtenerColeccion(dir);
                }
                return coleccionArchivos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Document>;
            }
        }

        private static void AgregarDocumento(string doc, List<Document> coleccion)
        {
            Regex expReg = new Regex(@".+\.[1-8]"); //nombre, punto, cualquier numero del 1 al 8 (ABCD.1 o WXYZ.8)

            string nombreArchivo = Path.GetFileName(doc);

            if (expReg.IsMatch(nombreArchivo))
            {
                string contenidoArchivo = ObtenerContenidoArchivo(doc);
                Document documento = new Document(nombreArchivo, contenidoArchivo);
                coleccion.Add(documento);
            }
        }

        public static string ObtenerContenidoArchivo(string path) //TODO cambiar a private
        {
            string contenidoArchivo;
            using (StreamReader streamReader = new StreamReader(path, Encoding.UTF8))
            {
                contenidoArchivo = streamReader.ReadToEnd();
            }

            // TODO: insertar codigo que "limpia" contenido del archivo (quitar stopwords, comentarios, comandos, etc.)

            return contenidoArchivo;
        }
    }
}
