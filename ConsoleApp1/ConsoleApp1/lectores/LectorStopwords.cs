﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lectores
{
    class LectorStopwords
    {
        public static List<string> ObtenerStopwords(string sDir)
        {
            var archivoStopwords = File.ReadAllLines(sDir);
            var stopwords = new List<string>(archivoStopwords);

            return stopwords;
        }
    }
}
