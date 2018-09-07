using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.algoritmos
{
    class Vectorial
    {
        private Dictionary<string, Dictionary<string, Term>> dic_words = new Dictionary<string, Dictionary<string, Term>>();
        private Dictionary<string, Dictionary<String, int>> appearances = new Dictionary<string, Dictionary<string, int>>();
        private int quantity_docs = 0;

        public Vectorial()
        {
        }

        public void Set_quantity_docs()
        {
            this.quantity_docs = this.dic_words.Count;
        }

        public void Set_dic(Dictionary<string, Dictionary<string, Term>> dic)
        {
            this.dic_words = dic;
            this.Set_quantity_docs();
        }

        public void Set_dic_appearances(Dictionary<string, Dictionary<string, int>> dic)
        {
            this.appearances = dic;
        }

        public void algorithm()
        {
            foreach (var temp in this.dic_words.Values)
            {
                foreach (var word in temp.Keys)
                {
                    if (temp[word].Get_appearance() != 0)
                    {
                        temp[word].Set_vectorial(this.Calculate_weigth(temp[word]) * this.Calculate_N_ni(word));   
                    }
                }
            }
        }

        public double Calculate_weigth(Term word)
        {
            double value = (double)1 + Math.Log(word.Get_appearance(), 2);
            return value;
        }

        public double Calculate_N_ni(string word)
        {            
            double num = (double)this.quantity_docs / (double)this.appearances["appearances"][word];
            double value = Math.Log(num, 2);
            return value;
        }

        public void print()
        {
            foreach (var temp in this.dic_words.Keys)
            {
                Console.WriteLine(temp);
                foreach (var temp2 in this.dic_words[temp])
                {
                    if(temp2.Value.Get_vectorial() != 0)
                    {
                        Console.WriteLine(temp2.Key + ": " + temp2.Value.Get_vectorial());
                    }
                }
            }
        }
    }
}
