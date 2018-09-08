using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBusqueda
{
    [Serializable]
    public class Scale
    {
        private Dictionary<string, double> scale = new Dictionary<string, double>();

        public Scale()
        {
        }

        public Dictionary<string, double> Get_scale()
        {
            return this.scale;
        }
        
        public void Add_scale(string doc, double value)
        {
            this.scale.Add(doc, value);
        }

        public void Clean_scale()
        {
            this.scale.Clear();
        }

        public void Sort()
        {
            Dictionary<string, double> sorted_scale = new Dictionary<string, double>();
            var sorter = from entry in this.scale orderby entry.Value descending select entry;

            foreach (var temp in sorter)
            {
                sorted_scale.Add(temp.Key, temp.Value);
            }

            this.scale = sorted_scale;
        }

        public void print_Scale() //TODO: Quitar
        {
            int pos = 1;

            var sort_scale = from entry in this.scale orderby entry.Value descending select entry;
            foreach (var temp in sort_scale)
            {
                Console.WriteLine(pos + "\t" + temp.Key + "\t:" + temp.Value);
                pos++;
            }
        }

        public void print_2() //TODO: Quitar
        {
            List<string> relevantes = new List<string> { "chgrp.1",
                "chmod.1",
                "chown.1",
                "cp.1",
                "ldd.1",
                "ln.1",
                "mkdir.1",
                "mv.1",
                "rm.1","time.1"};
            foreach(KeyValuePair<string, double> entry in scale)
            {
                if (relevantes.Contains(entry.Key))
                {
                    Console.WriteLine(entry.Key + "\t:" + entry.Value);
                }
            }
        }
    }
}
