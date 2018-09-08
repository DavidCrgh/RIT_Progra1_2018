using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBusqueda.lectores
{
    class LectorIndice
    {
        public static Database Leer_Indice(string path)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            Database indice = (Database) formatter.Deserialize(stream);
            stream.Close();

            return indice;
        }
    }
}
