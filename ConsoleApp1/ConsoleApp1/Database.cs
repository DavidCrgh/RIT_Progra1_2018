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
        private List<Document> doc_info = new List<Document>();
        private Dictionary<string, Dictionary<string, double>> words_per_doc = new Dictionary<string, Dictionary<string, double>>();

        public Database()
        {
        }

        public void Set_docs(List<Document> docs)
        {
            foreach (var temp in docs)
            {
                this.doc_info.Add(temp);
            }
        }

        public void Set_terms()
        {
            foreach (var temp in this.doc_info)
            {
                foreach (var temp2 in temp.Get_words_document())
                {
                    if (!this.list_terms.Contains(temp2))
                    {
                        this.list_terms.Add(temp2);
                    }
                }
            }
        }

        public List<Document> Get_doc_info()
        {
            return this.doc_info;
        }

        public List<string> Get_terms()
        {
            return this.list_terms;
        }

        public Dictionary<string, double> Make_terms_dic()
        {
            Dictionary<string, double> init = new Dictionary<string, double>();

            foreach (var temp2 in this.list_terms)
            {
                init.Add(temp2, 0);
            }

            return init;
        }

        public void Set_diccionary()
        {
            
            foreach (var temp in this.doc_info)
            {
                this.words_per_doc.Add(temp.Get_name(),this.Make_terms_dic());
            }

            this.words_per_doc.Add("appearances", this.Make_terms_dic());
        }

        public void Set_words_per_doc()
        {
            foreach (var temp in this.doc_info)
            {
                foreach (var temp2 in temp.Get_words_document())
                {
                    this.words_per_doc[temp.Get_name()][temp2] ++;
                }
            }
        }

        public void Get_appearances_words_per_docs()
        {
            int appearances = 0;
            foreach (var temp in this.list_terms)
            {
                foreach (var word in this.words_per_doc.Values)
                {
                    if (word[temp] != 0)
                    {
                        appearances ++;
                    }
                }
                this.words_per_doc["appearances"][temp] = appearances;
                appearances = 0;
            }
        }

        public Dictionary<string, Dictionary<string, double>> Get_dic_docs_word()
        {
            return this.words_per_doc;
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

        public void print2()
        {
            foreach (var temp in this.words_per_doc)
            {
                Console.WriteLine(temp.Key);
                foreach (var temp2 in temp.Value)
                {
                    if (temp2.Value != 0)
                    {
                        Console.WriteLine("\t" + temp2.Key + "\t: " + "\t" + temp2.Value.ToString());
                    }
                }
            }
        }

        public void print3()
        {
            foreach (var temp in this.words_per_doc["appearances"])
            {
                Console.WriteLine("\t" + temp.Key + "\t: " + "\t" + temp.Value.ToString());
            }
        }
    }
}
