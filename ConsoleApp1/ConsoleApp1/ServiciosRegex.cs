using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ServiciosRegex
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
    }
}
