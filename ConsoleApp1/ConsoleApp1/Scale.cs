using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Scale
    {
        private Dictionary<string, double> scale = new Dictionary<string, double>();

        public Scale()
        {
        }
        
        public void Add_scale(string doc, double value)
        {
            this.scale.Add(doc, value);
        }

        public void Clean_scale()
        {
            this.scale.Clear();
        }

        public void print_Scale()
        {
            int pos = 1;

            var sort_scale = from entry in this.scale orderby entry.Value descending select entry;
            foreach (var temp in sort_scale)
            {
                Console.WriteLine(pos + "\t" + temp.Key + "\t:" + temp.Value);
                pos++;
            }
        }

        public void print_2()
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
