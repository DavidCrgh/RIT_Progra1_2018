using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBusqueda.escritores
{
    public class EscritorIndice
    {
        public static void Escribir_Indice(string path, Database indice)
        {
            //TODO: marcar atributos no relevantes de indice (Database) como [NonSerialized]
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(
                path,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None
                );
            formatter.Serialize(stream, indice);
            stream.Close();
        }
    }
}
