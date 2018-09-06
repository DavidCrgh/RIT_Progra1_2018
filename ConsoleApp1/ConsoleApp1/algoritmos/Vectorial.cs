using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.algoritmos
{
    class Vectorial
    {
        private Dictionary<string, Dictionary<string, double>> dic_words = new Dictionary<string, Dictionary<string, double>>();
        private Dictionary<string, Dictionary<string, double>> appearances = new Dictionary<string, Dictionary<string, double>>();
        private int quantity_docs = 0;

        public Vectorial()
        {
        }

        public void Set_dic(Dictionary<string, Dictionary<string, double>> dic)
        {
            foreach (var temp in dic)
            {
                this.dic_words.Add(temp.Key, temp.Value);
            }
            this.appearances.Add("appearances", this.dic_words["appearances"]);
            this.dic_words.Remove("appearances");
            this.quantity_docs = this.dic_words.Count();
        }

        public void algorithm()
        {
            foreach (var temp in this.dic_words.Keys)
            {
                Console.WriteLine(temp);
                foreach (var word in this.dic_words[temp].Keys)
                {
                    if (this.dic_words[temp][word] != 0)
                    {
                        //this.dic_words[temp][word] = 1;
                        //(1 + Math.Log(temp[word], 2)) * Math.Log((this.quantity_docs / this.appearances["appearances"][word]), 2)
                        Console.WriteLine(word + ": " + this.dic_words[temp][word]);
                    }
                }
            }
        }

        public void print()
        {
            foreach (var temp in this.dic_words)
            {
                Console.WriteLine(temp.Key);
                foreach (var temp2 in temp.Value)
                {
                    Console.WriteLine(temp2.Key + ": " + temp2.Value.ToString());
                }
            }
        }
    }
}
