using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Term
    {
        private int appearances = 0;
        private int weigth_vectorial = 0;
        private int weigth_bm25 = 0;

        public Term(int num)
        {
            this.appearances = num;
        }

        public void Set_vectorial(int num)
        {
            this.weigth_vectorial = num;
        }

        public void Set_bm25(int num)
        {
            this.weigth_bm25 = num;
        }

        public int Get_appearance()
        {
            return this.appearances;
        }

        public int Get_vectorial()
        {
            return this.weigth_vectorial;
        }

        public int Get_bm25()
        {
            return this.weigth_bm25;
        }
    }
}
