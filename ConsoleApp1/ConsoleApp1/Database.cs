using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Database
    {
        private Query query;
        private List<string> list_terms = new List<string>();
        private List<Document> doc_info = new List<Document>();
        private Dictionary<string, Term> query_info = new Dictionary<string, Term>();
        private Dictionary<string, int> appearances_words = new Dictionary<string, int>();
        private Dictionary<string, Dictionary<string, Term>> words_per_doc = new Dictionary<string, Dictionary<string, Term>>();

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

        public void Set_query(Query q)
        {
            this.query = q;
        }

        public Query Get_Query()
        {
            return this.query;
        }

        public List<Document> Get_doc_info()
        {
            return this.doc_info;
        }

        public List<string> Get_terms()
        {
            return this.list_terms;
        }

        public Dictionary<string, Term> Make_terms_dic()
        {
            Dictionary<string, Term> init = new Dictionary<string, Term>();

            foreach (var temp2 in this.list_terms)
            {
                init.Add(temp2, new Term(0));
            }

            return init;
        }

        public Dictionary<string, int> Make_appearances_dic()
        {
            Dictionary<string, int> init = new Dictionary<string, int>();

            foreach (var temp2 in this.list_terms)
            {
                init.Add(temp2, 0);
            }
            return init;
        }

        public void Set_query_diccionary()
        {
            this.query_info = this.Make_terms_dic();

        }

        public void Set_diccionary()
        {
            
            foreach (var temp in this.doc_info)
            {
                this.words_per_doc.Add(temp.Get_name(),this.Make_terms_dic());
            }

            this.appearances_words = this.Make_appearances_dic();
        }

        public void Set_words_per_doc()
        {
            foreach (var temp in this.doc_info)
            {
                this.Set_word_doc(temp);
            }
        }

        public void Set_word_doc(Document doc)
        {
            foreach (var temp2 in doc.Get_words_document())
            {
                this.words_per_doc[doc.Get_name()][temp2].Set_appearances();
            }
        }

        public void Set_word_query()
        {
            foreach (var temp2 in this.query.Get_words_query())
            {
                this.query_info[temp2].Set_appearances();
            }
        }

        public void Get_appearances_words_per_docs()
        {
            int appearances = 0;
            foreach (var temp in this.list_terms)
            {
                foreach (var word in this.words_per_doc.Values)
                {
                    if (word[temp].Get_appearance() != 0)
                    {
                        appearances ++;
                    }
                }

                this.appearances_words[temp] = appearances;
                appearances = 0;
            }
        }

        public Dictionary<string, Dictionary<string, Term>> Get_dic_docs_word()
        {
            return this.words_per_doc;
        }

        public Dictionary<string, int> Get_dic_appearances_words()
        {
            return this.appearances_words;
        }

        public void print()
        {
            foreach (var temp in this.words_per_doc)
            {
                Console.WriteLine(temp.Key);
                foreach (var temp2 in temp.Value)
                {
                    Console.WriteLine(temp2.Key + ": " + temp2.Value.Get_appearance());
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
                    if (temp2.Value.Get_appearance() != 0)
                    {
                        Console.WriteLine("\t" + temp2.Key + "\t: " + "\t" + temp2.Value.Get_appearance());
                    }
                }
            }
        }

        public void print3()
        {
            foreach (var temp in this.appearances_words)
            {
                Console.WriteLine("\t" + temp.Key + "\t: " + "\t" + temp.Value.ToString());
            }
        }

        public void print4()
        {
            Console.WriteLine(this.query.Get_name());
            foreach (var temp in this.query_info)
            {
                Console.WriteLine(temp.Key + ": " + temp.Value.Get_appearance());
            }
        }

        public void print5()
        {
            Console.WriteLine(this.query.Get_name());
            foreach (var temp in this.query_info)
            {
                if (temp.Value.Get_appearance() != 0)
                {
                    Console.WriteLine(temp.Key + ": " + temp.Value.Get_appearance());
                }
            }
        }
    }
}
