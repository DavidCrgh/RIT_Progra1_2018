using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Term
    {
        private string word = "";
        private int appearances = 0;

        public Term(string n, int v)
        {
            this.word = n;
            this.appearances = v;
        }

        public string Get_word()
        {
            return this.word;
        }

        public int Get_appearances()
        {
            return this.appearances;
        }
    }
}
