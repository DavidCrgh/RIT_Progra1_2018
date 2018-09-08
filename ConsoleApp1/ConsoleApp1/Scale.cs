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
            var sort_scale = from entry in this.scale orderby entry.Value descending select entry;
            foreach (var temp in sort_scale)
            {
                Console.WriteLine(temp.Key + "\t:" + temp.Value);
            }
        }
    }
}
