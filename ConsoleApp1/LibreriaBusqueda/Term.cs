using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBusqueda
{
    public class Term
    {
        private int appearances = 0;
        private double idf_bm25 = 0;
        private double idf_vec = 0;
        private double weigth_vectorial_out = 0;
        private double weigth_vectorial_with = 0;
        private double similitude_per_word = 0;

        public Term(int num)
        {
            this.appearances = num;
        }

        public void Set_vec(double n)
        {
            this.idf_vec = n;
        }

        public void Set_appearances()
        {
            this.appearances ++;
        }

        public void Set_vectorial(double num)
        {
            this.weigth_vectorial_out = num;
        }

        public void Set_bm25(double num)
        {
            this.idf_bm25 = num;
        }

        public void Set_vectorial_weight(double num)
        {
            this.weigth_vectorial_with = num;
        }

        public void Set_silitude(double num)
        {
            this.similitude_per_word = num;
        }

        public int Get_appearance()
        {
            return this.appearances;
        }

        public double Get_vectorial()
        {
            return this.weigth_vectorial_out;
        }

        public double Get_bm25()
        {
            return this.idf_bm25;
        }

        public double Get_vec()
        {
            return this.idf_vec;
        }

        public double Get_vectorial_normalize()
        {
            return this.weigth_vectorial_with;
        }

        public double Get_similitude()
        {
            return this.similitude_per_word;
        }
    }
}
