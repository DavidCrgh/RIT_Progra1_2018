using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp1.lectores
{
    class LectorColeccion
    {
        public static Dictionary<string, string> ObtenerColeccion(string sDir)
        {
            Dictionary<string, string> coleccionArchivos = new Dictionary<string, string>();

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
                return new Dictionary<string, string>();
            }
        }

        private static void AgregarDocumento(string doc, Dictionary<string, string> coleccion)
        {
            Regex expReg = new Regex(@".+\.[1-8]"); //nombre, punto, cualquier numero del 1 al 8 (ABCD.1 o WXYZ.8)

            string nombreArchivo = Path.GetFileName(doc);

            if (expReg.IsMatch(nombreArchivo))
            {
                string contenidoArchivo = ObtenerContenidoArchivo(doc);
                coleccion.Add(nombreArchivo, contenidoArchivo);
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
