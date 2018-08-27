using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Database
    {
        private List<string> list_terms = new List<string>();
        private Dictionary<string, Document> doc_info = new Dictionary<string, Document>();
        private Dictionary<string, Dictionary<string, int>> words_per_doc = new Dictionary<string, Dictionary<string, int>>();

        public Database()
        {
        }

        public void Set_terms(Dictionary<string, Document> docs)
        {
            foreach (var temp in docs)
            {
                this.doc_info.Add(temp.Key.ToString(), temp.Value);
                foreach (var temp2 in temp.Value.Get_words_document())
                {
                    if (!this.list_terms.Contains(temp2))
                    {
                        this.list_terms.Add(temp2);
                    }
                }
            }
        }

        public List<string> Get_terms()
        {
            return this.list_terms;
        }

        public void Set_diccionary()
        {
            Dictionary<string, int> init = new Dictionary<string, int>();

            foreach (var temp2 in this.list_terms)
            {
                init.Add(temp2, 0);
            }

            foreach (var temp in this.doc_info.Keys)
            {
                this.words_per_doc.Add(temp, init);
            }
        }

        public void Set_words_per_doc()
        {
            foreach (var temp in this.doc_info.Keys)
            {
                foreach (var temp2 in this.doc_info[temp].Get_words_document())
                {
                    this.words_per_doc[temp][temp2] += 1;
                    //Console.WriteLine(temp + " " + temp2 + " " + this.words_per_doc[temp][temp2]);
                }
            }
        }

        public void print()
        {
            foreach (var temp in this.words_per_doc)
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
