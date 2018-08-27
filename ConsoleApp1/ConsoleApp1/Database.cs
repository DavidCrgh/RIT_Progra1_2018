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
        private List<string> list_docs = new List<string>();
        private Dictionary<string, Dictionary<string, int>> docs_words_quantity = new Dictionary<string, Dictionary<string, int>>();

        public Database()
        {
        }

        public void Set_terms(Dictionary<string, Document> docs)
        {
            foreach (var temp in docs.Values)
            {
                this.list_docs.Add(temp.Get_name());
                foreach (var temp2 in temp.Get_words_document())
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

            foreach (var temp in this.list_docs)
            {
                this.docs_words_quantity.Add(temp, init);
            }
        }

        public int Get_lenght_dic()
        {
            return this.docs_words_quantity.Count;
        }
    }
}
