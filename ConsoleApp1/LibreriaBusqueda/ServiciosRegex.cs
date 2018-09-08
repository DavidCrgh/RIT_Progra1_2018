using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibreriaBusqueda
{
    public class ServiciosRegex
    {
        public static string RemoverFormato_Comentarios(string texto)
        {
            string patronRegex = @"(^(\.\\"".*|\.[a-zA-Z]+)|\\f[a-zA-Z])";
            return Regex.Replace(texto, patronRegex, "", RegexOptions.Multiline); //Cambia los comentarios e inicios de linea especiales por vacio
        }

        public static string ReemplazarParametros(string texto)
        {
            string patronRegex = @"(\\-){2}";
            return Regex.Replace(texto, patronRegex, "@", RegexOptions.Multiline); //Cambia todos los \-\- por @
        }

        public static List<string> TokenizarMatches(string texto)
        {
            string patronRegex = @"((\d+(\.\d+)*)|@?[a-zA-Z\d]+)";
            MatchCollection matchList = Regex.Matches(texto, patronRegex, RegexOptions.Multiline);
            var listaTerminos = matchList.Cast<Match>().Select(match => match.Value).ToList();

            return listaTerminos;
        }

        public static string Extraer_Descripcion(string texto)
        {
            string patronDescripcion = @"\.SH DESCRIPCI.N(.|\s)*";
            string patronEspacios = @"(\s{2,}|\n)";
            string patron200_Caracteres = @".{1,200}";

            // Buscar si hay descripcion
            Match regex_match = Regex.Match(texto, patronDescripcion);
            string descripcion = "";

            if (regex_match.Success)
            {
                descripcion = regex_match.Value;
                // Quitar formatos
                descripcion = RemoverFormato_Comentarios(descripcion);
                // Reemplazar parametros por @
                descripcion = ReemplazarParametros(descripcion);
                // Reemplazar multiples espacios y cambios de linea por uno solo
                descripcion = Regex.Replace(
                    descripcion,
                    patronEspacios,
                    " ",
                    RegexOptions.Multiline);
                // Cortar max. 200 chars
                descripcion = Regex.Match(descripcion, patron200_Caracteres).Value;
            }
            else
            {
                descripcion = "Sin descripción.";
            }
            
            return descripcion;
        }
    }
}
